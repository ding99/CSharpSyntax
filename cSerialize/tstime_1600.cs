#define DDEBUG

using System;
using System.IO;
using System.Collections.Generic;

using DTAPINET;
using CommonLogs;

namespace TSTimes {

	public enum TSStat {
		None = 0,
		Waiting,
		Running,
		Success,
		Failure
	}

	public class StatArgs : EventArgs {
		public TSStat status;
		public int progress;
		public string message;
		public DateTime ctime;
		public DateTime ptime;

		public bool abort;

		public StatArgs() {
			this.status = TSStat.None;
			this.progress = 0;
			this.message = String.Empty;
			this.ctime = DateTime.Now;
			this.ptime = new DateTime();

			this.abort = false;
		}
	}

	public class Mailer {
		//Prod:10.42.255.2; Corp:172.18.88.40
		private string server;
		private string sender;
		private string report;
		private string[] mails;

		public Mailer(string accounts) {
			this.server = Properties.Settings.Default.Mail;
			this.sender = "timechecker@bydeluxe.com";
			this.report = "Time Check Report (DO NOT REPLY)";

			string[] mst = accounts.Split(';');
			this.mails = new string[mst.Length];
			for(int i = 0; i < mst.Length; i++)
				mails[i] = mst[i].Trim();
		}
		public void send(string msg) {
			Layout.SendEmail(this.server, this.sender, this.mails, this.report, msg, null);
		}
	}

    public class TSAnalyzer {
		#region variable
		private EventHandler<StatArgs> evnt;
		private StatArgs stat;

		private Mailer mailer;

		private List<string> failr;

#if DDEBUG
		private CommonLog re;
#endif
		#endregion

		#region private
		#region general
		private bool log(string m = "") {
#if DDEBUG
			this.re.log(m);
#endif
			return false;
		}
		private void logd(byte[] buf, DateTime dt) {
			string path = Properties.Settings.Default.logPath;
			string fd = Path.GetDirectoryName(path);
			string np = fd + (String.IsNullOrWhiteSpace(fd) ? "" : @"\") +
				"log_" + dt.ToString("yyyyMMdd_HHmmss") + ".bin";

			using(FileStream fs = File.Create(np)) {
				fs.Write(buf, 0, buf.Length);
				fs.Close();
			}
		}
		private void mail(string m) {
			if(this.mailer != null)
				this.mailer.send(m);
			this.log(m);
		}

		private bool err(string m) {
			this.upMS(TSStat.Failure, m);
			this.log(m);
			return false;
		}

		private uint b2(byte[] b , int p) {
			return (uint)b[p] << 8 | b[p + 1];
		}

		private int byBCD_prev(byte v, bool hour = false){
			int shd = hour ? 24 : 60, re = ((v >> 4) & 15) * 10 + (v & 15);
			if(re > shd) this.log("BCD code is " + v.ToString("x2") + ". Limit value is " + shd);
			return re > shd ? 0 : re;
		}

		private int byBCD(byte v, bool hour = false) {
			if(((v >> 4) & 15) > 9 || (v & 15) > 9) {
				this.log("Invalid BCD code [" + v.ToString("x2") + "]");
				return -1;
			}

			int shd = hour ? 24 : 60, re = ((v >> 4) & 15) * 10 + (v & 15);
			if(re > shd) this.log("BCD code is " + v.ToString("x2") + ". Limit value is " + shd);
			return re > shd ? -1 : re;
		}

		private void byMJD(int mjd, ref int year, ref int month, ref int day) {
			int yw = (int)((mjd - 15078.2) / 365.25);
			int mw = (int)((mjd - 14956.1 - (int)(yw * 365.25)) / 30.6001);
			int k = (mw == 14 || mw == 15) ? 1 : 0;

			day = mjd - 14956 - (int)(yw * 365.25) - (int)(mw * 30.6001);
			year = yw + k;
			month = mw - 1 - k * 12;
		}

		private string dsptime(DateTime t) {
			return t.ToString("yy-MM-dd HH:mm:ss");
		}

		private bool samet(DateTime d1, DateTime d2) {
			//return d1.Year == d2.Year && d1.Month == d2.Month && d1.Day == d2.Day &&
			//    d1.Hour == d2.Hour && d1.Minute == d2.Minute && d1.Second == d2.Second;
			return Math.Abs(d1.Subtract(new DateTime(1900,1,1)).TotalSeconds -
				d2.Subtract(new DateTime(1900,1,1)).TotalSeconds) < 5.0;
		}
		#endregion

		#region event
		private void upEvent(){
			if(this.evnt != null)
				this.evnt(this, this.stat);
		}
		private void upPgs(int p) {
			this.stat.progress = p;
			this.upEvent();
		}
		private void upStat(TSStat s) {
			this.stat.status = s;
			this.upEvent();
		}
		private void upMesg(string m) {
			this.stat.message = m;
			this.upEvent();
		}
		private void upPS(int p, TSStat s){
			this.stat.progress = p;
			this.upStat(s);
		}
		private void upPM(int p , string m) {
			this.stat.progress = p;
			this.upMesg(m);
		}
		private void upMS(TSStat s , string m) {
			this.stat.status = s;
			this.upMesg(m);
		}
		private void upAll(int p, TSStat s, string m) {
			this.stat.message = m;
			this.upPS(p, s);
		}
		private void upAll(DateTime ct, DateTime pt, int p, TSStat s, string m) {
			this.stat.ctime = ct;
			this.stat.ptime = pt;
			this.upAll(p, s, m);
		}
		#endregion

		#region check
		private void ongoing(string msg, ref DateTime mt) {
			try {
				string dm = String.Empty;
				this.failr.Add(msg);

				if(this.failr.Count > 9) {
					if(DateTime.Now.Subtract(mt).TotalMinutes > 10) {
						dm = this.failr.Count + " read errors." + Environment.NewLine;
						for(int i = 0; i < 5; i++)
							dm += "(" + (i + 1) + ") " + this.failr[i] + Environment.NewLine;
						for(int i = this.failr.Count - 5; i < this.failr.Count; i++)
							dm += "(" + (i + 1) + ") " + this.failr[i] + Environment.NewLine;

						this.mail(dm);
						this.failr = new List<string>();
						mt = DateTime.Now;
					}
				} else if(DateTime.Now.Subtract(mt).TotalMinutes > 60) {
					dm = this.failr.Count + " read errors." + Environment.NewLine;
					foreach(string s in this.failr)
						dm += s + Environment.NewLine;

					this.mail(dm);
					this.failr = new List<string>();
					mt = DateTime.Now;
				}
			}
			catch(Exception e) {
				this.log("Check mail list error. " + e.Message);
			}
		}
		#endregion
		#endregion

		#region public
		public TSAnalyzer() {
			this.evnt = null;
			this.stat = new StatArgs();

			this.failr = new List<string>();

			this.mailer = null;

#if DDEBUG
			string path = Properties.Settings.Default.logPath;
			this.re = new CommonLog(path, Properties.Settings.Default.logID);
#endif
        }

        public bool TSCheck(string accounts, EventHandler<StatArgs> handler) {
			#region variable
			DateTime mtime = DateTime.Now;
			this.evnt = handler;
			this.mailer = new Mailer(accounts);
			this.failr = new List<string>();

			this.mail("TS Time Checker (version " +
				System.Reflection.Assembly.GetEntryAssembly().GetName().Version + ") started!");
			#endregion

			#region attach a device
			DtDevice dv = new DtDevice();
            if(dv.AttachToType(245) != DTAPI_RESULT.OK)
				return this.err("Failed to attach to type");
			#endregion

			#region set device
			byte[] buf = new byte[0];
			int bsize = 4194304; //1048576, 2097152, 4194304, 8388608
			try { buf = new byte[bsize]; }
            catch(Exception e) { return this.err(e.Message); }

            DtInpChannel inp = new DtInpChannel();
            if(inp.AttachToPort(dv , 1) != DTAPI_RESULT.OK)
				return this.err("Failed to Inp Channel");

			if(inp.SetRxControl(DTAPI.RXCTRL_RCV) != DTAPI_RESULT.OK)
				return this.err("Failed to set receive FIFO");
			#endregion

			#region read
			#region prepare
			string msg = String.Empty, dm;
			int afc = 0, iip = 0, y = 0, m = 0, d = 0, hr = 0, mn = 0, sc = 0;
			bool timed = false, read = false, init = true, dated = false, recor = false;

			DateTime ct = DateTime.Now.ToUniversalTime();
			DateTime pt = new DateTime(1900, 1, 1);

			while(!this.stat.abort) {
				pt = new DateTime(1900, 1, 1);
				ct = DateTime.Now.ToUniversalTime();
				read = true;

				#region data
				this.log("to read");
				try { inp.Read(buf, bsize); }
				catch(Exception) {

					read = this.err("Failed to read data at " + this.dsptime(ct));
					this.ongoing("Failed to read data at " + this.dsptime(ct), ref mtime);
					
					#region to del  
					this.failr.Add("Failed to read data at " + this.dsptime(ct));

					if(this.failr.Count > 9) {
						if(DateTime.Now.Subtract(mtime).TotalMinutes > 10) {
							dm = this.failr.Count + " read errors." + Environment.NewLine;
							for(int i = 0; i < 5; i++)
								dm += "(" + (i + 1) + ") " + this.failr[i] + Environment.NewLine;
							for(int i = this.failr.Count - 5; i < this.failr.Count; i++)
								dm += "(" + (i + 1) + ") " + this.failr[i] + Environment.NewLine;

							this.mail(dm);
							this.failr = new List<string>();
							mtime = DateTime.Now;
						}
					}
					else if(DateTime.Now.Subtract(mtime).TotalMinutes > 60) {
						dm = this.failr.Count + " read errors." + Environment.NewLine;
						foreach(string s in this.failr)
							dm += s + Environment.NewLine;

						this.mail(dm);
						this.failr = new List<string>();
						mtime = DateTime.Now;
					}
					#endregion
				}
				if(!read) continue;

				//ct = DateTime.Now.ToUniversalTime(); //to TEST. todo
				if(init) {
					this.logd(buf, ct);
					init = false;
				}
				#endregion

				#region analysis
				timed = false;
				msg = String.Empty;

				#region loop
				this.log("to loop");
				try {
					for(int i = 0; i < bsize; i += 188)
						if(buf[i] == 0x47 && (this.b2(buf, i + 1) & 0x1fff) == 0x14) {
							afc = (buf[i + 3] >> 4) & 3;
							iip = (afc & 2) == 2 ? buf[i + 4] + 5 : 4; //adaptation_field

							if((afc & 1) == 1) {
								iip += buf[i + iip] + 1;
								if(buf[i + iip] == 0x70) {
									this.byMJD((int)this.b2(buf, i + iip + 3), ref y, ref m, ref d);

									if((hr = this.byBCD(buf[i + iip + 5], true)) < 0 ||
									(mn = this.byBCD(buf[i + iip + 6])) < 0 ||
									(sc = this.byBCD(buf[i + iip + 7])) < 0)
										this.logd(buf, ct);
									else {

										dated = true;

										try {
											pt = new DateTime(1900 + y, m, d, hr, mn, sc);
										}
										catch(Exception e) {
											this.log(e.Message);
											this.logd(buf, ct);
											dated = false;
										}
										#region compare
										if(dated) {
											msg = this.samet(ct, pt) ? "Same" : "Different";
											if(msg == "Different") {
												this.mail(msg + ": PlayBack Time " + this.dsptime(pt) + ", Local Time " + this.dsptime(ct));
												this.logd(buf, ct);
												recor = true;
											} else if(recor) {
												this.mail(msg + " (Corrected): PlayBack Time " + this.dsptime(pt) + ", Local Time " + this.dsptime(ct));
												this.logd(buf, ct);
												recor = false;
											}

											timed = true;
											break;
										}
										#endregion
									}
								}
							}
						}
				}
				catch(Exception e) {
					this.log("Failed to analyze data. " + e.Message);
					this.ongoing("Failed to analyze data. " + e.Message, ref mtime);
				}
				#endregion
				#endregion

				if(timed) {
					this.log(msg + ": Play " + this.dsptime(pt) + ", Local " + this.dsptime(ct));
					this.upAll(ct, pt, 100, timed ? TSStat.Success : TSStat.Failure, msg);
				}
			}
			#endregion

			#region abort
			//System.Threading.Thread.Sleep(500);
			//this.upStat(TSStat.Waiting);

			//while(!this.stat.abort) {
			//    System.Threading.Thread.Sleep(500);
			//    this.upEvent();
			//}
			#endregion
			return true;
			#endregion
        }
        #endregion
    }
}

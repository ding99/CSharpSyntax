using System;

namespace cTime {

	public static class Extensions {

		/// From TimeSpan to frame base timecode string hh:mm:ss:ff
		public static string ToFrameString(this TimeSpan ts, double framerate) {
			var str = ts.Hours.ToString("D2") + ":" + ts.Minutes.ToString("D2") + ":" + ts.Seconds.ToString("D2") + ":";
			str = ts < TimeSpan.Zero ? "-" + str : str;

			var intFrameRate = Math.Round(framerate, 0);
			var ff = (int)Math.Round(ts.Milliseconds * intFrameRate / 1000, 0);

			var isDropFrameRate = framerate != (double)((int)framerate);

			if(isDropFrameRate && ts.Seconds == 0 && (ff == 0 || ff == 1) && (Math.IEEERemainder(ts.Minutes, 10.0) != 0.0)) {
				//Drop 00 and 01 frame
				ff = 2;
			}

			str += ff.ToString("D2");

			return str;
		}

		/// Parse a frame base timecode hh:mm:ss:ff to TimeSpan
		public static TimeSpan ParseFrameTimeSpan(this string str, double framerate) {
			string[] tclist = str.Split(':');
			if(tclist.Length != 4)
				return new TimeSpan(0, 0, 0, 0);

			var hh = Int32.Parse(tclist[0]);
			var mm = Int32.Parse(tclist[1]);
			var ss = Int32.Parse(tclist[2]);
			var ff = Int32.Parse(tclist[3]);
			var intFrameRate = Math.Round(framerate, 0);

			var msec = (int)Math.Round(ff * 1000 / intFrameRate, 0);

			return new TimeSpan(0, hh, mm, ss, msec);
		}
	}

	public class chkTime {
		private DateTime start, current;

		#region old test
		private void dsp(DateTime dt) {
			Console.WriteLine("{0}:{1}:{2}.{3}", dt.Hour, dt.Minute, dt.Second, dt.Millisecond);
		}
		private void ddf(TimeSpan dt) {
			Console.WriteLine("{0}:{1}:{2}.{3}", dt.Hours, dt.Minutes, dt.Seconds, dt.Milliseconds);
		}
		public chkTime() {
			this.start = DateTime.Now;
			this.current = DateTime.Now;
		}
		public void dspyear() {
			Console.WriteLine(DateTime.Now.Year + ", " + DateTime.Now.Month + ", " + DateTime.Now.Day);
		}
		public void estimate() {
			System.Threading.Thread.Sleep(1500);
			this.current = DateTime.Now;

			TimeSpan diff = this.current - this.start;
			this.dsp(this.start);
			this.dsp(this.current);
			this.ddf(diff);
			Console.WriteLine(diff.TotalMilliseconds);
			Console.WriteLine(diff.TotalSeconds);
		}

		public void dspround(double fr) {
			Console.WriteLine(fr + " round(" + Math.Round(fr) + ") round0(" + Math.Round(fr, 0) + ") int " + ((int)fr));
		}
		public void testRound() {
			this.dspround(29.97);
			this.dspround(23.976);
			this.dspround(23.5);
			this.dspround(24);

			//Console.WriteLine(Environment.NewLine + "-- Math.IEEERemainder");
			//Console.WriteLine("10.121 " + Math.IEEERemainder(10.121, 10.0));
			//Console.WriteLine("-10.13  " + Math.IEEERemainder(-10.13, 10.0));
			//Console.WriteLine("-10.13  " + Math.IEEERemainder(-10.13, -10.0));
		}
		public void dspmin(TimeSpan ts) {
			Console.Write("ts[" + ts.Hours + ":" + ts.Minutes + ":" + ts.Seconds + "] Minutes[" + ts.Minutes + "] ");
			Console.WriteLine("rei[" + ((ts.Minutes % 10) != 0) + "] red[" + (Math.IEEERemainder(ts.Minutes, 10.0) != .0) + "]");
		}
		public void testMin() {
			Console.WriteLine();
			this.dspmin(new TimeSpan(9, 40, 25));
			this.dspmin(new TimeSpan(9, 41, 25));
		}
		#endregion

		#region round
		private void dspTF(int h, int m, int s, int ms) {
			TimeSpan t = TimeSpan.FromMilliseconds((((h * 60) + m) * 60 + s) * 1000 + ms);
			Console.Write("[" + t.Hours.ToString("D2") + ":" + t.Minutes.ToString("D2") + ":" + t.Seconds.ToString("D2") + "." + t.Milliseconds.ToString("D3")+ "]");
			Console.WriteLine(" -> Frame (" + Extensions.ToFrameString(t, 29.97) + ")");
		}
		public void testTF() {
			this.dspTF(10, 1, 59, 950);
			this.dspTF(10, 1, 59, 951);
			this.dspTF(10, 1, 59, 983);
			this.dspTF(10, 1, 59, 984);
			this.dspTF(10, 2, 0, 0);
			this.dspTF(10, 2, 0, 55);
			this.dspTF(10, 2, 0, 83);
			this.dspTF(10, 2, 0, 84);
		}

		private int getI(double d) {
			return (int)(d + .5);
		}
		private void dRound(double d) {
			Console.WriteLine("  " + d + " " + (int)Math.Round(d, 0) + " " + this.getI(d));
		}
		public void seeRound() {
			this.dRound(-100);
			this.dRound(-60);
			this.dRound(-59.94);
			this.dRound(-30);
			this.dRound(-29.97);
			this.dRound(-23.976);
			this.dRound(0);
			this.dRound(23.976);
			this.dRound(24);
			this.dRound(25);
			this.dRound(29.97);
			this.dRound(30);
			this.dRound(47.952);
			this.dRound(59.94);
			this.dRound(60);
			this.dRound(2.5);
			this.dRound(3.5);
			this.dRound(22.49);
			this.dRound(22.5);
			this.dRound(22.51);
			this.dRound(23.5);
			this.dRound(24.5);
		}
		#endregion

		#region conversion
		private static int getIntFrameRate(double fFramerate) {
			int nFrameRate = 24;
			if(fFramerate <= 11)
				nFrameRate = 24;
			else if(fFramerate > 11 && fFramerate <= 12)
				nFrameRate = 12;
			else if(fFramerate > 14 && fFramerate <= 15)
				nFrameRate = 15;
			else if(fFramerate > 23.0 && fFramerate <= 24.0)
				nFrameRate = 24;
			else if(fFramerate <= 25.0)
				nFrameRate = 25;
			else if(fFramerate <= 30)
				nFrameRate = 30;
			else if(fFramerate <= 50.0)
				nFrameRate = 50;
			else if(fFramerate <= 60.0)
				nFrameRate = 60;
			return nFrameRate;
		}

		public static bool frame2Msec(string frame, out string msec, double rate, bool drop) {
			msec = String.Empty;
			string[] tl = frame.Split(':');
			if(tl.Length != 4 || rate == 0)
				return false;

			int ndrop = 0, h, m, s, f;
			if(!int.TryParse(tl[0], out h) || !int.TryParse(tl[1], out m))
				return false;
			if(!int.TryParse(tl[2], out s) || !int.TryParse(tl[3], out f))
				return false;

			if(rate > 29.9 && rate < 30.0 && drop)
				ndrop = 2 * (h * 60 + m - (h * 6 + m / 10));
			else if(rate > 59.9 && rate < 60.0 && drop)
				ndrop = 4 * (h * 60 + m - (h * 6 + m / 10));

			int nf = ((h * 60 + m) * 60 + s) * getIntFrameRate(rate) + f - ndrop, n = (int)(nf / rate);
			Console.Write(nf + " ");

			msec = (n / 3600).ToString("D2") + ":" + ((n / 60) % 60).ToString("D2") + ":" + (n % 60).ToString("D2");
			msec += "." + ((int)((nf / rate - n) * 1000)).ToString("D3");
			return true;
		}
		public static bool msec2Frame(string msec, out string frame, double rate, bool drop) {
			frame = String.Empty;
			if(rate == 0)
				return false;

			int n = msec.LastIndexOf("."), h, m, s, ms, fr = getIntFrameRate(rate);
			if(n < 0 || !int.TryParse(msec.Substring(n + 1), out ms))
				return false;

			string[] l = msec.Substring(0, n).Split(':');
			if(l.Length != 3)
				return false;

			if(!int.TryParse(l[0], out h) || !int.TryParse(l[1], out m) || !int.TryParse(l[2], out s))
				return false;
			int nf = (int)Math.Round(((h * 60 + m) * 60 + s + (double)ms / 1000.0) * rate, 0);
			Console.Write(h.ToString("D2") + "-" + m.ToString("D2") + "-" + s.ToString("D2") + " " + nf + " ");

			if(drop) {
				ms = fr == 60 ? 4 : 2;
				h = nf / (fr * 600 - 9 * ms);
				m = nf % (fr * 600 - 9 * ms);
				frame = (h / 6).ToString("D2") + ":" + (h % 6).ToString(); // per 10 minutes

				if(m < fr * 60)
					frame += "0:" + (m / fr).ToString("D2") + ":" + (m % fr).ToString("D2");  // first minute
				else {
					frame += ((m - fr * 60) / (fr * 60 - ms) + 1).ToString() + ":";
					if((s = (m - fr * 60) % (fr * 60 - ms)) < fr - ms)
						frame += "00:" + (s + ms).ToString("D2");  // first second
					else
						frame += ((s + ms - fr) / fr + 1).ToString("D2") + ":" + ((s + ms - fr) % fr).ToString("D2");
				}

			}
			else {  // non frop
				s = nf / fr;
				frame = (s / 3600).ToString("D2") + ":" + ((s / 60) % 60).ToString("D2");
				frame += ":" + (s % 60).ToString("D2") + ":" + (nf % fr).ToString("D2");
			}

			return true;
		}

		public void f2m(string frame, double rate, bool drop) {
			string ms;
			bool ret = frame2Msec(frame, out ms, rate, drop);
			Console.WriteLine("f2m [" + frame + "] [" + ms + "] " + rate + " " + drop);
		}
		public void m2f(string ms, double rate, bool drop) {
			string frame;
			bool ret = msec2Frame(ms, out frame, rate, drop);
			Console.WriteLine("m2f [" + ms + "] [" + frame + "] " + rate + " " + drop);
		}

		public void cal() {
			this.f2m("00:10:00:00", 29.97, false);
			this.f2m("00:10:12:00", 29.97, false);
			this.f2m("00:11:00:02", 29.97, false);
			this.f2m("00:11:12:00", 29.97, false);
			this.f2m("00:10:00:00", 29.97, true);
			this.f2m("00:10:12:00", 29.97, true);
			this.f2m("00:11:00:02", 29.97, true);
			this.f2m("00:11:12:00", 29.97, true);

			Console.WriteLine("---");
			this.m2f("00:10:00.600", 29.97, false);
			this.m2f("00:10:12.612", 29.97, false);
			this.m2f("00:11:00.727", 29.97, false);
			this.m2f("00:11:12.672", 29.97, false);
			this.m2f("00:10:00.000", 29.97, true);
			this.m2f("00:10:12.012", 29.97, true);
			this.m2f("00:11:00.060", 29.97, true);
			this.m2f("00:11:12.005", 29.97, true);
		}

		public void sub() {
			DateTime dt = DateTime.Now;
			Console.WriteLine(dt);
			DateTime ndt = dt.Add(new TimeSpan(0,2,5));
			Console.WriteLine(ndt);
			double min = ndt.Subtract(DateTime.Now).TotalMinutes;
			Console.WriteLine(min);
		}
		#endregion

		#region timespan
		public void tspan() {
			int h = 15, m = 2, s = 3, ms = 300;
			TimeSpan ts = new TimeSpan(0, h, m, s, ms);
			Console.WriteLine(h + "-" + m + "-" + s + "-" + ms + ", " + ts);
			string msg = ts.ToString(@"hh\:mm\:ss\.fff");
			Console.WriteLine(msg);
		}
		#endregion

		#region convert
		private bool string2frame(string stime, int rate, ref int nframe) {
			string[] c = stime.Split(':');
			if(c.Length != 4)
				return false;

			int h, m, s, f;
			if(!Int32.TryParse(c[0], out h) || !Int32.TryParse(c[1], out m) ||
				!Int32.TryParse(c[2], out s) || !Int32.TryParse(c[3], out f))
				return false;

			nframe = ((h * 60 + m) * 60 + s) * rate + f;
			return true;
		}

		private string frame2string(int nframe, int rate) {
			if(rate == 0)
				return String.Empty;

			int m = nframe / rate;
			return (m / 3600).ToString("D2") + ":" + (m / 60 % 60).ToString("D2") + ":" +
				(m % 60).ToString("D2") + ":" + (nframe % rate).ToString("D2");
		}

		public void rere() {
			string org = "00:00:53:13";
			Console.WriteLine(org);

			int n = 0, rate = 24;
			bool ret = this.string2frame(org, rate, ref n);
			Console.WriteLine("String to nframe: " + (ret ? "Successful" : "Failure"));

			Console.WriteLine(this.frame2string(n, rate));
		}

		private void oneratio(string fst, string snd) {
			int fi = 0, se = 0, rate = 24;

			if(!this.string2frame(fst, rate, ref fi))
				Console.WriteLine("  failed to convert " + fst);
			if(!this.string2frame(snd, rate, ref se))
				Console.WriteLine("  failed to convert " + snd);

			int re1 = (int)Math.Round(fi * 1.000999);
			int re2 = (int)(fi * 1.001);
	
			if(fi != 0)
				Console.WriteLine(String.Format("{0} {1} {2, 4:D} {3, 1:D} {4, 1:D}  {5}",
					fst, snd, se - fi, re1 - se, re2 - se, 1.0 * se / fi));
		}

		public void getratios() {
			this.oneratio("00:00:53:13", "00:00:53:13");
			this.oneratio("00:44:26:05", "00:44:28:20");
			this.oneratio("00:45:10:15", "00:45:13:07");
			this.oneratio("01:00:02:20", "01:00:06:09");

			Console.WriteLine("...");
			this.oneratio("01:20:29:19", "01:20:34:13");
			this.oneratio("01:20:32:00", "01:20:36:18");
			Console.WriteLine("");

			Console.WriteLine("-- continous");
			this.oneratio("01:21:54:04", "01:21:59:00");
			this.oneratio("01:21:58:08", "01:22:03:04");
			this.oneratio("01:22:01:14", "01:22:06:11");
			this.oneratio("01:22:06:13", "01:22:11:10");
			this.oneratio("01:23:00:15", "01:23:05:13");
			this.oneratio("01:23:03:13", "01:23:08:11");
			this.oneratio("01:23:03:16", "01:23:08:14");
			this.oneratio("01:23:05:16", "01:23:10:14");
			this.oneratio("01:23:05:19", "01:23:10:17");
			this.oneratio("01:23:07:20", "01:23:12:18");
			this.oneratio("01:23:07:22", "01:23:12:20");

			this.oneratio("01:23:11:12", "01:23:16:10");
			this.oneratio("01:23:11:15", "01:23:16:13");
			this.oneratio("01:23:14:16", "01:23:19:14");
			this.oneratio("01:23:14:18", "01:23:19:16");
			this.oneratio("01:23:18:00", "01:23:22:22");
			this.oneratio("01:23:19:14", "01:23:24:12");
			this.oneratio("01:23:23:08", "01:23:28:06");

			this.oneratio("01:23:23:11", "01:23:28:10");
			this.oneratio("01:23:26:04", "01:23:31:03");
			this.oneratio("01:23:26:07", "01:23:31:06");
			this.oneratio("01:23:29:13", "01:23:34:12");
			this.oneratio("01:23:29:16", "01:23:34:15");
			this.oneratio("01:23:32:11", "01:23:37:10");
			this.oneratio("01:23:32:13", "01:23:37:12");
			this.oneratio("01:23:34:12", "01:23:39:11");

			Console.WriteLine("...");
			this.oneratio("01:23:32:13", "01:23:37:12");
			this.oneratio("01:23:34:12", "01:23:39:11");
			this.oneratio("01:23:34:15", "01:23:39:14");
			this.oneratio("01:23:37:10", "01:23:42:09");
			this.oneratio("01:23:37:12", "01:23:42:11");
			this.oneratio("01:23:41:00", "01:23:45:23");
			this.oneratio("01:23:41:03", "01:23:46:02");
			this.oneratio("01:23:44:00", "01:23:48:23");
			this.oneratio("01:23:44:02", "01:23:49:01");
			this.oneratio("01:23:46:20", "01:23:51:19");
		}
		#endregion

		#region time formate
		public void dspDate() {
			Console.WriteLine("-- Datatime");

			DateTime date = DateTime.Now;
			Console.WriteLine("d [" + date.ToString("d") + "]");
			Console.WriteLine("yy-MM-dd HH:mm:ss [" + date.ToString("yy-MM-dd HH:mm:ss") + "]");
			Console.WriteLine("yyyyMMdd-HHmmss [" + date.ToString("yyyyMMdd-HHmmss") + "]");
			Console.WriteLine();

			Console.WriteLine("-- TimeSpan (create 9:30:50)");

			TimeSpan tm = new TimeSpan(9, 30, 50);
			Console.WriteLine((new DateTime(tm.Ticks)).ToString("HH:mm:ss"));
		}
		#endregion
	}
}

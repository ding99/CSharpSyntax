using System;
using System.IO;
using System.Timers;
using System.Collections.Generic;

namespace CTimer {

	public class TimingOld {

		private int nInterval = 1000 * 5; //1 second
		private System.Threading.Timer mytime;

		private string folder;
		private List<string> files;

		public TimingOld() {
			this.files = new List<string>();
		}

		public void start(string path) {
			this.folder = path;
			this.files = new List<string>();

			this.mytime = new System.Threading.Timer(new System.Threading.TimerCallback(TimeAction));
			this.mytime.Change(0, this.nInterval);
			Console.WriteLine("stating");

			Console.ReadLine();
		}

		private void TimeAction(object e){

			Console.WriteLine("-- " + DateTime.Now);

			if(Directory.Exists(this.folder)) {

				string[] files = System.IO.Directory.GetFiles(this.folder, "*");

				foreach(string filePath in files) {

					if(!this.files.Contains(filePath) && !filePath.EndsWith(".DS_Store")) {
						Console.WriteLine("Updated File : " + filePath);

						if(new FileInfo(filePath).Exists) {
							Console.WriteLine(" Lock : " + isFileLocked(new FileInfo(filePath)) + "" + this.files.Contains(filePath));
							if(!isFileLocked(new FileInfo(filePath)) && !this.files.Contains(filePath)) {
								this.files.Add(filePath);
								//if md5 isalready present or md5 file is older than your cuurent file.
							}
						} else {
							this.files.Remove(filePath);
						}
					}
				}
			}
		}

		private bool isFileLocked(FileInfo file) {
			FileStream stream = null;
			bool isLocked = false;
			try {
				stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
			}
			catch(IOException) {
				isLocked = true;
			}
			catch(Exception) {
				isLocked = false;
			}
			finally {
				if(stream != null) {
					stream.Close();
				}
			}
			return isLocked;
		}
	}

	public class Timing {

		private int nInterval = 10000; //20 second

		private string folder;
		private List<string> files;

		public Timing() {
			this.files = new List<string>();
		}

		public void start(string path) {
			Console.WriteLine("Folder [" + path + "]");

			this.folder = path;
			this.files = new List<string>();

			Timer ter = new Timer(this.nInterval);
			ter.Elapsed += TimeAction;
			ter.AutoReset = true;
			ter.Enabled = true;

			Console.WriteLine("started");
			Console.ReadLine();

			ter.Stop();
			ter.Dispose();

			Console.WriteLine("stoped");
		}

		private void TimeAction(object source, ElapsedEventArgs e) {

			Console.WriteLine("-- " + e.SignalTime);
			bool locked = false, conted = false;
			List<string> era = new List<string>();

			if(Directory.Exists(this.folder)) {

				#region delete
				foreach(string s in this.files)
					if(!File.Exists(s))
						era.Add(s);

				if(era.Count > 0) {
					foreach(string s in era) {
						this.files.Remove(s);
						Console.WriteLine("   Remove [" + s + "]");
					}
					Console.WriteLine("   count " + this.files.Count);
				}
				#endregion

				#region add
				string[] files = Directory.GetFiles(this.folder, "*");

				foreach(string s in files)
					if(!this.files.Contains(s) && !s.EndsWith(".DS_Store")) {

						locked = this.locked(s);
						conted = this.files.Contains(s);

						if(!locked && !conted) {
							this.files.Add(s);
							Console.WriteLine("   Added  [" + s + "] " + this.files.Count);
							//if md5 isalready present or md5 file is older than your cuurent file.
						}
					}
				#endregion
			}
		}

		private bool locked(string file) {
			FileStream stream = null;
			bool isLocked = false;
			try {
				stream = new FileStream(file, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
			}
			catch(IOException) {
				isLocked = true;
			}
			catch(Exception) {
				isLocked = false;
			}
			finally {
				if(stream != null) {
					stream.Close();
				}
			}
			return isLocked;
		}
	}

	class Entry {

		static void Main(string[] args) {
			Console.WriteLine("== Begin");

			if(args.Length < 1) {
				Console.WriteLine("usage: timer <file_path>");
				return;
			}

			new Timing().start(args[0]);

			Console.WriteLine("== End");
		}

	}
}

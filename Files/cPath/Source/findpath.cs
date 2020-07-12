using System;
using System.IO;

namespace cPath {
	public class TPath {
		public TPath() {
		}

		public void createFile(string[] args, string file) {
			if(args.Length < 1) {
				Console.WriteLine("cPath <path>");
				return;
			}

			Console.WriteLine((Directory.Exists(args[0]) ? "Exist" : "Not Found") + " [" + args[0] + "]");

			bool wex = true;
			string tfile = args[0] + file;

			FileStream stream = null;
			try {
				stream = File.Open(tfile, FileMode.CreateNew, FileAccess.Write, FileShare.None);
			}
			catch(Exception) {
				wex = false;
			}
			if(stream != null) stream.Close();

			Console.WriteLine((wex ? "Exist" : "Not Found") + " [" + tfile + "]");

			if(File.Exists(tfile)) {
				File.Delete(tfile);
				Console.WriteLine("Deleted [" + tfile + "]");
			}
			return;
		}

		public void currentdir() {
			string loca = System.Reflection.Assembly.GetEntryAssembly().Location;
			Console.WriteLine("loca  [" + loca + "]");
			string logf = Path.GetDirectoryName(loca) + @"\logs\Render.log";
			Console.WriteLine("file  [" + logf + "]");

			string aname = System.Reflection.Assembly.GetEntryAssembly().GetName().Name;
			Console.WriteLine("entry [" + aname + "]");

			string ename = this.GetType().Name;
			Console.WriteLine("exec  [" + ename + "]");
		}

		public void temppath() {
			Console.WriteLine("Temp");
			string tname = Path.GetTempFileName();
			Console.WriteLine("  file [" + tname + "]");
			Console.WriteLine("  name [" + Path.GetFileName(tname) + "]");
			Console.WriteLine("  path [" + Path.GetTempPath() + "]");

			Console.WriteLine();
			Console.WriteLine("currentDomain [" + AppDomain.CurrentDomain.BaseDirectory + "]");
			Console.WriteLine("entryAssembly [" + System.Reflection.Assembly.GetEntryAssembly().Location + "]");
		}

		public void separators() {
			Console.WriteLine("Path Separator [" + Path.PathSeparator.ToString() + "]");
			Console.WriteLine("Dir  Separator [" + Path.DirectorySeparatorChar.ToString() + "]");
		}
	}
}

using System;
using System.IO;
using System.Collections.Generic;

namespace cFolder {
	public class findDirs {
		public findDirs() {
		}

		public void seekDir(string path) {
			try {
				string[] dirs = Directory.GetDirectories(path);
				foreach(string d in dirs)
					Console.WriteLine("-- " + d);
			}
			catch(Exception e) {
				Console.WriteLine("seekDir error [" + e.Message + "]");
			}
		}

		public void seekDir(string path, string file) {
			try {
				string[] dirs = Directory.GetDirectories(path);
				Console.WriteLine("file [" + file + "]");

				foreach(string d in dirs) {
					Console.WriteLine("-- " + d + " [" + File.Exists(d + "\\" + file) + "]");
				}
			}
			catch(Exception e) {
				Console.WriteLine("seekDir error [" + e.Message + "]");
			}
		}

		public void getfiles(string path) {
			try {
				string[] fs = Directory.GetFiles(path);

				Console.WriteLine("files [" + fs.Length + "]");
				foreach(string f in fs)
					Console.WriteLine("  " + f);

				fs = Directory.GetDirectories(path);
				Console.WriteLine("dirs  [" + fs.Length + "]");
				foreach(string f in fs)
					Console.WriteLine("  " + f);

				Console.WriteLine("dir [" + Path.GetDirectoryName(path) + "] of [" + path + "]");
				string npth = "filename.abc";
				Console.WriteLine("dir [" + Path.GetDirectoryName(npth) + "] of [" + npth + "]");
			}
			catch(Exception e) {
				Console.WriteLine("getfiles: " + e.Message);
			}
		}

		public void dirExist(string outdir) {
			if(System.IO.Directory.Exists(outdir)) Console.WriteLine("Already existed : " + outdir);
			else {
				System.IO.Directory.CreateDirectory(outdir);
				if(System.IO.Directory.Exists(outdir)) Console.WriteLine("Succeeded to create directory [" + outdir + "]");
				else Console.WriteLine("Failed to create directory [" + outdir + "]");
			}
		}
	}

	class entrance {
		static void Main(string[] args) {
			findDirs fdir = new findDirs();

			string dir = args.Length > 0 ? args[0] : @"C:\CExec\55-smooth\";
			//fdir.seekDir(dir);
			//fdir.seekDir(dir, @"GroupSmoothStreaming_DRAVCWeb_CBR_Multi_11Layers_DolbyPulse_12_12_54 PM.ism");
			fdir.getfiles(dir);

		}
	}
}

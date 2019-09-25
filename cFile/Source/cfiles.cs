﻿using System;
using System.IO;

namespace cFile {
	public class Files {
		public Files() {
		}

		public bool filecopy() {
			string src = @"C:\test\temp\subdir\tempcp01.bin";
			string dst = @"C:\test\temp\tempcp03.bin";

			try {
				File.Copy(src, dst, true);
				return true;
			}
			catch(Exception e) {
				Console.WriteLine(e.Message);
				return false;
			}
		}

		private void name(string id) {
			Console.WriteLine("==== [" + id + "]");
			Console.WriteLine("path [" + Path.GetDirectoryName(id) + "]");
			Console.WriteLine("file [" + Path.GetFileName(id) + "]");
			Console.WriteLine("ext  [" + Path.GetExtension(id) + "]");
		}
		public bool names() {
			this.name(@"c:\aaa\bbb\cccc.ext");
			this.name(@"file01.ext");
			this.name(@"file 02.txt");
			this.name(@"file 02.first.txt");
			this.name(@"c:\aaa\bbb\cccc");
			this.name(@"c:\aaa\bbb\cccc.");
			return true;
		}

		public bool finfo(string s) {
			Console.WriteLine("File.Exists: " + File.Exists(s));
			Console.WriteLine("FileInfo   : " + new FileInfo(s).Exists);
			Console.WriteLine("FileInfo   : " + (new FileInfo(s)).Exists);

			FileInfo fi = new FileInfo(s);
			fi.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
			return true;
		}
	}

	class Entrance {
		static void Main(string[] args) {
			Files f = new Files();

			bool ret = false;
			
			//ret = f.filecopy();
			ret = f.names();

			//if(args.Length > 0) ret = f.finfo(args[0]);

			Console.WriteLine(ret ? "Successful" : "Failed");
		}
	}
}

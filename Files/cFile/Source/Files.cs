using System;
using System.IO;

namespace cFile
{
	public class Files
	{
		public void filecopy()
		{  
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("-- File Copy");

			string src = @"d:\test\temp\subdir\tempcp01.bin";
			string dst = @"d:\test\temp\tempcp03.bin";

			Console.WriteLine($"souuce: [{src}]");
			Console.WriteLine($"target: [{dst}]");

			try {
				File.Copy(src, dst, true);
				Console.WriteLine("  Success");
			}
			catch (Exception e)
			{
				Console.WriteLine($"Error [{ e.Message}]");
			}
		}

		private void name(string id)
		{
			Console.WriteLine("==== [" + id + "]");
			Console.WriteLine("path [" + Path.GetDirectoryName(id) + "]");
			Console.WriteLine("file [" + Path.GetFileName(id) + "]");
			Console.WriteLine("ext  [" + Path.GetExtension(id) + "]");
		}
		public bool names()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			this.name(@"d:\aaa\bbb\cccc.ext");
			this.name(@"file01.ext");
			this.name(@"file 02.txt");
			this.name(@"file 02.first.txt");
			this.name(@"d:\aaa\bbb\cccc");
			this.name(@"d:\aaa\bbb\cccc.");
			return true;
		}

		public bool finfo()
		{
			Console.ForegroundColor = ConsoleColor.Green;

			string s = @"D:\test\testdata.txt";
			Console.WriteLine("File.Exists: " + File.Exists(s));
			Console.WriteLine("FileInfo   : " + new FileInfo(s).Exists);
			Console.WriteLine("FileInfo   : " + (new FileInfo(s)).Exists);

			FileInfo fi = new FileInfo(s);
			fi.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
			return true;
		}
	}
}

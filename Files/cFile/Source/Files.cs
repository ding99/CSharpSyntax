using System;
using System.IO;

namespace cFile
{
	public class Files
	{
		public void Filecocpy()
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
		public void Nasmes()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			this.name(@"d:\aaa\bbb\cccc.ext");
			this.name(@"file01.ext");
			this.name(@"file 02.txt");
			this.name(@"file 02.first.txt");
			this.name(@"d:\aaa\bbb\cccc");
			this.name(@"d:\aaa\bbb\cccc.");
		}

		public void FInfo()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("-- existing");

			string s = @"D:\test\testdata.txt";
			Console.WriteLine($"original file [{s}]");
			Console.WriteLine("File.Exists: " + File.Exists(s));
			Console.WriteLine("FileInfo   : " + new FileInfo(s).Exists);
			Console.WriteLine("FileInfo   : " + (new FileInfo(s)).Exists);

			FileInfo fi = new FileInfo(s);
			fi.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
		}

		private void OnePath(string src) {
			Console.WriteLine($"-- Source : [{src}]");
			string path = Path.GetDirectoryName(src);
			string name = Path.GetFileNameWithoutExtension(src);
			string extn = Path.GetExtension(src);
			Console.WriteLine($"Directory : [{path}]");
			Console.WriteLine($"Filename  : [{name}]");
			Console.WriteLine($"Extension : [{extn}]");
		}

		public void Paths() {
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			this.OnePath(@"d:\aaa\bbb\cccc.ext");
		}
	}
}

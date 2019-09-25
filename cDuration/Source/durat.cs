using System;
using System.IO;

using Shell32;

namespace cDuration {

	public class Duration {

		public Duration() {
		}

		public void byShell(string path) {

			Console.WriteLine("====== byShell ======");

			Folder folder = (new Shell()).NameSpace(path);

			Console.WriteLine(path);
			Console.WriteLine("Items [" + folder.Items().Count + "]");

			foreach(FolderItem2 item in folder.Items())
				Console.WriteLine("  " + item.Application + ",  " + item.Path);

			Console.WriteLine("------ byShell ------");
		}

		public void byDirectX(string path) {
			Console.WriteLine("====== byDirectX ======");
			this.getdir(path);
			Console.WriteLine("------ byDirectX ------");
		}

		private void getdir(string path) {
			DirectoryInfo di = new DirectoryInfo(path);

			FileInfo fi;

			Console.WriteLine("file (" + Directory.GetFiles(path).Length + ")");
			foreach(string f in Directory.GetFiles(path)) {
				fi = new FileInfo(f);
				Console.WriteLine("  " + fi.FullName);
				if(Path.GetExtension(fi.Name).ToUpper() == ".MOV")
					this.byDirect(fi.FullName);
			}

			foreach(string d in Directory.GetDirectories(path)) {
				Console.WriteLine("- " + d);
				this.getdir(d);
			}
		}

		private void byDirect(string path) {

			try {
				Microsoft.DirectX.AudioVideoPlayback.Video v =
					new Microsoft.DirectX.AudioVideoPlayback.Video(path);

				double du = v.Duration;
				Console.WriteLine(path + "  " + du);
			}
			catch(Exception e) {
				Console.WriteLine("*** " + e.Message);
				Console.WriteLine("    " + e.StackTrace);
			}
		}
	}

	class Program {
		static void Main(string[] args) {

			//string path = @"C:\test\temp\config";
			string path = @"D:\dataD\dataOrig\orgMov\01-orgAvc1";

			Duration d = new Duration();

			d.byShell(path);

			//Console.WriteLine();
			//d.byDirectX(path);
		}
	}
}

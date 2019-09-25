using System;
using System.IO;

namespace MergeSrc1 {

	public class MergeSrc01 {
		public MergeSrc01() {
		}

		private void dsp(string fname) {
			StreamReader sr;
			Console.Write("  <" + fname + "> ");
			try {
				sr = new StreamReader(fname);
				Console.WriteLine("read [" + sr.ReadLine() + "]");
				sr.Close();
			}
			catch(Exception e) {
				Console.WriteLine("error [" + e.Message + "]");
			}
		}

		public void dsp01(string message) {
			Console.WriteLine("--- src01 [" + message + "]");

			string path = Directory.GetCurrentDirectory();
			Console.WriteLine("  work dir [" + path + "]");

			string path1 = "Local.dat", path2 = "Localsub.dat";
			this.dsp(path1);
			this.dsp(path2);

			path += @"\changed";
			Directory.SetCurrentDirectory(path);
			Console.WriteLine("  work dir [" + path + "]");
			this.dsp(path1);
			this.dsp(path2);
		}
	}
}

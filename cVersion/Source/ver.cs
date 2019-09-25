using System;

namespace cVersion {
	public class Ver {

		public Ver() {
		}

		public void CVersion() {
			System.Reflection.AssemblyName ass =
				System.Reflection.Assembly.GetEntryAssembly().GetName();
			Console.WriteLine("Assembly Version [" + ass.Version + "]");

			System.Diagnostics.FileVersionInfo info =
				System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location);
			Console.WriteLine("File     Version [" + info.FileVersion + "]");
		}
	}

	class Program {
		static void Main(string[] args) {
			Ver v = new Ver();
			v.CVersion();
		}
	}
}

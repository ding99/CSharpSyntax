using System;

namespace tempName {
	class Program {
		static void Main(string[] args) {

			Console.WriteLine("== Start");

			try {
				Console.WriteLine("TempFileName is below");
				Console.WriteLine(System.IO.Path.GetTempFileName());
			}
			catch(Exception e) {
				Console.WriteLine(e.Message + Environment.NewLine + e.StackTrace);
			}

			Console.WriteLine("== End");
		}
	}
}

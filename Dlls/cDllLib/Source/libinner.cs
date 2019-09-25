using System;

namespace cDllLib {
	public class LibDsp : cDllInterface.IFormat {
		public LibDsp() {
		}

		public void dspline(string message) {
			Console.WriteLine("*** Library [" + message + "] ***");
		}
	}
}

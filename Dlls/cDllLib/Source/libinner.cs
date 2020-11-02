using System;

namespace CDllLib {
	public class LibDsp : CDllInterface.IFormat {
		public void dspline(string message) {
			Console.WriteLine("*** Library [" + message + "] ***");
		}
	}
}

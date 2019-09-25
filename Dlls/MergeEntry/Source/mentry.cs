using System;

namespace MergeEntry {
	class Loader {
		static void Main(string[] args) {

			// (1.Original) Reference NergeSrc2.dll
			// (2.Mergered) Reference NergeSrc.dll

			string message = "TopMessage";
			Console.WriteLine("=== start [" + message + "]");
			(new MergeSrc2.MergeScr02()).dsp02(message);
			Console.WriteLine("=== end");

		}
	}
}

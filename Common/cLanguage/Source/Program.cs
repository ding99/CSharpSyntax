using System;

namespace cLanguage
{
	class Entrance {

		static void Main(string[] args) {

			Console.WriteLine("=== start");
			TLanguage tl = new TLanguage();

			tl.whatlang();
			tl.codepage();
			tl.encoding();
			tl.int2char();
			tl.segs();

			Console.WriteLine();
			Console.WriteLine("=== end");

		}

	}
}

using System;

namespace cFile
{
	class Entrance {
		static void Main() {
			Console.WriteLine("== Start");

			Files f = new Files();

			f.filecopy();
			f.names();
			f.finfo();

			Console.ResetColor();
			Console.WriteLine("== End");
		}
	}
}

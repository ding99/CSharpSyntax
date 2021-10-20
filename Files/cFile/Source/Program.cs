using System;

namespace cFile
{
	class Entrance {
		static void Main() {
			Console.WriteLine("== Start");

			Files f = new Files();

			f.Filecocpy();
			f.Nasmes();
			f.FInfo();
			f.Paths();

			Console.ResetColor();
			Console.WriteLine("== End");
		}
	}
}

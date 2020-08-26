using System;

namespace cArray
{
	class Entrance
	{
		static void Main()
		{
			Console.WriteLine("== start");

			CheckArray ca = new CheckArray();
			ca.Partial();
			ca.toString();
			ca.replaceBin();
			Console.WriteLine();

			new Assign().Assigning();

			Console.ResetColor();
			Console.WriteLine("== end");
		}
	}
}

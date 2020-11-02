using System;

namespace CArray
{
	class Entrance
	{
		static void Main()
		{
			Console.WriteLine("== start");

			CheckArray ca = new CheckArray();
			ca.Partial();
			ca.DspString();
			ca.ReplaceBin();
			Console.WriteLine();

			new Assign().Assigning();

			Console.ResetColor();
			Console.WriteLine("== end");
		}
	}
}

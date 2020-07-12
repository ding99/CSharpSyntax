using System;

namespace cArray
{
	class Entrance
	{
		static void Main(string[] args)
		{

			Console.WriteLine("== start");

			GArray ga = new GArray();
			bool ret = true;

			ret = ga.Partial();
			ret = ga.toString();
			ret = ga.replaceBin();

			Console.WriteLine(Environment.NewLine + ret + Environment.NewLine + "== end");
		}
	}
}

using System;

namespace cPath
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("== strat");

			TPath tp = new TPath();
			tp.createFile(args, "\\test");
			tp.currentdir();
			tp.temppath();
			tp.separators();

			Console.WriteLine("== end");
		}
	}
}

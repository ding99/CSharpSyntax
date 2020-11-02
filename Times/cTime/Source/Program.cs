using System;

namespace CTime
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("== Start");
			ChkTime ct = new ChkTime();

			Console.ForegroundColor = ConsoleColor.Yellow;
			ct.estimate();
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			ct.testRound();
			Console.ForegroundColor = ConsoleColor.Cyan;
			ct.testTF();
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			ct.seeRound();
			Console.ForegroundColor = ConsoleColor.Yellow;
			ct.cal();
			Console.ForegroundColor = ConsoleColor.Red;
			ct.tspan();
			Console.ForegroundColor = ConsoleColor.Yellow;
			ct.dspyear();
			Console.ForegroundColor = ConsoleColor.Blue;
			ct.rere();
			Console.ForegroundColor = ConsoleColor.Yellow;
			ct.sub();

			Console.ForegroundColor = ConsoleColor.Green;
			ct.getratios();
			ct.dspDate();

			Console.ResetColor();
			Console.WriteLine("== End");
		}
	}
}

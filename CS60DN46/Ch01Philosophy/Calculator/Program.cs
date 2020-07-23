using System;

//csc .\Program.cs .\Calc.cs /out:new.exe

namespace Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			Calc c = new Calc();
			int a = 10, b = 84;

			Console.WriteLine("{0} + {1} is {2}.", a, b, c.Add(a, b));

			Console.ReadLine();
		}
	}
}

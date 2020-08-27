using System;

namespace SimpleDelegate
{
	public delegate int BinaryOp(int x, int y);

	public class SimpleMath
	{
		public static int Add(int x, int y) { return x + y; }
		public static int Subtract(int x, int y) { return x - y; }
	}

	class Program
	{
		static void Main()
		{
			Console.WriteLine("***** Simple Delegate Example *****");
			SimpleDegegate();
			Console.ResetColor();
		}

		static void SimpleDegegate()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> First simple example");

			BinaryOp b = new BinaryOp(SimpleMath.Add);
			Console.WriteLine($"10 + 10 is {b(10,10)}");
		}
	}
}

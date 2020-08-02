using System;

namespace TypeConversions
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Fun with type conversions *****");

			NoError();
			NarrowingAttempt();
			ExplicitCast();

			Console.ResetColor();
		}

		private static void ExplicitCast()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Explicit Casting with Lossing Data");
			short n1 = 30000, n2 = 30000;
			short answer = (short)Add(n1, n2);
			Console.WriteLine($"{n1} + {n2} = {answer}");
		}

		private static void NarrowingAttempt()
		{
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("=> Narrowing Attempt");
			byte myByte = 0;
			int myInt = 200;
			myByte = (byte)myInt;
			Console.WriteLine("Value of myByte: {0}", myByte);
		}

		private static void NoError()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("=> No Error");
			short num1 = 9, num2 = 10;
			Console.WriteLine("{0} + {1} = {2}", num1, num2, Add(num1, num2));
		}

		static int Add(int x, int y) { return x + y; }
	}
}

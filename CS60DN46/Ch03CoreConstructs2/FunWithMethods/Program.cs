using System;

namespace FunWithMethods
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Fun with Methods *****");

			Operation1();
			Swaping();

			Console.ResetColor();
		}

		static void Swaping()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=> Swap Strings");

			string s1 = "Flip", s2 = "Flop";
			Console.WriteLine("Before: {0}, {1}", s1, s2);
			SwapStrings(ref s1, ref s2);
			Console.WriteLine("Before: {0}, {1}", s1, s2);
		}

		static void SwapStrings(ref string s1, ref string s2)
		{
			string temp = s1;
			s1 = s2;
			s2 = temp;
		}

		static void Operation1()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("=> Addition");

			int x = 9, y = 10;
			Console.WriteLine("Before call: X {0}, Y {1}", x, y);
			Console.WriteLine("Answer is {0}", Add(x, y));
			Console.WriteLine("After call: X {0}, Y {1}", x, y);

		}

		static int Add(int x, int y)
		{
			int ans = x + y;
			x = 10000;
			y = 88888;
			return ans;
		}
	}
}

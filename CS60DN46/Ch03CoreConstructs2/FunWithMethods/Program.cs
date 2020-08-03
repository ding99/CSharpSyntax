using System;
using System.Data.OleDb;

namespace FunWithMethods
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Fun with Methods *****");

			Adding();
			Swaping();
			Summing();
			Naming();

			Console.ResetColor();
		}

		static void Naming()
		{
			DisplayFancyMessage(message: "Wow! Very Fancy indeed!", text: ConsoleColor.DarkRed, back: ConsoleColor.White);
			DisplayFancyMessage(back: ConsoleColor.Green, message: "Testing...", text: ConsoleColor.DarkBlue);
		}

		static void DisplayFancyMessage(ConsoleColor text, ConsoleColor back, string message)
		{
			ConsoleColor oldText = Console.ForegroundColor;
			ConsoleColor oldBack = Console.BackgroundColor;

			Console.ForegroundColor = text;
			Console.BackgroundColor = back;
			Console.WriteLine(message);

			Console.ForegroundColor = oldText;
			Console.BackgroundColor = oldBack;
		}

		static void Summing()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Params");
			double average;
			average = CalculateAverage(4.0, 3.2, 5.7, 64.22, 87.2);
			Console.WriteLine("Average of datga is: {0}", average);

			double[] data = { 4.0, 3.2, 5.7 };
			average = CalculateAverage(data);
			Console.WriteLine("Average of datga is: {0}", average);

			Console.WriteLine("Average of data is: {0}", CalculateAverage());
			Console.WriteLine();
		}

		static double CalculateAverage(params double[] values)
		{
			Console.WriteLine("You send me {0} doubles.", values.Length);
			double sum = 0;
			if (values.Length == 0)
				return sum;
			for (int i = 0; i < values.Length; i++)
				sum += values[i];
			return sum / values.Length;
		}

		static void Swaping()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=> Swap Strings");

			string s1 = "Flip", s2 = "Flop";
			Console.WriteLine("Before: {0}, {1}", s1, s2);
			SwapStrings(ref s1, ref s2);
			Console.WriteLine("Before: {0}, {1}", s1, s2);
			Console.WriteLine();
		}

		static void SwapStrings(ref string s1, ref string s2)
		{
			string temp = s1;
			s1 = s2;
			s2 = temp;
		}

		static void Adding()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("=> Addition");

			int x = 9, y = 10;
			Console.WriteLine("Before call: X {0}, Y {1}", x, y);
			Console.WriteLine("Answer is {0}", Add(x, y));
			Console.WriteLine("After call: X {0}, Y {1}", x, y);
			Console.WriteLine();
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

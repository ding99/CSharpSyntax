using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleIO
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Basic Console I/O *****");
			GetUserData();
			FormatNumericalData();
		}

		private static void FormatNumericalData()
		{
			Console.ForegroundColor = ConsoleColor.Blue;

			Console.WriteLine("The vaule 99999in various formates:");
			Console.WriteLine("c format: {0:c}", 99999);
			Console.WriteLine("d9 format: {0:d9}", 99999);
			Console.WriteLine("f3 format: {0:f3}", 99999);
			Console.WriteLine("n format: {0:n}", 99999);

			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("-- Notice that upper- or lowercasing for hex determines if letters are upper- or lowercase.");
			Console.WriteLine("E format: {0:E}", 99999);
			Console.WriteLine("e format: {0:e}", 99999);
			Console.WriteLine("X format: {0:X}", 99999);
			Console.WriteLine("x format: {0:x}", 99999);

			Console.ForegroundColor = ConsoleColor.Green;
			string userMessage = string.Format("10000 in hex is {0:x}", 100000);
			Console.WriteLine(userMessage);

			Console.ResetColor();
		}

		private static void GetUserData()
		{
			Console.Write("Please enter your name: ");
			string userName = Console.ReadLine();
			Console.Write("Please enter your age: ");
			string userAge = Console.ReadLine();

			ConsoleColor prevColor = Console.ForegroundColor;
			Console.ForegroundColor = ConsoleColor.Yellow;

			Console.WriteLine("Hello {0}! You are {1} years old ({1:D}).", userName, userAge);
			Console.WriteLine("Hello {0}! You are {1:D3} years old ({1:c}, {1:n}).",
				userName, int.Parse(userAge));

			Console.ForegroundColor = prevColor;
		}
	}
}

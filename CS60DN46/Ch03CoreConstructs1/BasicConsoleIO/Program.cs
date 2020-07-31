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
		}

		private static void GetUserData()
		{
			Console.ForegroundColor = ConsoleColor.Blue;

			Console.Write("Please enter your name: ");
			string userName = Console.ReadLine();
			Console.Write("Please enter your age: ");
			string userAge = Console.ReadLine();

			ConsoleColor prevColor = Console.ForegroundColor;
			Console.ForegroundColor = ConsoleColor.Yellow;

			Console.WriteLine("Hello {0}! You are {1} years old.", userName, userAge);

			Console.ForegroundColor = prevColor;
			Console.ResetColor();
		}
	}
}

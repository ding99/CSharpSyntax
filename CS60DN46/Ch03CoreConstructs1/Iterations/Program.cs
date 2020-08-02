using System;

namespace Iterations
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Iteration *****");
			DoWhileLoop();
			Console.ResetColor();
		}

		static void DoWhileLoop()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			string userIsDone = "";
			do
			{
				Console.WriteLine("In do/while loop");
				Console.Write("Are you done? [yes] [no]: ");
				userIsDone = Console.ReadLine();
			} while (userIsDone.ToLower() != "yes");
		}
	}
}

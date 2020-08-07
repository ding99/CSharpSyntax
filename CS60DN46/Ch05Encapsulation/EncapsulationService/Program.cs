using System;

namespace EncapsulationService
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Encapsulotion Services *****");
			Reading();
			Console.ResetColor();
		}

		static void Reading()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Book miniNovel = new Book();
			miniNovel.numberOfPages = 30000000; //not verify the number
		}
	}
}

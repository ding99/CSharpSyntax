using System;

namespace cArray
{
	class Assign
	{
		public void Assigning()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Assign");

			int[] array1 = new int[] { 1, 2, 3, 4, 5};
			foreach (var a in array1)
				Console.Write($"{a} ");
			Console.WriteLine();

			int[] array2 = { 10, 20, 30, 40, 50 };
			foreach (var a in array2)
				Console.Write($"{a} ");
			Console.WriteLine();

			int[] array3 = new int[5] { 11,12,13,14,15};
			foreach (var a in array3)
				Console.Write($"{a} ");
			Console.WriteLine();
		}
	}
}

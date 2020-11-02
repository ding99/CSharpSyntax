using System;

namespace CArray
{
	class Assign
	{
		public void Assigning()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Assign");

			int[] array1 = new int[] { 11, 12, 13, 14, 15 };
			foreach (var a in array1)
				Console.Write($"{a} ");
			Console.WriteLine();

			int[] array2 = { 21, 22, 23, 24, 25 };
			foreach (var a in array2)
				Console.Write($"{a} ");
			Console.WriteLine();

			int[] array3 = new int[5] { 31, 32, 33, 34, 35 };
			foreach (var a in array3)
				Console.Write($"{a} ");
			Console.WriteLine();

			int[] array5;
			array5 = new int[] { 51, 52, 53, 54, 55 }; //must use 'new'
			foreach (var a in array5)
				Console.Write($"{a} ");
			Console.WriteLine();
		}
	}
}

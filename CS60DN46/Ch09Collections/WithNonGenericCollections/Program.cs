using System;
using System.Collections;

namespace WithNonGenericCollections
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("***** Non-Generic Collection *****");
			ArrayList();
			BoxUnbox();
			Console.ResetColor();
		}

		static void BoxUnbox()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Simple Box Unbox Operation");

			int myInt = 25, unboxedInt = 0;
			long myLong = 35, unboxedLong1 = 0, unboxedLong2 = 0;
			//Box the int into an object reference
			object boxedInt = myInt;
			object boxedLong = myLong;

			Console.WriteLine("-> Before Unboxing");
			Console.WriteLine($"unboxedInt: {unboxedInt}; unboxedLong1: {unboxedLong1}; unboxedLong2: {unboxedLong2}");

			//Unbox the reference back into a corresponding int.
			unboxedInt = (int)boxedInt;
			if (boxedInt.GetType() == typeof(long))
				unboxedLong1 = (long)boxedInt;
			if (boxedLong.GetType() == typeof(long))
				unboxedLong2 = (long)boxedLong;
			//avoid InvalidCastException

			Console.WriteLine("-> After Unboxing");
			Console.WriteLine($"unboxedInt: {unboxedInt}; unboxedLong1: {unboxedLong1}; unboxedLong2: {unboxedLong2}");
		}

		static void ArrayList()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("=> ArrayList");

			ArrayList strArray = new ArrayList();
			strArray.AddRange(new string[] {"First","Second","Third"});
			Console.WriteLine($"This colllection has {strArray.Count} items");

			strArray.Add("Fourth!");
			Console.WriteLine($"This colllection has {strArray.Count} items");
			foreach (string s in strArray)
				Console.Write($"Entry: {s}, ");
			Console.WriteLine();

		}
	}
}

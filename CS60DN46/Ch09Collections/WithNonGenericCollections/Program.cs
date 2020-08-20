using System;
using System.Collections;
using System.Runtime.CompilerServices;

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

			int myInt = 25;
			//Box the int into an object reference
			object boxedInt = myInt;
			//Unbox the reference back into a corresponding int.
			int unboxedInt = (int)boxedInt;

			long myLong = 35;
			object boxedLong = myLong;

			long unboxedLong1 = 0, unboxedLong2 = 0;
			try
			{
				if (boxedInt.GetType() == typeof(long))
					unboxedLong1 = (long)boxedInt;
				if (boxedLong.GetType() == typeof(long))
					unboxedLong2 = (long)boxedLong;
			}
			catch (InvalidCastException e)
			{
				Console.WriteLine($"Invalid Cast exception: {e.Message}");
			}

			Console.WriteLine($"unboxedLong1: {unboxedLong1}; unboxedLong2: {unboxedLong2}");
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

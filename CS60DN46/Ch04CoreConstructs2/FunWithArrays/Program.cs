using System;

namespace FunWithArrays
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Fun with Arrays *****");
			
			SimpleArrays();
			DeclareImplicitArrays();
			ArrayOfObjects();
			RectMultidimensionalArray();
			JaggedMultidimensionalArray();
			SystemArrayFunctionality();

			Console.ResetColor();
		}

		static void SystemArrayFunctionality()
		{
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine("=> Working with System.Array.");
			string[] gothicBands = { "Tones on Tail", "Bauhaus", "Sisters of Mercy" };
			Console.Write("-> Here is the array:");
			for (int i = 0; i < gothicBands.Length; i++) Console.Write($" {gothicBands[i]},");
			Console.WriteLine();
			Console.Write("-> Cleared out all but one...");
			Array.Clear(gothicBands, 1, 2);
			for (int i = 0; i < gothicBands.Length; i++) Console.Write($" {gothicBands[i]}, ");
			Console.WriteLine();

			double[] ds = { 2.2, 1.1, 3.3 };
			Console.Write("Before Clear:"); foreach (var d in ds) Console.Write($" {d},"); Console.WriteLine();
			double[] d2 = new double[3]; ds.CopyTo(d2, 0);
			Console.Write("Copied:"); foreach (var d in d2) Console.Write($" {d},"); Console.WriteLine();
			Array.Reverse(ds);
			Console.Write("Reverted:"); foreach (var d in ds) Console.Write($" {d},"); Console.WriteLine();
			Array.Sort(ds);
			Console.Write("Sorted:"); foreach (var d in ds) Console.Write($" {d},"); Console.WriteLine();
			Array.Clear(ds, 0, ds.Length);
			Console.Write("After Clear:"); foreach (var d in ds) Console.Write($" {d},"); Console.WriteLine();
		}

		static void JaggedMultidimensionalArray()
		{
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("=> Jagged multidimensional array.");
			int[][] myJagArray = new int[5][];
			for (int i = 0; i < myJagArray.Length; i++) myJagArray[i] = new int[i + 7];
			for(int i = 0; i < 5; i++)
			{
				for (int j = 0; j < myJagArray[i].Length; j++) Console.Write($" {myJagArray[i][j]}");
				Console.WriteLine();
			}
			Console.WriteLine();
		}

		static void RectMultidimensionalArray()
		{
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("=> Rectangular multidimensional array.");
			int[,] myMatrix;
			myMatrix = new int[3, 4];
			for (int i = 0; i < 3; i++) for (int j = 0; j < 4; j++) myMatrix[i, j] = i * j;
			for(int i = 0; i < 3; i++) {
				for(int j = 0; j < 4; j++)
					Console.Write(myMatrix[i, j] + "\t");
				Console.WriteLine();
			}
			Console.WriteLine();
		}
		static void ArrayOfObjects()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			object[] myObjects = new object[4];
			myObjects[0] = 10;
			myObjects[1] = false;
			myObjects[2] = new DateTime(1969, 3, 24);
			myObjects[3] = "Form & Void";
			foreach(object o in myObjects)
				Console.WriteLine($"Type {o.GetType()}, Value {o}");
			Console.WriteLine();
		}

		static void DeclareImplicitArrays()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Implicit Array Initializatoin.");
			var a = new[] { 1, 10, 100, 1000 }; Console.WriteLine("a is a: {0} with size {1}", a.ToString(), a.Length);
			var b = new[] { 1, 1.5, 2, 2.5 }; Console.WriteLine("b is a: {0}", b.ToString());
			var c = new[] { "hello", null, "world" }; Console.WriteLine("c is a: {0}",c.ToString());
			Console.WriteLine();
		}

		static void SimpleArrays()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("=> Simple Array Creation.");
			int[] myInts = new int[3];
			myInts[0] = 100; myInts[1] = 200; myInts[2] = 300;
			foreach (int i in myInts) Console.Write(" {0}", i);
			Console.WriteLine();

			string[] stringArray = new string[] { "one", "two", "three" };
			Console.Write("stringArray has {0} elements:", stringArray.Length);
			foreach (var i in stringArray) Console.Write($" {i}");
			Console.WriteLine();

			bool[] boolArray = { false, false, true };
			Console.Write("boolArray has {0} elements:", boolArray.Length);
			foreach (var i in boolArray) Console.Write($" {i}");
			Console.WriteLine();

			int[] intArray = new int[] { 20, 222, 23, 0 };
			Console.Write("intArray has {0} elements:", intArray.Length);
			foreach (var i in intArray) Console.Write($" {i}");
			Console.WriteLine();

			Console.WriteLine();
		}
	}
}

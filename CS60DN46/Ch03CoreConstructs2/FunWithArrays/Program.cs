using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FunWithArrays
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Fun with Arrays *****");
			SimpleArrays();

			Console.ResetColor();
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

			int[] intArray = new int[4] { 20, 222, 23, 0 };
			Console.Write("intArray has {0} elements:", intArray.Length);
			foreach (var i in intArray) Console.Write($" {i}");
			Console.WriteLine();

			Console.WriteLine();
		}
	}
}

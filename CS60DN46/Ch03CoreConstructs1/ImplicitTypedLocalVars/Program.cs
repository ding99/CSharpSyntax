using System;
using System.Linq;

namespace ImplicitTypedLocalVars
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Fun with Implicit Typing *****");

			DeclareImplicitVars();
			LinqQueryOverInts();

			Console.ResetColor();
		}

		static void LinqQueryOverInts()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
			var subset = from i in numbers where i < 10 select i;
			Console.Write("Values in subset:");
			foreach (var i in subset) Console.Write(" {0}", i);
			Console.WriteLine();

			Console.WriteLine("subset is a: {0}", subset.GetType().Name);
			Console.WriteLine("subset is defiend in: {0}", subset.GetType().Namespace);
		}

		private static void DeclareImplicitVars()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			var myInt = 0;
			var myBool = true;
			var myString = "Time, marches on...";

			Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
			Console.WriteLine("myBool is a: {0}", myBool.GetType().Name);
			Console.WriteLine("myString is a: {0}", myString.GetType().Name);
		}
	}
}

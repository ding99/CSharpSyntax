using System;

namespace ImplicitTypedLocalVars
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Fun with Implicit Typing *****");

			DeclareImplicitVars();

			Console.ResetColor();
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

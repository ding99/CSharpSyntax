using System;

namespace ConstData
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("***** Const Data *****");
			PIValue();
			Console.ResetColor();
		}

		static void PIValue()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"The value of PI is: {MyMath.PI}");
			Console.WriteLine($"The value of PI3 is: {MyMath.PI3}");

			const string fixedStr = "Fixed string in a static method";
			try
			{
				Console.WriteLine(fixedStr);
				MyMath math = new MyMath();
				math.Test();
				Console.WriteLine($"The value of PI2 is: {math.PI2}");
			}
			catch (Exception e)
			{
				Console.WriteLine($"Error: {e.Message}");
			}
		}
	}
}

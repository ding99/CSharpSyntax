using System;

namespace ConstData
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Const Data *****");
			PIValue();
			Console.ResetColor();
		}

		static void PIValue()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"The value of PI is: {MyMath.PI}");
		}
	}
}

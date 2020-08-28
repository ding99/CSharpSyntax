using System;

namespace GenericDelegate
{
	class Program
	{
		public delegate void MyGenericDelegate<T>(T arg);

		static void Main()
		{
			Console.WriteLine("***** Understanding Generic Delegates *****");
			GenericDeleg();
			Console.ResetColor();
		}

		static void GenericDeleg()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=> Generic Delegates");

			MyGenericDelegate<string> strTarget = new MyGenericDelegate<string>(StringTarget);
			strTarget("Some string data");

			MyGenericDelegate<int> intTarget = new MyGenericDelegate<int>(IntTarget);
			intTarget(9);
		}

		static void StringTarget(string arg)
		{
			Console.WriteLine($"=> arg in uppercase is: {arg.ToUpper()}");
		}
		static void IntTarget(int arg)
		{
			Console.WriteLine($"++arg is: {++arg}");
		}
	}
}

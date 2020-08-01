using System;
using System.Numerics;

namespace BasicDadaTypes
{
	class Program
	{
		static void Main(string[] args)
		{
			LocalVarDeclarations();
			NewingDataType();
			ObjectFunctionality();
		}

		static void ObjectFunctionality()
		{
			Console.ForegroundColor = ConsoleColor.Blue;

			Console.WriteLine("=> System.Object Functionality:");
			Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
			Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
			Console.WriteLine("12.ToString() = {0}", 12.ToString());
			Console.WriteLine("12.GetType() = {0}", 12.GetType());
			Console.WriteLine();

			Console.ResetColor();
		}

		static void NewingDataType()
		{
			Console.ForegroundColor = ConsoleColor.Green;

			Console.WriteLine("=> Using new to create variables:");
			bool b = new bool();
			int i = new int();
			double d = new double();
			DateTime dt = new DateTime();
			BigInteger bi = new BigInteger();
			Console.WriteLine("{0}, {1}, {2}, {3}, {4}", b,i,d,dt, bi);
			Console.WriteLine();

			Console.ResetColor();
		}

		static void LocalVarDeclarations()
		{
			Console.WriteLine("=> Data Declaration:");

			int myInt = 5;
			string myString;
			myString = "This is my character data";
			bool b1 = true, b2 = false, b3 = b1;
			Boolean b4 = false;

			Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5}",
				myInt, myString, b1, b2, b3, b4);

			Console.WriteLine();
		}
	}
}

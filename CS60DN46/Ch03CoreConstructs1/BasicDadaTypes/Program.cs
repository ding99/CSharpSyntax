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
			DataTypeFunctionality();
			CharFunctionality();
			ParseFromStrings();
		}

		static void ParseFromStrings()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;

			Console.WriteLine("=> Data type parsing:");
			bool b = bool.Parse("True");
			Console.WriteLine("Value of b: {0}", b);
			double d = double.Parse("99.884");
			Console.WriteLine("Value of d: {0}", d);
			double i = int.Parse("8");
			Console.WriteLine("Value of i: {0}", i);
			char c = Char.Parse("w");
			Console.WriteLine("Value of c: {0}", c);
			Console.WriteLine();

			Console.ResetColor();
		}

		static void CharFunctionality()
		{
			Console.ForegroundColor = ConsoleColor.Red;

			Console.WriteLine("=> char type functionality:");
			char myChar = 'a';
			Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
			Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
			Console.WriteLine("char.IsWhiteSpace('Hello There', 5): {0}", char.IsWhiteSpace("Hello There", 5));
			Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}", char.IsWhiteSpace("Hello There", 6));
			Console.WriteLine("char.IsPunctuation('?'): {0}", char.IsPunctuation('?'));
			Console.WriteLine();

			Console.ResetColor();
		}

		static void DataTypeFunctionality()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;

			Console.WriteLine("=> Data type Functionality:");
			Console.WriteLine("Max of int: {0}", int.MaxValue);
			Console.WriteLine("Min of int: {0}", int.MinValue);
			Console.WriteLine("Max of double: {0}", double.MaxValue);
			Console.WriteLine("Min of double: {0}", double.MinValue);
			Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
			Console.WriteLine("double.PositiveInfinity: {0}", double.PositiveInfinity);
			Console.WriteLine("double.NegativeInfinity: {0}", double.NegativeInfinity);

			Console.WriteLine("bool.FalseString: {0}", bool.FalseString);
			Console.WriteLine("bool.TrueString: {0}", bool.TrueString);
			Console.WriteLine();

			Console.ResetColor();
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

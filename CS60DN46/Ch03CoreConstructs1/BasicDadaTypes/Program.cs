﻿using System;

namespace BasicDadaTypes
{
	class Program
	{
		static void Main(string[] args)
		{
			LocalVarDeclarations();
		}

		static void LocalVarDeclarations()
		{
			Console.WriteLine("=> Data Declaration:");

			int myInt = 5;
			string myString;
			myString = "This is my character data";
			bool b1 = true, b2 = false, b3 = b1;
			System.Boolean b4 = false;

			Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5}",
				myInt, myString, b1, b2, b3, b4);

			Console.WriteLine();
		}
	}
}

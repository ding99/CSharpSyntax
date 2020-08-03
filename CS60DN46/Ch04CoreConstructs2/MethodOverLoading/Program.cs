﻿using System;

namespace MethodOverLoading
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("***** Fun with Method Overloading *****");
			Console.WriteLine(Add(10, 10));
			Console.WriteLine(Add(900000000000, 900000000000));
			Console.WriteLine(Add(4.3, 4.3));
		}

		static int Add(int x, int y) { return x = y; }
		static double Add(double x, double y) { return x + y; }
		static long Add(long x, long y) { return x + y; }
	}
}

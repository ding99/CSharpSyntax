using System;

namespace CustomGenericMethods
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("***** Custom Generic Methods *****");
			GenericMethod();
			Console.ResetColor();
		}

		static void GenericMethod()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Custom generic method");

			int a = 10, b = 90;
			Console.WriteLine($"Before swap: {a}, {b}");
			Swap<int>(ref a, ref b);
			Console.WriteLine($"After  swap: {a}, {b}");

			double f1 = 3.15D, f2 = 8.8D;
			Console.WriteLine($"Before swap: {f1}, {f2}");
			Swap(ref f1, ref f2);
			Console.WriteLine($"After  swap: {f1}, {f2}");

			Person p1 = new Person { FirstName = "Steve", LastName = "Wang", Age = 55 };
			Person p2 = new Person { FirstName = "Mike", LastName = "Lee", Age = 37 };
			Console.WriteLine($"Before swap: <{p1}>, <{p2}>");
			Swap(ref p1, ref p2);
			Console.WriteLine($"After  swap: <{p1}>, <{p2}>");
		}

		static void Swap<T>(ref T a, ref T b)
		{
			Console.WriteLine($"You sent the Swap() method a {typeof(T)}");
			T temp = a;
			a = b;
			b = temp;
		}
	}
}

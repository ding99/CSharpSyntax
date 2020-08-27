using System;

namespace ConstrainingType
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("***** Constraining Type Parameters *****");
			DefaultCtor();
			Console.ResetColor();
		}

		static void DefaultCtor()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> default constructor");

			int a = 5, b = 7;
			Console.WriteLine($"Before swap: {a}, {b}");
			GenericClass<int> intg = new GenericClass<int>();
			intg.Swap(ref a, ref b);
			Console.WriteLine($"After  swap: {a}, {b}");
			//GenericClass<Person> person =  new GenericClass<Person>(); //compile error
		}
	}
}

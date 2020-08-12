using System;

namespace ObjectOverrides
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** System.Object *****");
			OrigMethods();
			Console.ResetColor();
		}

		static void OrigMethods()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("=> Original Methods");

			Person p1 = new Person("David","Audru", 35);
			Console.WriteLine($"ToString: {p1.ToString()}");
			Console.WriteLine($"ToString: {p1}");
			Console.WriteLine($"Hash Code: {p1.GetHashCode()}");
			Console.WriteLine($"Type: {p1.GetType()}");

			Person p2 = p1;
			object o = p2;
			if(o.Equals(p1) && p2.Equals(o))
				Console.WriteLine("Same instance!");
		}
	}
}

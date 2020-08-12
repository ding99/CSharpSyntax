using System;

namespace ObjectOverrides
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("***** System.Object *****");
			OrigMethods();
			CheckHash();
			ModifiedClass();
			StaticObject();
			Console.ResetColor();
		}

		static void StaticObject()
		{
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("=> Static Members");
			Person p3 = new Person("Sally", "Jones", 4);
			Person p4 = new Person("Sally", "Jones", 4);
			Console.WriteLine($"p3 and p4 have same state: {object.Equals(p3,p4)}");
			Console.WriteLine($"p3 and p4 are pointing to same object: {object.ReferenceEquals(p3, p4)}");
		}

		static void ModifiedClass()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=> Testing Modified Person Class");

			Person p1 = new Person("Homer", "Simpson", 50);
			Person p2 = new Person("Homer", "Simpson", 50);

			Console.WriteLine($"ToString: {p1.ToString()} / {p2.ToString()}");
			Console.WriteLine($"Equality: {p1.Equals(p2)}");
			Console.WriteLine($"HashCode: {p1.GetHashCode()} / {p2.GetHashCode()}");
			Console.WriteLine($"Same HashCode: {p1.GetHashCode() == p2.GetHashCode()}");

			p2.Age = 45;
			Console.WriteLine($"ToString: {p1.ToString()} / {p2.ToString()}");
			Console.WriteLine($"Equality: {p1.Equals(p2)}");
			Console.WriteLine($"HashCode: {p1.GetHashCode()} / {p2.GetHashCode()}");
			Console.WriteLine($"Same HashCode: {p1.GetHashCode() == p2.GetHashCode()}");
		}

		static void CheckHash()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			string s1 = "Hello2", s2 = "Hello2";
			Console.WriteLine($"HashCode: {s1.GetHashCode()}, {s2.GetHashCode()}");
			Console.WriteLine($"Equality: {s2.Equals(s2)}");
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

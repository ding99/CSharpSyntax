using System;
using System.Collections;

namespace WithNonGenericCollections
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("***** Non-Generic Collection *****");
			ArrayList();
			BoxUnbox();
			WorkWithArrayList();
			CustomCollection();
			Console.ResetColor();
		}

		static void CustomCollection()
		{
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("=> Custom People Collection");

			PersonCollection coll = new PersonCollection();
			coll.AddPerson(new Person("Homer", "Simpson", 40));
			coll.AddPerson(new Person("Marge", "Simpson", 38));
			coll.AddPerson(new Person("Lisa", "Simpson", 9));
			coll.AddPerson(new Person("Bart", "Simpson", 7));
			coll.AddPerson(new Person("Maggie", "Simpson", 2));

			foreach(Person p in coll)
				Console.WriteLine(p);

			Person sel = coll.GetPerson(2);
			Console.WriteLine($"Second Person {{sel}}");
		}

		static void WorkWithArrayList()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=> unbox to int");

			ArrayList ints = new ArrayList();
			ints.Add(10);
			ints.Add(20);
			ints.Add(35);

			foreach (int a in ints)
				Console.Write($" {a}");
			Console.WriteLine();

			int i = (int)ints[0]; // need to unbox
			Console.WriteLine($"unboxed i {i}");

		}

		static void BoxUnbox()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Simple Box Unbox Operation");

			int myInt = 25, unboxedInt = 0;
			long myLong = 35, unboxedLong1 = 0, unboxedLong2 = 0;
			//Box the int into an object reference
			object boxedInt = myInt;
			object boxedLong = myLong;

			Console.WriteLine("-> Before Unboxing");
			Console.WriteLine($"unboxedInt: {unboxedInt}; unboxedLong1: {unboxedLong1}; unboxedLong2: {unboxedLong2}");

			//Unbox the reference back into a corresponding int.
			unboxedInt = (int)boxedInt;
			if (boxedInt.GetType() == typeof(long))
				unboxedLong1 = (long)boxedInt;
			if (boxedLong.GetType() == typeof(long))
				unboxedLong2 = (long)boxedLong;
			//avoid InvalidCastException

			Console.WriteLine("-> After Unboxing");
			Console.WriteLine($"unboxedInt: {unboxedInt}; unboxedLong1: {unboxedLong1}; unboxedLong2: {unboxedLong2}");
		}

		static void ArrayList()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("=> ArrayList");

			ArrayList strArray = new ArrayList();
			strArray.AddRange(new string[] {"First","Second","Third"});
			Console.WriteLine($"This colllection has {strArray.Count} items");

			strArray.Add("Fourth!");
			Console.WriteLine($"This colllection has {strArray.Count} items");
			foreach (string s in strArray)
				Console.Write($"Entry: {s}, ");
			Console.WriteLine();

		}
	}
}

using System;
using System.Collections.Generic;

namespace WithGenericCollections
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("***** Generic Collection *****");
			GenericSorting();
			PracticeList();
			PracticeStack();
			PracticeQueue();
			PracticeSortedSet();
			PracticeDictionary();
			Console.ResetColor();
		}

		static void PracticeDictionary()
		{
			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.WriteLine("=> Working with Dictionary<T>");

			Dictionary<string, Person> people = new Dictionary<string, Person>
			{
				{ "Homer", new Person{FirstName = "Homer", LastName="Simpson", Age=47} },
				{"Marge", new Person{FirstName = "Marge", LastName="Simpson", Age=45} },
				{"Lisa",  new Person{FirstName = "Lisa", LastName="Simpson", Age=9} }
			};

			people.Add("Bart", new Person { FirstName = "Bart", LastName = "Simpson", Age = 8 });

			foreach(var p in people)
				Console.WriteLine($"[{p.Key}]: {p.Value}");

			Person lisa = people["Lisa"];
			Console.WriteLine($"lisa: {lisa}");
		}

		static void PracticeSortedSet()
		{
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine("=> Working with SortedSet<T>");

			SortedSet<Person> people = new SortedSet<Person>(new SortPeopleByAge())
			{
				new Person{FirstName = "Marge", LastName="Simpson", Age=45},
				new Person{FirstName = "Bart", LastName="Simpson", Age=8},
				new Person{FirstName = "Lisa", LastName="Simpson", Age=9},
				new Person{FirstName = "Homer", LastName="Simpson", Age=47}
			};

			foreach(var p in people)
				Console.WriteLine(p);

			Console.WriteLine("-> Added two people");
			people.Add(new Person { FirstName = "Saku", LastName = "Jones", Age = 1 });
			people.Add(new Person { FirstName = "Mikko", LastName = "Jones", Age = 32 });
			foreach (var p in people)
				Console.WriteLine(p);
		}

		static void PracticeQueue()
		{
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("=> Working with Queue<T>");

			Queue<Person> people = new Queue<Person>();
			people.Enqueue(new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 });
			people.Enqueue(new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 });
			people.Enqueue(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });

			Console.WriteLine($"<{people.Peek().FirstName}> is first in line!");
			GetCoffee(people.Dequeue());
			GetCoffee(people.Dequeue());
			GetCoffee(people.Dequeue());

			try
			{
				GetCoffee(people.Dequeue());
			}
			catch (InvalidOperationException e)
			{
				Console.WriteLine($"Error! {e.Message}");
			}
		}

		static void GetCoffee(Person p)
		{
			Console.WriteLine($"{p.FirstName} got coffee!");
		}

		static void PracticeStack()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=> Working with Stack<T>");

			Stack<Person> people = new Stack<Person>();

			people.Push(new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 });
			people.Push(new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 });
			people.Push(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });

			Console.WriteLine($"First person: <{people.Peek()}>");
			Console.WriteLine($"   Popped of: <{people.Pop()}>");
			Console.WriteLine($"First person: <{people.Peek()}>");
			Console.WriteLine($"   Popped of: <{people.Pop()}>");
			Console.WriteLine($"First person: <{people.Peek()}>");
			Console.WriteLine($"   Popped of: <{people.Pop()}>");

			try
			{
				Console.WriteLine($"First person: <{people.Peek()}>");
				Console.WriteLine($"   Popped of: <{people.Pop()}>");
			}
			catch (InvalidOperationException e)
			{
				Console.WriteLine($"Error! {e.Message}");
			}
		}

		static void PracticeList()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Working with List<T>");

			List<Person> people = new List<Person>
			{
				new Person{FirstName = "Homer", LastName="Simpson", Age=47},
				new Person{FirstName = "Marge", LastName="Simpson", Age=45},
				new Person{FirstName = "Lisa", LastName="Simpson", Age=9},
				new Person{FirstName = "Bart", LastName="Simpson", Age=8}
			};

			Console.WriteLine($"Items in list: {people.Count}");
			Console.WriteLine("Inserting new person.");
			people.Insert(2, new Person { FirstName = "Maggie", LastName = "Simpson", Age = 2 });
			Console.WriteLine($"Items in list: {people.Count}");

			Person[] arrayOfPeople = people.ToArray();
			for(int i = 0; i < arrayOfPeople.Length; i++)
				Console.WriteLine($"First Name <{arrayOfPeople[i].FirstName}>");
		}

		static void GenericSorting()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("=> Object Sorting");

			Car[] cars = {
	 			new Car("Rusty", 80, 1),
				new Car("Mary", 70, 234),
				new Car("Viper", 60, 34),
				new Car("Mel", 50, 4),
				new Car("Chucky", 30, 5)
			};

			Console.WriteLine("Here is the unordered set of cars:");
			foreach (Car c in cars)
				Console.Write($" ({c.CarID},{c.PetName})");
			Console.WriteLine();

			Array.Sort(cars);
			Console.WriteLine("Here is the ordered set of cars:");
			foreach (Car c in cars)
				Console.Write($" ({c.CarID},{c.PetName})");
			Console.WriteLine();
		}
	}
}

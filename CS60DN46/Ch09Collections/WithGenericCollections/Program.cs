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
			InitList();
			InitStack();
			Console.ResetColor();
		}

		static void InitStack()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=> Stack<T> initialization");

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

		static void InitList()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> List<T> initialization");

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

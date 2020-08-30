using System;
using System.Collections.Generic;

namespace SimpleIndexer {
	class Program {
		static void Main() {
			Console.WriteLine("***** Indexer Methods *****");
			SimpleIndexing();
			UseGenericList();
			IndexingUsingString();
			Console.ResetColor();
		}

		static void IndexingUsingString() {
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("=> Indexing data using string values");

			PersonCollectionDic people = new PersonCollectionDic();
			people["Homer"] = new Person("Homer", "Simpson", 39);
			people["Marge"] = new Person("Marge", "Simpson", 37);

			Person homer = people["Homer"];

			Console.WriteLine(homer.ToString());
		}

		static void UseGenericList() {
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=> Use Generic List of Person");

			List<Person> people = new List<Person>();

			people.Add(new Person("Lisa", "Simpson", 9));
			people.Add(new Person("Bart", "Simpson", 7));

			people[0] = new Person("Maggie", "Simpson", 2);

			for(int i = 0; i < people.Count; i++)
				Console.WriteLine($"Person Number: {i}, Name: {people[i].FirstName} {people[i].LastName}, Age: {people[i].Age}");
		}

		static void SimpleIndexing() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Simple Indexer");

			PersonCollection people = new PersonCollection();
			people[0] = new Person("Homer", "Simpson", 40);
			people[1] = new Person("Marge", "Simpson", 38);
			people[1] = new Person("Lisa", "Simpson", 9);
			people[3] = new Person("Bart", "Simpson", 7);
			people[4] = new Person("Maggie", "Simpson", 2);

			for(int i = 0; i < people.Count; i++)
				Console.WriteLine($"Person Number: {i}, Name: {people[i].FirstName} {people[i].LastName}, Age: {people[i].Age}");

			foreach (Person p in people)
				Console.WriteLine($"Person Name: {p.FirstName} {p.LastName}, Age: {p.Age}");
		}
	}
}

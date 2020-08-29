using System;

namespace SimpleIndexer {
	class Program {
		static void Main() {
			Console.WriteLine("***** Indexer Methods *****");
			SimpleIndexing();
			Console.ResetColor();
		}

		static void SimpleIndexing() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Simple Indexer");

			PersonCollection people = new PersonCollection();
			people[0] = new Person("Homer", "Simpson", 40);
			people[1] = new Person("Marge", "Simpson", 38);
			people[2] = new Person("Lisa", "Simpson", 9);
			people[3] = new Person("Bart", "Simpson", 7);
			people[4] = new Person("Maggie", "Simpson", 2);

			for(int i = 0; i < people.Count; i++)
				Console.WriteLine($"Person Number {i}, Name: {people[i].FirstName} {people[i].LastName}, Age: {people[i].Age}");
		}
	}
}

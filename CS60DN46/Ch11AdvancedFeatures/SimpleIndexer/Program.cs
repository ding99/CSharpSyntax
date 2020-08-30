using System;
using System.Collections.Generic;
using System.Data;

namespace SimpleIndexer {
	class Program {
		static void Main() {
			Console.WriteLine("***** Indexer Methods *****");
			SimpleIndexing();
			UseGenericList();
			IndexingUsingString();
			MultiIndexer();
			OnInterface();
			Console.ResetColor();
		}

		static void OnInterface() {
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine("=> Indexer Definition on Interface Types");

			SomeClass people = new SomeClass();
			people[0] = "Homer";
			people[0] = "Marge";

			Console.Write("List using for:");
			for (int i = 0; i < people.Count; i++)
				Console.Write($" {people[i]}");
			Console.WriteLine();

			Console.Write("List using foreach:");
			foreach (string s in people)
				Console.Write($" {s}");
			Console.WriteLine();
		}

		static void MultiIndexer() {
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("=> Multi Indexer with DataTable");

			//Make a DataTable with 3 columns
			DataTable table = new DataTable();
			table.Columns.Add(new DataColumn("FirstName"));
			table.Columns.Add(new DataColumn("LastName"));
			table.Columns.Add(new DataColumn("Age"));

			//Add a row to the table
			table.Rows.Add("Mel", "Appleby", 60);

			//Use multidimension indexer to get details of first row
			Console.WriteLine($"First Name: {table.Rows[0][0]}, Last Name: {table.Rows[0][1]}, Age: {table.Rows[0][2]}");
		}

		static void IndexingUsingString() {
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("=> Indexing data using string values");

			PersonCollectionDic people = new PersonCollectionDic();
			people["Homer"] = new Person("Homer", "Simpson", 39);
			people["Marge"] = new Person("Marge", "Simpson", 37);

			foreach(KeyValuePair<string, Person> p in people) {
				Console.WriteLine($"  {p.Key} : <{p.Value}>");
			}

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

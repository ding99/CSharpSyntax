using System;
using System.Collections.Generic;

namespace Dictionary {
	public class Person {
		public int Age;
		public string Name;
		public string Address;

		public override string ToString() {return $"<Name:({Name}),Age:({Age}),Address:({Address})>"; }
	}

	public class PersonKey {
		private int _age;
		private string _name;

		public int Age => _age;
		public string Name => _name;

		public PersonKey(Person person) {
			_age = person.Age;
			_name = person.Name;
		}

		public PersonKey(int age, string name) {
			_age = age;
			_name = name;
		}

		public override int GetHashCode() {
			return 0;
		}

		public override bool Equals(object obj) {
			return Equals(obj as PersonKey);
		}

		public bool Equals(PersonKey k) {
			return k != null && k.Age == this.Age && k.Name == this.Name;
		}
	}

	public class ExamineKey {

		public ExamineKey() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("-- Examine Key");
		}

		private string Key(PersonKey key) {
			return $"<Age{key.Age},Name:{key.Name}>";
		}
		public void Start() {

			Dictionary<PersonKey, Person> storage = new Dictionary<PersonKey, Person>();

			Person p = new Person { Age = 33, Name = "Jason", Address = null };
			PersonKey key = new PersonKey(p);

			Person p1 = new Person { Age = 35, Name = "Rob", Address = null };
			PersonKey key1 = new PersonKey(p1);

			storage[key] = p;
			storage[key1] = p1;

			var searchKey = new PersonKey(33, "Jason");
			var searchKey2 = new PersonKey(33, "Jason1");

			try {
				Console.WriteLine($"Key-{Key(key)}, Data-{storage[key]}"); //<-- Jason person
				Console.WriteLine($"Key-{Key(searchKey)}, Data-{storage[searchKey]}"); //<-- Jason person

				if (storage.ContainsKey(searchKey2)) // not found
					Console.WriteLine($"<{storage[searchKey2]}>");
				else
					Console.WriteLine("Not found searchKey2 key");
			}
			catch (Exception e) {
				Console.WriteLine(e.Message);
			}
		}
	}
}
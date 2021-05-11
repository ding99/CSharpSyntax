using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List {
	public class Brief {

        public class Person {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public Brief() {
            Console.ForegroundColor = ConsoleColor.Green;
		}

        public void list() {
            List<Person> team = new List<Person> {
                new Person{ Name = "Peter", Age = 20},
                new Person{ Name = "Jason", Age = 21},
                new Person{ Name = "Kevin", Age = 22},
                new Person{ Name = "Allen", Age = 23},
                new Person{ Name = "Steve", Age = 25}
            };

            StringBuilder b = new StringBuilder();
            foreach(Person p in team)
                b.Append(b.Length < 1 ? "" : ", ").Append(p.Name);
            Console.WriteLine($"Sum 1 <{b.ToString()}>");

            Console.WriteLine();

            StringBuilder c = new StringBuilder();
            team.ForEach( p => c.Append(c.Length < 1 ? "" : ", ").Append(p.Name));
            Console.WriteLine($"Sum 2 <{c.ToString()}>");
        }

        public void less() {
            List<Person> team = new List<Person> {
                new Person{ Name = "Peter", Age = 20},
                new Person{ Name = "Ken", Age = 21},
                new Person{ Name = "Kevin", Age = 22},
                new Person{ Name = "Alen", Age = 23},
                new Person{ Name = "Steven", Age = 25}
            };

            StringBuilder b = new StringBuilder();
            foreach(Person p in team)
                if(p.Name.Length > 4)
                    b.Append(b.Length < 1 ? "" : ", ").Append(p.Name);
            Console.WriteLine($"Sum 1 <{b.ToString()}>");

            Console.WriteLine();

            StringBuilder c = new StringBuilder();
            team.Where(p => p.Name.Length > 4).ToList().ForEach(p => c.Append(c.Length < 1 ? "" : ", ").Append(p.Name));
            Console.WriteLine($"Sum 2 <{c.ToString()}>");
        }
    }
}

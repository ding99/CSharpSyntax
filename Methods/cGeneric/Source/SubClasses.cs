using System;
using System.Collections.Generic;

namespace cGeneric.Source
{
	class Persion
	{
		public int Age { get; set; }
		public string Name { get; set; }

		public virtual string Say() { return "I am a perosn"; }
	}

	class Student : Persion
	{
		public override string Say() { return "I am a student"; }
	}

	class Freshman : Student
	{
		public override string Say() { return "I am a Freshman"; }
	}

	class PracticeGeneric{
		public void Start()
		{
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine("=> Practice Generic Class");

			List<Persion> persons;

			Console.WriteLine("-> instance of studends");
			persons = new List<Persion>();
			persons.Add(new Student { Name = "Jason", Age = 25 });
			persons.Add(new Student { Name = "David", Age = 23 });
			persons.Add(new Freshman { Name = "Steve", Age = 19 });
			foreach (var a in persons)
				Console.WriteLine($"  {a.Name} {a.Age} {a.Say()}");

			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("-> instance of Freshmen");
			persons = new List<Persion>();
			persons.Add(new Freshman { Name = "Paul", Age = 21 });
			persons.Add(new Freshman { Name = "John", Age = 20 });
			persons.Add(new Freshman { Name = "Mike", Age = 19 });
			foreach (var a in persons)
				Console.WriteLine($"  {a.Name} {a.Age} {a.Say()}");
		}
	}
}

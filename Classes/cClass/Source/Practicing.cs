using System;

namespace CClass
{
	class Practicing
	{
		public string Name { get; set; }
		public int Age { get; set; }

		public Practicing(string name, int age) { Name = name; Age = age; }

		public int Cal01(string name, int age) { return name.Length + age; }
		public int Cal01(string name) { return name.Length + Age; }
	}

	class OverLoad
	{
		public void Test()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=> Practice Overloading");

			Practicing oload = new Practicing("David", 25);
			Console.WriteLine($"Cal01 {oload.Cal01("Mike", 30)}");
			Console.WriteLine($"Cal01 {oload.Cal01("Mike")}");
		}
	}
}

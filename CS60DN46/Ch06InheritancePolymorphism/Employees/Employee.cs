using System;

namespace Employees
{
	partial class Employee
	{
		public void GiveBonus(float amount) { pay += amount; }

		public void Display()
		{
			Console.WriteLine($"Name: {Name}");
			Console.WriteLine($"ID: {ID}");
			Console.WriteLine($"Age: {Age}");
			Console.WriteLine($"Pay: {Pay}");
			Console.WriteLine($"SSN: {SSN}");
		}
	}
}

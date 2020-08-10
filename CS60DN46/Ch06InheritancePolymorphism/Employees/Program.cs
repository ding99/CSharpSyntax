using System;

namespace Employees
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("***** The Employee Class Hierarchy *****");
			Subclasses();
			Console.ResetColor();
		}

		static void Subclasses()
		{
			Console.ForegroundColor = ConsoleColor.Green;

			SalesPerson fred = new SalesPerson { Age = 31, Name = "Fred", SalesNumber = 50 };
			Console.WriteLine($"SalesPerson: {fred.Name}, {fred.SalesNumber}, {fred.Age}");

			Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
			Console.WriteLine($"Manager: {chucky.Name}, {chucky.StockOptions}, {chucky.Age}");
		}
	}
}

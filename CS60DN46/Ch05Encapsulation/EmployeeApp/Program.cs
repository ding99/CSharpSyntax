using System;

namespace EmployeeApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Employee *****");
			Traditional();
			Console.ResetColor();
		}

		static void Traditional()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("=> Traditional accessors and mutators");

			EmployeeTra emp = new EmployeeTra("Marvin", 456, 30000);
			emp.GiveBonus(1000);
			emp.Display();

			Console.WriteLine("-> Set a new name");
			emp.SetName("Marv");
			emp.Display();
		}
	}
}

using System;

namespace EmployeeApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Employee *****");
			Traditional();
			ByProperties();
			Console.ResetColor();
		}

		static void ByProperties()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Using .NET Properties");

			EmployeePro emp = new EmployeePro("Marvin", 456, 30000);
			emp.GiveBonus(1000);
			emp.Display();

			Console.WriteLine("-> Set a new name");
			emp.Name = "Marv";
			emp.Display();
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

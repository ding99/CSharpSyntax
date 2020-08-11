using System;

namespace Employees
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("***** The Employee Class Hierarchy *****");
			Subclasses();
			Containment();
			Nesting();
			Bonus();
			Casting();
			Console.ResetColor();
		}

		static void Casting()
		{
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine("=> Casting Rules");

			object frank = new Manager("Frank", 9, 3000, 40000, "111111111", 5);
			Employee moon = new Manager("Moon", 2, 3001, 20000, "101111111", 10);
			SalesPerson jill = new PTSalesPerson("Jill", 834, 3002, 100002,"102111111", 90);

			GivePromotion(moon); GivePromotion(jill);
		}
		
		static void GivePromotion(Employee emp)
		{
			Console.WriteLine($"{emp.Name} was promoted!");
		}

		static void Bonus()
		{
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("=> Bonus");

			Manager chucky = new Manager("Chucky", 52, 92, 100002, "333221112", 9002);
			chucky.Display();
			chucky.GiveBonus(500);
			chucky.Display();

			SalesPerson fran = new SalesPerson("Fran", 43, 93, 5003, "933221111", 31);
			fran.Display();
			fran.GiveBonus(300);
			fran.Display();
		}

		static void Nesting()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=> Nesting and nested");

			Outer.PublicInner inner = new Outer.PublicInner();
			Console.WriteLine($"Benefit value: {inner.GetBenefit()}");

			Outer outer = new Outer();
			Console.WriteLine($"Private value: {outer.PrivateValue()}");
			Console.WriteLine($"Private string: <{outer.PrivateString()}>");

			Employee.BenefitNest.BenefitLevel bLevel = Employee.BenefitNest.BenefitLevel.Platinum;
			Console.WriteLine($"Benefit level: {bLevel}");
		}

		static void Containment()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Containment and Delegation");

			Manager david = new Manager("David", 51, 91, 100001, "333221111", 9001);
			double cost = david.GetBenefitCost();
			Console.WriteLine($"cost: {cost}");
		}
		static void Subclasses()
		{
			Console.ForegroundColor = ConsoleColor.Green;

			SalesPerson fred = new SalesPerson { Age = 31, Name = "Fred", SalesNumber = 50 };
			Console.WriteLine($"SalesPerson: {fred.Name}, {fred.SalesNumber}, {fred.Age}");

			PTSalesPerson jason = new PTSalesPerson { Age = 26, Name = "Jason", SalesNumber = 35 };
			Console.WriteLine($"Part-time SalesPerson: {jason.Name}, {jason.SalesNumber}, {jason.Age}");

			Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
			Console.WriteLine($"Manager: {chucky.Name}, {chucky.StockOptions}, {chucky.Age}");
		}
	}
}

using System;

namespace Employees
{
	partial class Employee
	{
		public class BenefitNest
		{
			public enum BenefitLevel { Standard, Gold, Platinum }
			public double PayDeduction() { return 150.0; }
		}

		public void GiveBonus(float amount) { pay += amount; }

		public void Display()
		{
			Console.WriteLine($"Name: {Name}");
			Console.WriteLine($"ID: {ID}");
			Console.WriteLine($"Age: {Age}");
			Console.WriteLine($"Pay: {Pay}");
			Console.WriteLine($"SSN: {SSN}");
		}

		public double GetBenefitCost()
		{
			return benefits.PayDeduction();
		}
	}
}

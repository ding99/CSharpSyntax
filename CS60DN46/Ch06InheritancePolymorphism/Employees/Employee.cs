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

		public virtual void GiveBonus(float amount) { pay += amount; }

		public virtual void Display()
		{
			Console.WriteLine($"Name: {Name}, ID: {ID}, Age: {Age}, Pay: {Pay}, SSN: {SSN}");
		}

		public double GetBenefitCost()
		{
			return benefits.PayDeduction();
		}
	}
}

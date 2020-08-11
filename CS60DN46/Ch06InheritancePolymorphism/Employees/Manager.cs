using System;

namespace Employees
{
	class Manager : Employee
	{
		public int StockOptions { get; set; }

		public Manager() { }

		public Manager(string name, int age, int id, float pay, string ssn, int numOfOpts) : base(name, age, id, pay, ssn)
		{
			StockOptions = numOfOpts;
		}

		public override void GiveBonus(float amount)
		{
			base.GiveBonus(amount);
			Random r = new Random();
			StockOptions += r.Next(500);
		}

		public override void Display()
		{
			base.Display();
			Console.WriteLine($"Number of Stock Options: {StockOptions}");
		}
	}
}

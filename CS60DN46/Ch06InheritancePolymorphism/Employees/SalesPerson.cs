namespace Employees
{
	class SalesPerson : Employee
	{
		public int SalesNumber { get; set; }

		public SalesPerson() { }

		public SalesPerson(string name, int age, int id, float pay, string ssn, int numbOfSales) : base(name, age, id, pay, ssn)
		{
			SalesNumber = numbOfSales;
		}

		public override void GiveBonus(float amount)
		{
			int salesBonus = 0;
			if (SalesNumber >= 0 && salesBonus <= 100)
				salesBonus = 10;
			else
			{
				if (SalesNumber > 100 && salesBonus <= 200)
					salesBonus = 15;
				else
					salesBonus = 20;
			}
			base.GiveBonus(amount * salesBonus);
		}
	}
}

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
	}
}

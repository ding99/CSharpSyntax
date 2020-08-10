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
	}
}

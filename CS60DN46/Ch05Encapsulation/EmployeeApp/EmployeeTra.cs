using System;

namespace EmployeeApp
{
	class EmployeeTra
	{
		private string name;
		private int id;
		private float pay;

		public EmployeeTra() { }
		public EmployeeTra(string name, int id, float pay)
		{
			this.name = name; this.id = id; this.pay = pay;
		}

		public string GetName() { return name; }
		public void SetName(string name) {
			if (name.Length > 15)
				Console.WriteLine("Error! Name length exceeds 15 characters!");
			else this.name = name;
		}

		public void GiveBonus(float amount)
		{
			pay += amount;
		}

		public void Display()
		{
			Console.WriteLine($"Name: {name}");
			Console.WriteLine($"ID: {id}");
			Console.WriteLine($"Pay: {pay}");
		}
	}
}

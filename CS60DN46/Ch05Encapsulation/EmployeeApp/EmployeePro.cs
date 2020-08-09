using System;

namespace EmployeeApp
{
	class EmployeePro
	{
		private string name;
		private int id;
		private float pay;
		private int age;

		public EmployeePro() { }
		public EmployeePro(string name, int id, float pay)
			: this(name, 0, id, pay) { }
		public EmployeePro(string name, int age, int id, float pay)
		{
			if(name.Length > 15)
				Console.WriteLine("Error! Name length exceeds 15 characters!");
			else  this.name = name;
			
			this.age = age; this.id = id; this.pay = pay;
		}

		public string Name
		{
			get { return name; }
			set {
				if (value.Length > 15)
					Console.WriteLine("Error! Name length exceeds 15 characters!");
				else name = value;
			}
		}

		public int Age { get { return age; } set { age = value; } }

		public float Pay {  get { return pay; } set { pay = value; } }

		public int ID { get { return id;  } set { id = value; } }

		public void GiveBonus(float amount)
		{
			pay += amount;
		}

		public void Display()
		{
			Console.WriteLine($"Name: {name}");
			Console.WriteLine($"ID: {id}");
			Console.WriteLine($"Age: {age}");
			Console.WriteLine($"Pay: {pay}");
		}
	}
}

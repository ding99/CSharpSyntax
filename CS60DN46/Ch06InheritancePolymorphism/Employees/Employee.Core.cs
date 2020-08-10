using System;

namespace Employees
{
	partial class Employee
	{
		private string name;
		private int id;
		private float pay;
		private int age;
		private string ssn;

		#region ctors
		public Employee() { }
		public Employee(string name, int id, float pay)
			: this(name, 0, id, pay, "") { }
		public Employee(string name, int age, int id, float pay, string ssn)
		{
			Name = name; Age = age; ID = id; Pay = pay; this.ssn = ssn;
		}
		#endregion

		public string Name {
			get { return name; }
			set {
				if (value.Length > 15)
					Console.WriteLine("Error! Name length exceeds 15 characters!");
				else name = value;
			}
		}

		public int Age { get { return age; } set { age = value; } }

		public float Pay { get { return pay; } set { pay = value; } }

		public int ID { get { return id; } set { id = value; } }

		public string SSN { get { return ssn; } }
	}
}
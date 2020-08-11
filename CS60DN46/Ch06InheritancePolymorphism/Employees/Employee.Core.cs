using System;

namespace Employees
{
	abstract partial class Employee
	{
		protected string name;
		protected int id;
		protected float pay;
		protected int age;
		protected string ssn;
		protected BenefitPackage benefits = new BenefitPackage();

		#region ctors
		public Employee() { }
		public Employee(string name, int id, float pay)
			: this(name, 0, id, pay, "") { }
		public Employee(string name, int age, int id, float pay)
		{
			Name = name; Age = age; ID = id; Pay = pay;
		}
		public Employee(string name, int age, int id, float pay, string ssn)
			: this(name, age, id, pay)
		{
			this.ssn = ssn;
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

		//public BenefitPackage Benefits {
		//	get { return benefits; }
		//	set { benefits = value; }
		//}
	}
}

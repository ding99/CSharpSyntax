namespace ObjectOverrides
{
	class Person
	{
		public string FirstName { get; set; } = "";
		public string LastName { get; set; } = "";
		public int Age { get; set; }

		public Person(string fName, string lName, int age)
		{
			FirstName = fName;
			LastName = lName;
			Age = age;
		}
		public Person() { }

		public override string ToString()
		{
			return string.Format($"[First Name: {FirstName}; Last Name: {LastName}; Age: {Age}]");
		}

		public override bool Equals(object obj)
		{
			//if (obj is Person && obj != null)
			//{
			//	Person temp = (Person)obj;
			//	return temp.FirstName == this.FirstName
			//		&& temp.LastName == this.LastName
			//		&& temp.Age == this.Age;
			//}
			//return false;

			return obj.ToString() == this.ToString();
		}

		public override int GetHashCode()
		{
			return ToString().GetHashCode();
		}
	}
}

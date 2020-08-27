namespace ConstrainingType
{
	class Person
	{
		public int Age { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public Person(string first, string last, int age)
		{
			Age = age; FirstName = first; LastName = last;
		}

		public override string ToString()
		{
			return string.Format($"Name: {FirstName} {LastName}, Age: {Age}");
		}
	}
}

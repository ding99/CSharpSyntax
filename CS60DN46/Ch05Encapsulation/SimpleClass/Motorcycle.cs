namespace SimpleClass
{
	class Motorcycle
	{
		public int driverIntensity;
		public string name;

		public Motorcycle(int intensity, string name) { driverIntensity = intensity; name = name; }
		public void SetDriverName(string name) { name = name; }
		public void PopAWheely()
		{
			for (int i = 0; i < driverIntensity; i++)
				System.Console.WriteLine("Yeeeeeee Haaaaaaeeww!"); ;
		}
	}
}

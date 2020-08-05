namespace SimpleClass
{
	class Motorcycle
	{
		public int driverIntensity;
		public string name;

		public Motorcycle() { }
		public Motorcycle(int intensity) : this(intensity, "") { }
		public Motorcycle(string name) : this(0, name) { }
		public Motorcycle(int intensity, string name) {
			if (intensity > 10) intensity = 10;
			driverIntensity = intensity; this.name = name;
		}

		public void SetDriverName(string name) { this.name = name; }
		public void PopAWheely()
		{
			for (int i = 0; i < driverIntensity; i++)
				System.Console.WriteLine("Yeeeeeee Haaaaaaeeww!"); ;
		}
	}
}

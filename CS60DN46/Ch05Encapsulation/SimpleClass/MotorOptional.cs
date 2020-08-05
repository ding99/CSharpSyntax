namespace SimpleClass
{
	class MotorOptional
	{
		public int intensity;
		public string name;

		public MotorOptional(int intensity = 0, string name = "")
		{
			this.intensity = intensity > 10 ? 10 : intensity;
			this.name = name;
		}

		public void SetDriverName(string name) { this.name = name; }

		public void PopAWheely()
		{
			for (int i = 0; i < intensity; i++)
				System.Console.WriteLine("Yeeeeeee Haaaaaaeeww!"); ;
		}
	}
}

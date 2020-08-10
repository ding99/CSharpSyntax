namespace BasicInheritance
{
	class Car
	{
		public readonly int maxSpeed;
		private int currSpeed;

		public Car(int max) { maxSpeed = max; }
		public Car() { maxSpeed = 55; }

		public int Speed {
			get { return currSpeed; }
			set { currSpeed = value > maxSpeed ? maxSpeed : value; }
		}

		public void CurrSpeed()
		{
			System.Console.WriteLine($"private variable (currSpeed): {this.currSpeed}");
		}
	}
}

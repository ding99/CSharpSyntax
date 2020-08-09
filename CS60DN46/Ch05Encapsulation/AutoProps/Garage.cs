namespace AutoProps
{
	class Garage
	{
		public int NumberofCars { get; set; }
		public Car Auto { get; set; }

		public Garage()
		{
			Auto = new Car();
			NumberofCars = 1;
		}

		public Garage(Car car, int number)
		{
			Auto = car;
			NumberofCars = number;
		}
	}
}

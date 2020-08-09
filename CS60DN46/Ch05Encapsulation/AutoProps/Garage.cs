namespace AutoProps
{
	class Garage
	{
		public int NumberofCars { get; set; } = 1;
		public Car Auto { get; set; } = new Car();

		public Garage() {}

		public Garage(Car car, int number)
		{
			Auto = car;
			NumberofCars = number;
		}
	}
}

using System.Collections;

namespace CustomEnumerator
{
	class Garage : IEnumerable
	{
		private Car[] cars = new Car[4];
		public Garage()
		{
			cars[0] = new Car("Rusty", 30);
			cars[1] = new Car("Clunker", 55);
			cars[2] = new Car("Zippy", 30);
			cars[3] = new Car("Fred", 30);
		}

		public IEnumerator GetEnumerator()
		{
			return cars.GetEnumerator();
		}
	}
}

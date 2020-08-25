using System.Collections;

namespace CustomEnumerator
{
	class Garage2 : IEnumerable
	{
		private Car[] cars = new Car[4];
		public Garage2()
		{
			cars[0] = new Car("Rusty2", 30);
			cars[1] = new Car("Clunker2", 55);
			cars[2] = new Car("Zippy2", 30);
			cars[3] = new Car("Fred2", 30);
		}

		public IEnumerator GetEnumerator()
		{
			foreach(Car c in cars)
				yield return c;
		}
	}
}

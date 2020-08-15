using System.Collections;

namespace CustomEnumeratorWithYield
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
			foreach (Car c in cars)
				yield return c;
		}

		/* When building a named iterator, be aware that the method will return the IEnumerable interface, rather than the expected IEnumerator-compatible type. */
		public IEnumerable GetTheCars(bool ReturnRevesed)
		{
			if (ReturnRevesed)
			{
				for (int i = cars.Length; i != 0; i--)
					yield return cars[i - 1];
			} else
			{
				foreach (Car c in cars)
					yield return c;
			}
		}
	}
}

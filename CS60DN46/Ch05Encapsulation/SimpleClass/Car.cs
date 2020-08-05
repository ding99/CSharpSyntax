using System;

namespace SimpleClass
{
	class Car
	{
		public string name;
		public int speed;

		public Car() { name = "Chuck"; speed = 10; }
		public void PrintState()
		{
			Console.WriteLine($"{name} is going {speed} MPH.");
		}

		public void SpeedUp(int delta) { speed += delta; }
	}
}

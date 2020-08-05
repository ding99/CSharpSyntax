using System;

namespace SimpleClass
{
	class Car
	{
		public string name;
		public int speed;

		public Car() { name = "Chuck"; speed = 10; }
		public Car(string pn) { name = pn;  }
		public Car(string pn, int cs) { name = pn; speed = cs; }

		public void PrintState()
		{
			Console.WriteLine($"{name} is going {speed} MPH.");
		}

		public void SpeedUp(int delta) { speed += delta; }
	}
}

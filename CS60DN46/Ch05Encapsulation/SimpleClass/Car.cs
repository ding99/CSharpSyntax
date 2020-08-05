using System;

namespace SimpleClass
{
	class Car
	{
		public string name;
		public int speed;

		public void PrintState()
		{
			Console.WriteLine($"{name} is going {speed} MPH.");
		}

		public void SpeedUp(int delta) { speed += delta; }
	}
}

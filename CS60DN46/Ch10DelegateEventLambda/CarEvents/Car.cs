using System;

namespace CarEvents {
	class Car {
		public int Speed { get; set; }
		public int MaxSpeed { get; set; }
		public string Name { get; set; }

		private bool carIsDead;

		public Car() { }
		public Car(string name, int max, int speed) {
			Speed = speed; MaxSpeed = max; Name = name;
		}

		public delegate void CarEngineHandler(string msg);

		public event CarEngineHandler Exploaded;
		public event CarEngineHandler AboutToBlow;

		public void Accelerate(int delta) {
			if (carIsDead) {
				if (Exploaded != null)
					Exploaded("Sorry, this car is dead...");
			} else {
				Speed += delta;

				if (10 >= (MaxSpeed - Speed) && AboutToBlow != null)
					AboutToBlow("Careful buddy! Gonna blow!");
			}

			if (Speed >= MaxSpeed) carIsDead = true;
			else Console.WriteLine($"Current Speed = {Speed}");
		}

		public void Reset() {
			carIsDead = false;
			Speed = 10;
		}
	}
}

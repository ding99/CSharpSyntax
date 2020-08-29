using System;

namespace CarEvents {
	class CarGenericArgs : EventArgs {
		public readonly string msg;
		public readonly DateTime time;
		public CarGenericArgs(string message, DateTime datetime) { msg = message; time = datetime; }
	}

	class CarGeneric {
		public int Speed { get; set; }
		public int MaxSpeed { get; set; }
		public string Name { get; set; }

		private bool carIsDead;

		public CarGeneric() { }
		public CarGeneric(string name, int max, int speed) {
			Speed = speed; MaxSpeed = max; Name = name;
		}

		public event EventHandler<CarGenericArgs> Exploaded;
		public event EventHandler<CarGenericArgs> AboutToBlow;

		public void Accelerate(int delta) {
			if (carIsDead) {
				Exploaded?.Invoke(this, new CarGenericArgs("Sorry, this car is dead...", DateTime.Now));
			} else {
				Speed += delta;

				if (10 >= (MaxSpeed - Speed))
					AboutToBlow?.Invoke(this, new CarGenericArgs("Careful buddy! Gonna blow!", DateTime.Now));
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

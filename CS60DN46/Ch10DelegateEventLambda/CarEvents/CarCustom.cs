using System;

namespace CarEvents {
	class CarEventArgs : EventArgs {
		public readonly string msg;
		public readonly DateTime time;
		public CarEventArgs(string message, DateTime datetime) { msg = message; time = datetime; }
	}

	class CarCustom {
		public int Speed { get; set; }
		public int MaxSpeed { get; set; }
		public string Name { get; set; }

		private bool carIsDead;

		public CarCustom() { }
		public CarCustom(string name, int max, int speed) {
			Speed = speed; MaxSpeed = max; Name = name;
		}

		public delegate void CarEngineHandler(object sender, CarEventArgs e);

		public event CarEngineHandler Exploaded;
		public event CarEngineHandler AboutToBlow;

		public void Accelerate(int delta) {
			if (carIsDead) {
				Exploaded?.Invoke(this, new CarEventArgs("Sorry, this car is dead...", DateTime.Now));
			} else {
				Speed += delta;

				if (10 >= (MaxSpeed - Speed))
					AboutToBlow?.Invoke(this, new CarEventArgs("Careful buddy! Gonna blow!", DateTime.Now));
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

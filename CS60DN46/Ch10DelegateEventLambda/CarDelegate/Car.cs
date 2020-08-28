namespace CarDelegate
{
	class Car
	{
		public delegate void CarEngineHandler(string msgForCaller);
		private CarEngineHandler listOfHandlers;

		public int Speed { get; set; }
		public int MaxSpeed { get; set; }
		public string Name { get; set; }

		private bool carIsDead;

		public Car() { }
		public Car(string name, int max, int speed)
		{
			Speed = speed; MaxSpeed = max; Name = name;
		}

		public void RegisterWithCarEngine(CarEngineHandler methodToCall)
		{
			listOfHandlers += methodToCall;
		}
		public void RegisterWithCarEngineAlternative(CarEngineHandler methodToCall)
		{
			if (listOfHandlers == null)
				listOfHandlers = methodToCall;
			else
				System.Delegate.Combine(listOfHandlers, methodToCall);
		}

		public void Accelerate(int delta)
		{
			if (carIsDead)
			{
				if (listOfHandlers != null)
					listOfHandlers("Sorry, this car is dead...");
			}
			else
			{
				Speed += delta;
				if (10 >= (MaxSpeed - Speed) && listOfHandlers != null)
					listOfHandlers("Careful buddy! Gonna blow");
			}

			if (Speed >= MaxSpeed)
				carIsDead = true;
			else System.Console.WriteLine($"Current Speed = {Speed}");
		}
	}
}

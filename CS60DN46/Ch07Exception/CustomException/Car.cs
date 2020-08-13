using System;

namespace CustomException
{
	class Car
	{
		public const int MaxSpeed = 100;
		public int CurrSpeed { get; set; } = 0;
		public string PetName { get; set; } = "";
		private bool carIsDead;

		private Radio theMusicBox = new Radio();

		public Car() { }
		public Car(string name, int speed) { CurrSpeed = speed; PetName = name; }

		public void CrankTunes(bool state)
		{
			theMusicBox.TrunOn(state);
		}

		public void Accelerate(int delta)
		{
			if(carIsDead)
				Console.WriteLine($"{PetName} is out of order...");
			else
			{
				CurrSpeed += delta;
				if(CurrSpeed >= MaxSpeed)
				{
					CurrSpeed = 0;
					carIsDead = true;
					Exception ex = new Exception(string.Format($"{PetName} has overheated!"));
					ex.HelpLink = @"http://www.cars.com";
					ex.Data.Add("TimeStamp", string.Format($"The car exploded at {DateTime.Now}"));
					ex.Data.Add("Cause", "You have a lead foot.");
					throw ex;
				}
				else
					Console.WriteLine($"=> CurrentSpeed = {CurrSpeed}");
			}
		}
	}
}

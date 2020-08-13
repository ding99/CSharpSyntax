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

		public void Accelerate1(int delta)
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
					CarIsDeadException1 ex = new CarIsDeadException1(string.Format($"{PetName} has overheated!"), "You have a lead foot", DateTime.Now);
					ex.HelpLink = @"http://www.carsrus.com";
					throw ex;
				}
				else
					Console.WriteLine($"=> CurrentSpeed = {CurrSpeed}");
			}
		}

		public void Accelerate2(int delta)
		{
			if (carIsDead)
				Console.WriteLine($"{PetName} is out of order...");
			else
			{
				CurrSpeed += delta;
				if (CurrSpeed >= MaxSpeed)
				{
					CurrSpeed = 0;
					carIsDead = true;
					CarIsDeadException2 ex = new CarIsDeadException2(string.Format($"{PetName} has overheated!"), "You have a lead foot", DateTime.Now);
					ex.HelpLink = @"http://www.carsrus.com";
					throw ex;
				}
				else
					Console.WriteLine($"=> CurrentSpeed = {CurrSpeed}");
			}
		}
	}
}

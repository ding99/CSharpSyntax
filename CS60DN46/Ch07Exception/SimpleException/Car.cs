using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleException
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
				if(CurrSpeed > MaxSpeed)
				{
					Console.WriteLine($"{PetName} has overheated!");
					CurrSpeed = 0;
					carIsDead = true;
				}
				else
					Console.WriteLine($"=> CurrentSpeed = {CurrSpeed}");
			}
		}
	}
}

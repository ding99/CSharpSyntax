using System;
using System.Collections;

namespace ComparableCar
{
	public class Car : IComparable
	{
		//Property to return the PetNameComparer.
		public static IComparer SortByPetName { get { return (IComparer)new PetNameComparer(); } }

		public int CarID { get; set; }
		public const int MaxSpeed = 100;
		public int CurrSpeed { get; set; } = 0;
		public string PetName { get; set; } = "";
		private bool carIsDead;

		private Radio theMusicBox = new Radio();

		public Car() { }
		public Car(string name, int speed) { CurrSpeed = speed; PetName = name; }
		public Car(string name, int speed, int id)
		{
			CurrSpeed = speed;
			PetName = name;
			CarID = id;
		}

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

		int IComparable.CompareTo(object obj)
		{
			Car temp = obj as Car;
			if (temp != null)
				return CarID.CompareTo(temp.CarID);
			else
				throw new ArgumentException("Parameter is ot a Car");
		}
	}
}

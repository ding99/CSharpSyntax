using System;

namespace WithGenericCollections
{
	public class Car : IComparable<Car>
	{
		public int CarID { get; set; }
		public const int MaxSpeed = 100;
		public int CurrSpeed { get; set; } = 0;
		public string PetName { get; set; } = "";

		public Car() { }
		public Car(string name, int speed) { CurrSpeed = speed; PetName = name; }
		public Car(string name, int speed, int id)
		{
			CurrSpeed = speed;
			PetName = name;
			CarID = id;
		}

		int IComparable<Car>.CompareTo(Car obj)
		{
			if (CarID > obj.CarID)
				return 1;
			if (CarID < obj.CarID)
				return -1;
			else return 0;
		}
	}
}

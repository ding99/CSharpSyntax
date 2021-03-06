﻿namespace BasicInheritance
{
	class Car
	{
		public int maxSpeed;
		private int speed;

		public Car() { maxSpeed = 55; }
		public Car(int max) { maxSpeed = max; }

		public int Speed {
			get { return speed; }
			set { speed = value; if (speed > maxSpeed) speed = maxSpeed; }
		}

		public virtual void SetMax(int max) { maxSpeed = max; }
	}
}

using System;

namespace VisualTypeDesignerApp
{
	class Program
	{
		private static int number = 2;

		public static void Main(string[] args)
		{
			number++;
			
			
			Console.WriteLine("Hello Visual Type! " + number + "; Color {0} with value {1:D}", CarColor.Black,  CarColor.Black);

			SportCar newcar = new SportCar();
			newcar.color = CarColor.Gray;

			Console.WriteLine("New Car : " + newcar.GetPetName() + ", Color : " + newcar.color);
		}
	}
}

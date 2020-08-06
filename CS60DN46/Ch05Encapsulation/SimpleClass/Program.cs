using System;

namespace SimpleClass
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Fun with Class Types *****");

			Speeding();
			ThisKeyword();
			CtorFlow();
			MakeSomeBikes();

			Console.ResetColor();
		}

		static void MakeSomeBikes()
		{
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			MotorOptional m1 = new MotorOptional();
			Console.WriteLine($"name = [{m1.name}], intensity = {m1.intensity}");

			MotorOptional m2 = new MotorOptional(name: "Tiny");
			Console.WriteLine($"name = [{m2.name}], intensity = {m2.intensity}");

			MotorOptional m3 = new MotorOptional(5);
			Console.WriteLine($"name = [{m3.name}], intensity = {m3.intensity}");
		}

		static void CtorFlow()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			MotorFlow m = new MotorFlow(3);
			Console.WriteLine($"Rider name is [{m.name}]");

			m.SetDriverName("Tiny");
			m.PopAWheely();
			Console.WriteLine($"Rider name is [{m.name}]");
		}

		static void ThisKeyword()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Motorcycle c = new Motorcycle(5, "Jason");
			Console.WriteLine($"Rider name is [{c.name}]");

			c.SetDriverName("Tiny");
			c.PopAWheely();
			Console.WriteLine($"Rider name is [{c.name}]");
		}

		static void Speeding()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			
			Car chunk = new Car(); chunk.PrintState();

			Car mary = new Car("Mary"); mary.PrintState();

			Car daisy = new Car("Daisy", 75); daisy.PrintState();

			Car car = new Car();  car.name = "Henry"; car.speed = 50;
			for(int i = 0; i< 3; i++) { car.SpeedUp(3); car.PrintState(); }
		}
	}
}

using System;

namespace cInt {
	class random {
		public void Start() {
			Console.WriteLine("-- Random");

			Console.Write("Default Range:");
			Random rand = new Random();
			for (int i = 0; i < 32; i++) Console.Write(" " + rand.Next());
			Console.WriteLine();

			int min = -5, max = 5;
			Console.Write($"Range [{min},{max}):");
			for (int i = 0; i < 32; i++) Console.Write(" " + rand.Next(min, max));
			Console.WriteLine();

			Console.Write($"Range [0,{max}):");
			for (int i = 0; i < 32; i++) Console.Write(" " + rand.Next(max));
			Console.WriteLine();
		}
	}
}

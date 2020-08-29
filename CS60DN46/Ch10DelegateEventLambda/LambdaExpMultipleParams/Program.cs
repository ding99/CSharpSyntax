using System;

namespace LambdaExpMultipleParams {

	public class SimpleMath {
		public delegate void MathMessage(string msg, int result);
		private MathMessage mmDelegate;
		public void SetMathHandler(MathMessage target) { mmDelegate = target; }
		public void Add(int x, int y) { mmDelegate?.Invoke("Adding has completed!", x + y); }
	}

	class Program {
		static void Main() {
			Console.WriteLine("***** Lambda Expression Multiple Params *****");
			TwoParams();
			CustomArgs();
			Console.ResetColor();
		}

		static void CustomArgs() {
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine("=> Custom Event Arguments");

			CarCustom c1 = new CarCustom("SlugBug", 80, 10);
			c1.AboutToBlow += (sender, e) => Console.WriteLine($"{e.msg} at {e.time}");
			c1.Exploaded += (sender, e) => Console.WriteLine($"Exploaded: {e.msg} at {e.time}");

			Console.WriteLine("===== Speeding up");
			for (int i = 0; i < 6; i++) c1.Accelerate(20);
		}

		static void TwoParams() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Two parameters");

			SimpleMath m = new SimpleMath();
			m.SetMathHandler((msg, result) => Console.WriteLine($"Message: {msg}, Result: {result}"));

			m.Add(10, 20);
		}
	}
}

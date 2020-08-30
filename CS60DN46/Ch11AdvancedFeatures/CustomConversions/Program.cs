using System;

namespace CustomConversions {
	class Program {
		static void Main() {
			Console.WriteLine("***** Custom Conversion *****");
			StructConversion();
			Console.ResetColor();
		}

		static void StructConversion() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Convert a rectangle to a square");

			Rectangle r = new Rectangle(15, 4);
			Console.Write($"Rectangle: {r}. "); r.Draw();

			Square s = (Square)r;
			Console.Write($"Square: {s}. "); s.Draw();
		}
	}
}

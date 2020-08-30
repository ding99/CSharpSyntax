using System;

namespace CustomConversions {
	class Program {
		static void Main() {
			Console.WriteLine("***** Custom Conversion *****");
			StructConversion();
			ConvertRectangle();
			ExplicitConversion();
			Console.ResetColor();
		}

		static void ExplicitConversion() {
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("=> Conversion between a square and an integer");

			int size = 50; Console.WriteLine($"Original integer: {size}");
			Square sq = (Square)size; Console.WriteLine($"Square: {sq}");
			int side = (int)sq; Console.WriteLine($"Side length of the square: {side}");
		}

		static void ConvertRectangle() {
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=> Explicit conversion operatoin");
			Rectangle rect = new Rectangle(10, 5);
			Console.WriteLine($"Original rectangle: {rect}");
			DrawSquare((Square)rect);
		}
		static void DrawSquare(Square sq) {
			Console.Write($"Square: {sq}. "); sq.Draw();
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

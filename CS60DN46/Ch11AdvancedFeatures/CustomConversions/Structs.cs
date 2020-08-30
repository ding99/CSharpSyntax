using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomConversions {
	struct Rectangle {
		public int Width { get; set; }
		public int Height { get; set; }

		public Rectangle(int w, int h) : this() {
			Width = w; Height = h;
		}

		public void Draw() {
			for (int i = 0; i < Height; i++)
				for (int j = 0; j < Width; j++)
					Console.Write("*");
			Console.WriteLine();
		}

		public override string ToString() {
			return $"[Width = {Width}; Height = {Height}]";
		}
	}

	struct Square {
		public int Length { get; set; }
		public Square(int l)  : this() { Length = l; }
		public void Draw() {
			for (int i = 0; i < Length; i++)
				for (int j = 0; j < Length; j++)
					Console.Write("*");
			Console.WriteLine();
		}

		public override string ToString() {
			return $"[Length = {Length}]";
		}

		public static explicit operator Square(Rectangle r) {
			return new Square { Length = r.Height };
		}
	}
}

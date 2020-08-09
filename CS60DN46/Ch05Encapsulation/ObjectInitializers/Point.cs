using System;

namespace ObjectInitializers
{
	enum PointColor {  Blue, Red, Gold }
	class Point
	{
		public int X { get; set; }
		public int Y { get; set; }
		public PointColor Color { get; set; }

		public Point(int x, int y) { X = x; Y = y; Color = PointColor.Gold; }
		public Point(PointColor color) { Color = color;  }
		public Point() : this(PointColor.Red) { }

		public void Display()
		{
			Console.WriteLine($"[{X}, {Y}] Color <{Color}>");
		}
	}
}

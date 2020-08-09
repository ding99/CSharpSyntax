using System;

namespace ObjectInitializers
{
	class Point
	{
		public int X { get; set; }
		public int Y { get; set; }

		public Point(int x, int y) { X = x; Y = y; }
		public Point() { }

		public void Display()
		{
			Console.WriteLine($"[{X}, {Y}]");
		}
	}
}

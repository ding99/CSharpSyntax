using System;

namespace CloneablePoint
{
	public class Point2 : ICloneable
	{
		public int X { get; set; }
		public int Y { get; set; }

		public Point2(int x, int y) { X = x; Y = y; }
		public Point2() { }

		public override string ToString()
		{
			return string.Format($"X = {X}; Y = {Y}");
		}

		public object Clone()
		{
			return new Point2(X, Y);
		}
	}
}

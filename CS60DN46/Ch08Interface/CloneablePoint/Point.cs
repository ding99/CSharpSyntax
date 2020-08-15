using System;

namespace CloneablePoint
{
	class Point : ICloneable
	{
		public int X { get; set; }
		public int Y { get; set; }
		
		public Point(int x, int y) { X = x;Y = y; }
		public Point() { }

		public override string ToString()
		{
			return string.Format($"X = {X}; Y = {Y}");
		}

		public object Clone()
		{
			return new Point(X, Y);
		}
	}
}

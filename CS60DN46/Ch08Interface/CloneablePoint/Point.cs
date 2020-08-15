using System;

namespace CloneablePoint
{
	public class Point : ICloneable
	{
		public int X { get; set; }
		public int Y { get; set; }
		public PointDescription desc = new PointDescription();
		
		public Point(int x, int y, string name) {
			X = x; Y = y;
			desc.PetName = name;
		}
		public Point(int x, int y) { X = x; Y = y; }
		public Point() { }

		public override string ToString()
		{
			return string.Format($"X = {X}; Y = {Y}; Name = {desc.PetName}; ID = {desc.PointID}");
		}

		public object Clone()
		{
			return this.MemberwiseClone();
		}
	}
}

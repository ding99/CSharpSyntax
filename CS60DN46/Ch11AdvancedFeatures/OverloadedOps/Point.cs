﻿using System;

namespace OverloadedOps {
	class Point : IComparable<Point> {
		public int X { set; get; }
		public int Y { set; get; }
		public Point(int x, int y) { X = x; Y = y; }
		public override string ToString() { return $"[{X}, {Y}]"; }

		public static Point operator +(Point p1, Point p2) {
			return new Point(p1.X + p2.X, p1.Y + p2.Y);
		}
		public static Point operator -(Point p1, Point p2) {
			return new Point(p1.X - p2.X, p1.Y - p2.Y);
		}
		public static Point operator +(Point p1, int change) {
			return new Point(p1.X + change, p1.Y + change);
		}
		public static Point operator +(int change, Point p1) {
			return new Point(p1.X + change, p1.Y + change);
		}

		public static Point operator ++(Point p1) { return new Point(p1.X + 1, p1.Y + 1); }
		public static Point operator --(Point p1) { return new Point(p1.X - 1, p1.Y - 1); }

		public override bool Equals(object o) { return o.ToString() == this.ToString(); }
		public override int GetHashCode() { return this.ToString().GetHashCode(); }
		public static bool operator ==(Point p1, Point p2) { return p1.Equals(p2); }
		public static bool operator !=(Point p1, Point p2) { return !p1.Equals(p2); }

		public int CompareTo(Point other) {
			if (this.X > other.X && this.Y > other.Y)
				return 1;
			return (this.X < other.X && this.Y < other.Y) ? -1 : 0;
		}
		public static bool operator <(Point p1, Point p2) { return (p1.CompareTo(p2) < 0); }
		public static bool operator >(Point p1, Point p2) { return p1.CompareTo(p2) > 0; }
		public static bool operator <=(Point p1, Point p2) { return (p1.CompareTo(p2) <= 0); }
		public static bool operator >=(Point p1, Point p2) { return p1.CompareTo(p2) >= 0; }
	}
}

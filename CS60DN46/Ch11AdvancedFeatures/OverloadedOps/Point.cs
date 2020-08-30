namespace OverloadedOps {
	class Point {
		public int X { set; get; }
		public int Y { set; get; }
		public Point(int x, int y) { X = x; Y = y; }
		public override string ToString() { return $"[{X}, {Y}]"; }

		public static Point operator + (Point p1, Point p2) {
			return new Point(p1.X + p2.X, p1.Y + p2.Y);
		}
		public static Point operator - (Point p1, Point p2) {
			return new Point(p1.X - p2.X, p1.Y - p2.Y);
		}
		public static Point operator +(Point p1, int change) {
			return new Point(p1.X + change, p1.Y + change);
		}
		public static Point operator +(int change, Point p1) {
			return new Point(p1.X + change, p1.Y + change);
		}

		public static Point operator ++(Point p1) {
			return new Point(p1.X + 1, p1.Y + 1);
		}
		public static Point operator --(Point p1) {
			return new Point(p1.X - 1, p1.Y - 1);
		}
	}
}

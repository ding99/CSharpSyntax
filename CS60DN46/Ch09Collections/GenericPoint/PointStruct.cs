namespace GenericPoint
{
	public struct Point<T>
	{
		private T x, y;

		public Point(T xVal, T yVal) { x = xVal; y = yVal; }
		public T X { get { return x; } set { x = value; } }
		public T Y { get { return y; } set { y = value; } }
		public override string ToString() { return string.Format("[{0}, {1}]", x, y); }
		public void ResetPoint() { x = default(T); y = default(T); }
	}

	public struct Point2<T>
	{
		public Point2(T xVal, T yVal) { X = xVal; Y = yVal; }
		public T X { get; set; }
		public T Y { get; set; }
		public override string ToString() { return string.Format("[{0}, {1}]", X, Y); }
		public void ResetPoint() { X = default(T); Y = default(T); }
	}
}

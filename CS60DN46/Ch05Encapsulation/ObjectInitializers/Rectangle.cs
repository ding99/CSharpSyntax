using System;

namespace ObjectInitializers
{
	class Rectangle
	{
		private Point topLeft = new Point();
		private Point bottomRight = new Point();

		public Point TopLeft {
			get { return topLeft; }
			set { topLeft = value; }
		}
		public Point BottomRight {
			get { return bottomRight; }
			set { bottomRight = value; }
		}

		public void Display() {
			Console.WriteLine($"[TopLeft: {topLeft.X}, {topLeft.Y}, {topLeft.Color}, BottomRight: {bottomRight.X}, {bottomRight.Y}, {bottomRight.Color}]");
		}
	}
}

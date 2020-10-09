using System;

namespace DebugAttribute {
	[DebugInfo(45,"Zara Ali","12/18/2012", Message = "Return tyep mismatch")]
	[DebugInfo(49, "Nuha Ali", "10/10/2012", Message = "Unused variable")]
	class Rectangle {
		protected double length, width;
		public Rectangle(double l, double w) { length = l; width = w; }

		[DebugInfo(55,"Zara Ali","19/10/2013", Message = "Return type mismatch")]
		public double GetArea() { return length * width; }

		[DebugInfo(56, "Zara Ali", "17/10/2013")]
		public void Display() {
			Console.WriteLine($"Length: {length}, Width: {width}, Area: {GetArea()}");
		}
	}
}

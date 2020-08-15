using System;

namespace MIInterfaceHierarchy
{
	class Rectangle : IShape
	{
		public int GetNumberOfSides() { return 4; }
		void IDrawable.Draw() { Console.WriteLine("Drawing Rectanle in IDrawable..."); }
		void IPrintable.Draw() { Console.WriteLine("Drawing Rectanle in IPrintable..."); }
		public void Print() { Console.WriteLine("Printing Rectanle..."); }
	}
}

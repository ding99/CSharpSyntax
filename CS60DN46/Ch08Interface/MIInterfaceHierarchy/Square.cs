using System;

namespace MIInterfaceHierarchy
{
	class Square : IShape
	{
		void IPrintable.Draw() { Console.WriteLine("Drawing Square in IPrintble"); }
		void IDrawable.Draw() { Console.WriteLine("Drawing Square in IDrawable"); }
		public void Print() { Console.WriteLine("Print Square..."); }
		public int GetNumberOfSides() { return 4; }
	}
}

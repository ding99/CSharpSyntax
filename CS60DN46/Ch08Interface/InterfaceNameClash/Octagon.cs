using System;

namespace InterfaceNameClash
{
	class Octagon : IDrawToForm, IDrawToMemory, IDrawToPrinter
	{
		void IDrawToForm.Draw()
		{
			Console.WriteLine("Drawing the Octagon to form...");
		}
		void IDrawToMemory.Draw()
		{
			Console.WriteLine("Drawing the Octagon to memory...");
		}
		void IDrawToPrinter.Draw()
		{
			Console.WriteLine("Drawing the Octagon to printer...");
		}
	}
}

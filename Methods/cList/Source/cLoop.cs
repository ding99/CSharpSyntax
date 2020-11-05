using System;

namespace CList {
	public class CLoop
	{
		public void LoopStart()
		{
			Console.WriteLine("-- Loop");
			for (int i = 2; i < 2; i++)
				Console.WriteLine("  " + i);
			Console.WriteLine("-- End");
		}
	}
}

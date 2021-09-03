using System;

namespace IntPtr {
	class Program {
		static void Main() {
			Console.WriteLine("== Start");

			new Invoke().Start();

			Console.ResetColor();

			Console.WriteLine("== End");
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace List {
	class First {
		public void Start() {
			Console.ForegroundColor = ConsoleColor.Cyan;

			Console.WriteLine("-- First");

			LinkedList<string> fs = new LinkedList<string>();
			int upper = 10;
			for (int i = 0; i < upper; i++)
				fs.AddLast("Term " + i);

			Console.Write($"Original (size {fs.Count}):");
			foreach (var f in fs) Console.Write(" <" + f + ">");
			Console.WriteLine();

			for(int i = 0; i < 5; i++) {
				Console.WriteLine("** " + fs.First());
				fs.RemoveFirst();
			}

			Console.Write($"After removed (size {fs.Count}):");
			foreach (var f in fs) Console.Write(" <" + f + ">");
			Console.WriteLine();
		}
	}
}

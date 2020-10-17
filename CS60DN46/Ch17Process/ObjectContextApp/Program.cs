using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectContextApp {
	class Program {
		static void Main() {
			Console.WriteLine("***** Inspecting an Object's Context *****");
			Console.ResetColor();
		}

		private static void ObjectContext() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Object Context");
		}
	}
}

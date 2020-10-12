using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DynamicKeyword {
	class Program {
		static void Main() {
			Console.WriteLine("***** Dynamic Keyword *****");
			ImplicitlyTypeVariable();
			Console.ResetColor();
		}

		private static void ImplicitlyTypeVariable() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Implicitly Type Variable");

			var a = new List<int>();
			a.Add(90);
			//This would be a compile-time error!
			//a = "Hello";
		}
	}
}

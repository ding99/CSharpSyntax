using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CStrings {
	public class Equaling {
		public Equaling() {
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine("-- Compare == with Equals()");
			Console.WriteLine("   == :     to compare references");
			Console.WriteLine("   Equals : to compare contents");
		}

		public void CompareString() {
			string a = "Word1", b = "Word1", c = a;
			Console.WriteLine($"a[{a}], b[{b}],c[{c}](ref a)");
			Console.WriteLine($"a==b[{a == b}], a-quals-b[{a.Equals(b)}]");
			Console.WriteLine($"a==c[{a == c}], a-quals-c[{a.Equals(c)}]");
			Console.WriteLine($"b==c[{b == c}], b-quals-c[{b.Equals(c)}]");
		}
	}
}

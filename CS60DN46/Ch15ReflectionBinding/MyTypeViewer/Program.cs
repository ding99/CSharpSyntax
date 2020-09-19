using System;
using System.Linq;
using System.Reflection;

namespace MyTypeViewer {
	class Program {
		static void Main() {
			Console.WriteLine("***** Custom Metadata Viewer *****");
			Console.ResetColor();
		}

		static void ListMethods(Type t) {
			Console.WriteLine("=> Methods");
			var methodNames = from n in t.GetMethods() select n.Name;
			foreach(var name in methodNames)
				Console.WriteLine($"-> {name}");
			Console.WriteLine();
		}
	}
}

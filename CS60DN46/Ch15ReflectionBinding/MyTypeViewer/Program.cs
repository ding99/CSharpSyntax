using System;
using System.Linq;
using System.Reflection;

namespace MyTypeViewer {
	class Program {
		static void Main() {
			Console.WriteLine("***** Custom Metadata Viewer *****");
//			ListMethods();
			Console.ResetColor();
		}

		static void ListMethods(Type t) {
			Console.WriteLine("=> Methods");
			
			MethodInfo[] mi = t.GetMethods();
			foreach(MethodInfo m in mi)
				Console.Write($" {m.Name}");
			Console.WriteLine();

			var methodNames = from n in t.GetMethods() select n.Name;
			foreach(var name in methodNames)
				Console.WriteLine($" {name}");
			Console.WriteLine();
		}

		static void ListFields(Type t) {
			Console.WriteLine("=> Fields");

			var fieldNames = from n in t.GetFields() select n.Name;
			foreach (var name in fieldNames)
				Console.WriteLine($" {name}");
			Console.WriteLine();
		}

		static void ListProps(Type t) {
			Console.WriteLine("=> Properties");

			var propNames = from n in t.GetProperties() select n.Name;
			foreach (var name in propNames)
				Console.WriteLine($" {name}");
			Console.WriteLine();
		}

		static void ListInterfaces(Type t) {
			Console.WriteLine("=> Interfaces");

			var ifaces = from n in t.GetProperties() select n.Name;
			foreach (var name in ifaces)
				Console.WriteLine($" {name}");
			Console.WriteLine();
		}
	}
}


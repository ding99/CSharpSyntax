using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MyTypeViewer {
	class Program {
		static void Main() {
			Console.WriteLine("***** Custom Metadata Viewer *****");
			MyType();
			Console.ResetColor();
		}

		static void MyType() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			String typeName;

			do {
				Console.WriteLine("Enter a type name to avaluate");
				Console.Write("or enter Q to quit:");
				typeName = Console.ReadLine();

				if (typeName.Length < 1) continue;
				if (typeName.ToUpper().Equals("Q")) break;

				try {
					Type t = Type.GetType(typeName);
					ListStats(t);
					ListFields(t);
					ListProps(t);
					ListMethods(t);
					ListInterfaces(t);
				}
				catch(Exception e) {
					Console.WriteLine($"Sorry, can't find type. {e.Message}");
				}

			} while (true);
		}

		public static void ListMethods(Type t) {
			Console.WriteLine("=> Methods");
			
			MethodInfo[] mi = t.GetMethods();
			foreach (MethodInfo m in mi) {
				StringBuilder b = new StringBuilder("(");
				foreach (ParameterInfo p in m.GetParameters())
					b.Append(b.Length < 2 ? "":",").Append($"{p.ParameterType}");
				Console.Write($" <{m.ReturnType.FullName} {m.Name}{b.Append(")")}>");
			}
			Console.WriteLine();

			var names = from n in t.GetMethods() select n;
			foreach (var n in names)
				Console.Write($" <{n}>");
			Console.WriteLine();
		}

		static void ListFields(Type t) {
			Console.WriteLine("=> Fields");

			var fieldNames = from n in t.GetFields() select n.Name;
			foreach (var name in fieldNames)
				Console.Write($" <{name}>");
			Console.WriteLine();
		}

		static void ListProps(Type t) {
			Console.WriteLine("=> Properties");

			var propNames = from n in t.GetProperties() select n.Name;
			foreach (var name in propNames)
				Console.Write($" <{name}>");
			Console.WriteLine();
		}

		static void ListInterfaces(Type t) {
			Console.WriteLine("=> Interfaces");

			var ifaces = from n in t.GetInterfaces() select n;
			foreach (Type i in ifaces)
				Console.Write($" <{i.Name}>");
			Console.WriteLine();
		}

		static void ListStats(Type t) {
			Console.WriteLine("=> Various Statistics");
			Console.WriteLine($"Base class: {t.BaseType}");
			Console.WriteLine($"Is type abstract: {t.IsAbstract}");
			Console.WriteLine($"Is type sealed  : {t.IsSealed}");
			Console.WriteLine($"Is type generic : {t.IsGenericTypeDefinition}");
			Console.WriteLine($"Is type a class type: {t.IsClass}");
		}
	}
}


using System;
using System.Reflection;

namespace DebugAttribute {
	class Program {
		static void Main() {
			Console.WriteLine("== Use Attributes");
			Rectangle r = new Rectangle(4.5, 7.5);
			r.Display();
			Type type = typeof(Rectangle);

			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("-- Class attributes");
			foreach (Object attribute in type.GetCustomAttributes(false)) {
				DebugInfoAttribute dbi = attribute as DebugInfoAttribute;
				if(dbi != null)
					Console.WriteLine($"Bug no {dbi.BugNo}, Developer {dbi.Developer}, Last Review {dbi.LastReview}, Remarks <{dbi.Message}>");
			}

			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("-- Method attributes");
			foreach(MethodInfo m in type.GetMethods())
				foreach(Attribute a in m.GetCustomAttributes(true)) {
					DebugInfoAttribute dbi = a as DebugInfoAttribute;
					if(dbi != null)
						Console.WriteLine($"Method <{m.Name}>: Bug no {dbi.BugNo}, Developer {dbi.Developer}, Last Review {dbi.LastReview}, Remarks <{dbi.Message}>");
				}

			Console.ResetColor();
		}
	}
}

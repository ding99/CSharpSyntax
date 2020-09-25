using System;
using System.IO;
using System.Reflection;

namespace LateBindingApp {
	class Program {
		static void Main() {
			Console.WriteLine("***** Late Binding *****");
			LateBind();
			Console.ResetColor();
		}

		static void LateBind() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Assembly a = null;
			try {
				a = Assembly.Load("CarLibrary");
			} catch(FileNotFoundException e) {
				Console.WriteLine(e.Message);
				return;
			}
			if (a != null)
				CreateUsingLateBinding(a);
		}

		static void CreateUsingLateBinding(Assembly asm) {
			try {
				Type miniVan = asm.GetType("CarLibrary.MiniVan");
				object obj = Activator.CreateInstance(miniVan);
				Console.WriteLine($"Created a <{obj}> using late binding");
			} catch(Exception e) {
				Console.WriteLine(e.Message);
			}
		}
	}
}

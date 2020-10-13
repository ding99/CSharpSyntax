using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace LateBindingWithDynamic {
	class Program {
		static void Main() {
			Console.WriteLine("***** Late Binding with Dynamic *****");
			AddWithReflection();
			AddWithDynamic();
			Console.ResetColor();
		}

		private static void AddWithDynamic() {
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=> Add with Dynamic");

			string assemblyName = "MathLibrary";
			string className = "MathLibrary.SimpleMath";

			Assembly asm = Assembly.Load(assemblyName);

			try {
				//get metadata for SimpleMath type
				Type math = asm.GetType(className);
				//create a SimpleMath on the fly
				dynamic obj = Activator.CreateInstance(math);

				//note how easily we can now call Add();
				Console.WriteLine($"Result is {obj.Add(20, 50)}");
			}
			catch (Exception e) { Console.WriteLine(e.Message); }
		}

		private static void AddWithReflection() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Add with Reflection");

			string assemblyName = "MathLibrary";
			string className = "MathLibrary.SimpleMath";
			string methodName = "Add";

			Assembly asm = Assembly.Load(assemblyName);

			try {
				//get metadata for SimpleMath type
				Type math = asm.GetType(className);
				//create a SimpleMath on the fly
				object obj = Activator.CreateInstance(math);

				//get info for add
				MethodInfo mi = math.GetMethod(methodName);
				//invoke method (with parameters)
				object[] args = {10, 70};
				Console.WriteLine($"Result is {mi.Invoke(obj, args)}");
			}
			catch (Exception e) { Console.WriteLine(e.Message); }
		}
	}
}

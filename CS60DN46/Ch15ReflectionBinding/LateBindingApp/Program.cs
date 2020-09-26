using System;
using System.IO;
using System.Reflection;

namespace LateBindingApp {
	class Program {
		static void Main() {
			Console.WriteLine("***** Late Binding *****");
			LateBind();
			LateBindParams();
			Console.ResetColor();
		}

		static void LateBindParams() {
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("Invoke <TurboOnRadio> method with 2 parameters");

			Assembly a = null;
			try {
				a = Assembly.Load("CarLibrary");
			}
			catch (FileNotFoundException e) {
				Console.WriteLine(e.Message);
				return;
			}
			if (a != null)
				InvokeMethodWithArgs(a);
		}

		static void InvokeMethodWithArgs(Assembly asm) {
			try {
				Type sport = asm.GetType("CarLibrary.SportsCar");
				object obj = Activator.CreateInstance(sport);
				MethodInfo mi = sport.GetMethod("TurnOnRadio");
				mi.Invoke(obj, new object[] { true, 2 });
			} catch(Exception e) {
				Console.WriteLine(e.Message);
			}
		}

		static void LateBind() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Invoke <TurboBoost> method without parameters");

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

				MethodInfo mi = miniVan.GetMethod("TurboBoost");
				mi.Invoke(obj, null); //Invoke method for no parameters
			} catch(Exception e) {
				Console.WriteLine(e.Message);
			}
		}
	}
}

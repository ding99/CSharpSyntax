using System;
using System.Reflection;
using System.Collections.Generic;

namespace DynamicKeyword {
	class Program {
		static void Main() {
			Console.WriteLine("***** Dynamic Keyword *****");
			ImplicitlyTypeVariable();
			ThreeWays();
			Binder();
			LateBound();
			Console.ResetColor();
		}

		private static void LateBound() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Late Bound");

			Assembly a = null;
			try {
				a = Assembly.Load("CarLibrary");  //chapter 14
				Console.WriteLine($"Assembly FullName <{a.FullName}>");
				Console.WriteLine($"Assembly Type <{a.GetType().FullName}>");
			} catch(Exception e) {
				Console.WriteLine(e.Message);
				return;
			}

			if (a != null)
				CreateUsingLateBinding(a);
		}

		private static void CreateUsingLateBinding(Assembly asm) {
			try {
				//get metadata for the Minivan type
				Type miniVan = asm.GetType("CarLibrary.MiniVan");
				Console.WriteLine($"mimiVan type name <{miniVan.FullName}>");
				//create the minivan on the fly
				object obj = Activator.CreateInstance(miniVan);
				//get info for TurboBoost
				MethodInfo mi = miniVan.GetMethod("TurboBoost");
				Console.WriteLine($"Method name <{mi.Name}>");
				//Invoke method ("null" for no parameters)
				mi.Invoke(obj, null);
			} catch(Exception e) {
				Console.WriteLine(e.Message);
			}
		}

		private static void Binder() {
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("=>Examining Runtime Binder Exception");

			dynamic td = "Hello";

			try {
				Console.WriteLine(td.ToUpper());
				Console.WriteLine(td.toupper());
				Console.WriteLine(td.Foo(10, "ee", DateTime.Now));
			}
			catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException e) {
				Console.WriteLine(e.Message);
			}
			catch(Exception e) {
				Console.WriteLine(e.Message);
			}
		}

		private static void ThreeWays() {
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=> Three ways to define data whose underlying tpe is not directly indicated");

			var s1 = "Way01";
			object s2 = "Way02";
			dynamic s3 = "Way03";

			Console.WriteLine($"s1 is of type: {s1.GetType()}");
			Console.WriteLine($"s2 is of type: {s2.GetType()}");
			Console.WriteLine($"s3 is of type: {s3.GetType()}");

			Console.ForegroundColor = ConsoleColor.DarkYellow;
			s2 = true;
			s3 = new List<int>();
			Console.WriteLine($"s1 is of type: {s1.GetType()}");
			Console.WriteLine($"s2 is of type: {s2.GetType()}");
			Console.WriteLine($"s3 is of type: {s3.GetType()}");

			Console.ForegroundColor = ConsoleColor.DarkCyan;
			s2 = new long[5];
			s3 = 25;
			Console.WriteLine($"s1 is of type: {s1.GetType()}");
			Console.WriteLine($"s2 is of type: {s2.GetType()}");
			Console.WriteLine($"s3 is of type: {s3.GetType()}");
		}

		private static void ImplicitlyTypeVariable() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Implicitly Type Variable");

			var a = new List<int>();
			a.Add(90);
			//This would be a compile-time error!
			//a = "Hello";

			Console.Write($"List (size {a.Count}):");
			foreach (var v in a) Console.Write(" " + v);
			Console.WriteLine();
		}
	}
}

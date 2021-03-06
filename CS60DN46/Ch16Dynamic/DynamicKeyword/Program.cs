﻿using System;
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

			Assembly a;
			string dllName = "CarLibrary";
			try {
				a = Assembly.Load(dllName);  //chapter 14
				Console.WriteLine($"Assembly FullName <{a.FullName}>");
				Console.WriteLine($"Assembly Type <{a.GetType().FullName}>");
			} catch(Exception e) {
				Console.WriteLine(e.Message);
				return;
			}

			if (a != null) {
				CreateUsingLateBinding(a);
				InvokeMethodWithDynamicKeyword(a);
			}
		}

		private static void InvokeMethodWithDynamicKeyword(Assembly asm) {
			Console.WriteLine("-> Using Dynamic");
			string className = "CarLibrary.MiniVan";
			try {
				//get metadata for the Minivan type
				Type miniVan = asm.GetType(className);
				Console.WriteLine($"Class(Type) <{miniVan.FullName}>");
				//create the minivan on the fly and call method
				dynamic obj = Activator.CreateInstance(miniVan);
				Console.WriteLine($"Invoke TurboBoost using Activitor.CreateInstance()");
				obj.TurboBoost();
				Console.WriteLine("-- Invoked");
			}
			catch (Exception e) { Console.WriteLine(e.Message); }

		}

		private static void CreateUsingLateBinding(Assembly asm) {
			Console.WriteLine("-> Not using Dynamic");
			string className = "CarLibrary.MiniVan", methodName = "TurboBoost";
			try {
				//get metadata for the Minivan type
				Type miniVan = asm.GetType(className);
				Console.WriteLine($"Class(Type) <{miniVan.FullName}>");
				//create the minivan on the fly
				object obj = Activator.CreateInstance(miniVan);
				//get info for TurboBoost
				MethodInfo mi = miniVan.GetMethod(methodName);
				Console.WriteLine($"Method <{mi.Name}>");
				//Invoke method ("null" for no parameters)
				mi.Invoke(obj, null);
			} catch(Exception e) { Console.WriteLine(e.Message); }
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

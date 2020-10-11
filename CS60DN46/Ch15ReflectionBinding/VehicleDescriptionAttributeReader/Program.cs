using AttributedCarLibrary;
using System;

namespace VehicleDescriptionAttributeReader {
	class Program {
		static void Main() {
			Console.WriteLine("***** Value of Vehicle Description Attribute *****");
			ReflectOnAttributesUsingEarlyBinding();
			Console.ResetColor();
		}

		private static void ReflectOnAttributesUsingEarlyBinding() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Reflect on Attributes Using Early Binding");

			Type t = typeof(Winnebago);
			object[] attrs = t.GetCustomAttributes(false);
			foreach (var v in attrs) {
				VehicleDescriptionAttribute a = v as VehicleDescriptionAttribute;
				if(a != null)
					Console.WriteLine($"-> Description <{a.Description}>");
				else Console.WriteLine("-> Not a VehicleDescriptionAttribute");
			}
			//foreach (VehicleDescriptionAttribute v in attrs)
			//	Console.WriteLine($"-> {v.Description}");
		}
	}
}

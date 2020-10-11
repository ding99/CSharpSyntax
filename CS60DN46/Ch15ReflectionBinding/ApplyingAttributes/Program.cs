using AttributedCarLibrary;
using System;
using System.Reflection;

namespace ApplyingAttributes {
	class Program {
		static void Main() {
			Console.WriteLine("***** Applying Attributes *****");
			ApplyAttributes();
			Console.ResetColor();
		}

		static void ApplyAttributes() {
			Console.WriteLine("=> Apply Attributes to classes");

			Console.WriteLine($"-> class attributes");

			Console.ForegroundColor = ConsoleColor.Yellow;
			Motorcycle motor = new Motorcycle();
			Type type = typeof(Motorcycle);
			Console.WriteLine($"-- Class <{type.Name}>:");
			Console.WriteLine($"The class is serializable <{type.IsSerializable}>");
			foreach (var attr in type.GetCustomAttributes(true)) {
				VehicleDescriptionAttribute v = attr as VehicleDescriptionAttribute;
				if (v != null)
					Console.WriteLine($"Description <{v.Description}>");
			}

			Console.ForegroundColor = ConsoleColor.Cyan;
			HorseAndBuggy mule = new HorseAndBuggy(); //obsolete attribute
			type = typeof(HorseAndBuggy);
			Console.WriteLine($"-- Class <{type.Name}>:");
			Console.WriteLine($"The class is serializable <{type.IsSerializable}>");
			foreach (var attr in type.GetCustomAttributes(true)) {
				VehicleDescriptionAttribute v = attr as VehicleDescriptionAttribute;
				if (v != null)
					Console.WriteLine($"Description <{v.Description}>");
			}

			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Winnebago wb = new Winnebago();
			type = typeof(Winnebago);
			Console.WriteLine($"-- Class <{type.Name}>:");
			Console.WriteLine($"The class is serializable <{type.IsSerializable}>");
			foreach (var attr in type.GetCustomAttributes(true)) {
				VehicleDescriptionAttribute v = attr as VehicleDescriptionAttribute;
				if (v != null)
					Console.WriteLine($"Description <{v.Description}>");
			}

			Console.WriteLine($"-> method attributes");
			foreach (var m in type.GetMethods())
				foreach(var a in m.GetCustomAttributes(true)) {
				VehicleDescriptionAttribute v = a as VehicleDescriptionAttribute;
				if (v != null)
					Console.WriteLine($"Method <{m.Name}>: Description <{v.Description}>");
				}
		}
	}
}

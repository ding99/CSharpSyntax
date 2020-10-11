using AttributedCarLibrary;
using System;

namespace ApplyingAttributes {
	class Program {
		static void Main() {
			Console.WriteLine("***** Applying Attributes *****");
			ApplyAttributes();
			Console.ResetColor();
		}

		static void ApplyAttributes() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Apply Attributes to classes");

			Console.WriteLine($"-> class attributes");

			Motorcycle motor = new Motorcycle();
			Type type = typeof(Motorcycle);
			foreach(var attr in type.GetCustomAttributes(true)) {
				VehicleDescriptionAttribute v = attr as VehicleDescriptionAttribute;
				if (v != null)
					Console.WriteLine($"Class <{type.Name}>, Description <{v.Description}>");
			}
			
			HorseAndBuggy mule = new HorseAndBuggy();
			type = typeof(HorseAndBuggy);
			foreach (var attr in type.GetCustomAttributes(true)) {
				VehicleDescriptionAttribute v = attr as VehicleDescriptionAttribute;
				if (v != null)
					Console.WriteLine($"Class <{type.Name}>, Description <{v.Description}>");
			}

			Winnebago wb = new Winnebago();
			type = typeof(Winnebago);
			foreach (var attr in type.GetCustomAttributes(true)) {
				VehicleDescriptionAttribute v = attr as VehicleDescriptionAttribute;
				if (v != null)
					Console.WriteLine($"Class <{type.Name}>, Description <{v.Description}>");
			}

			Console.WriteLine($"-> method attributes");
			foreach (var m in type.GetMethods())
				foreach(var a in m.GetCustomAttributes(true)) {
				VehicleDescriptionAttribute v = a as VehicleDescriptionAttribute;
				if (v != null)
					Console.WriteLine($"Class <{type.Name}>, Method <{m.Name}>, Description <{v.Description}>");
				}
		}
	}
}

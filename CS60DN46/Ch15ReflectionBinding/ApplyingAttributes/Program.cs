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
			Console.WriteLine("=> Apply Attributes to classes");
			CheckAttributes(typeof(Motorcycle), ConsoleColor.Yellow);
			CheckAttributes(typeof(HorseAndBuggy), ConsoleColor.Cyan);
			CheckAttributes(typeof(Winnebago), ConsoleColor.DarkYellow);
		}

		static void CheckAttributes(Type type, ConsoleColor color) {
			Console.ForegroundColor = color;
			Console.WriteLine($"-> Class <{type.Name}>, serializable <{type.IsSerializable}>");

			Console.WriteLine($"Class attributes:");
			foreach (var attr in type.GetCustomAttributes(true)) {
				VehicleDescriptionAttribute v = attr as VehicleDescriptionAttribute;
				if (v != null)
					Console.WriteLine($"  Description <{v.Description}>");
				ObsoleteAttribute o = attr as ObsoleteAttribute;
				if (o != null)
					Console.WriteLine($"  Obsolete attribute message <{o.Message}>, is error <{o.IsError}>");
				SerializableAttribute s = attr as SerializableAttribute;
				if (s != null)
					Console.WriteLine($"  Serializable default <{s.IsDefaultAttribute()}>");
			}

			Console.WriteLine($"Method attributes:");
			foreach (var m in type.GetMethods())
				foreach (var a in m.GetCustomAttributes(true)) {
					VehicleDescriptionAttribute v = a as VehicleDescriptionAttribute;
					if (v != null)
						Console.WriteLine($"  Method <{m.Name}>: Description <{v.Description}>");
				}
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;

namespace VehicleDescriptionAttributeReaderLateBinding {
	class Program {
		static void Main() {
			Console.WriteLine("***** Value of Vehicle Description Attribute *****");
			ReflectAttributesUsingLateBinding();
			Console.ResetColor();
		}

		private static void ReflectAttributesUsingLateBinding() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Reflect Attributes Using Late Binding");

			try {
				Assembly asm = Assembly.Load("AttributedCarLibrary");
				Type vehicleDesc = asm.GetType("AttributedCarLibrary.VehicleDescriptionAttribute");

				PropertyInfo propDesc = vehicleDesc.GetProperty("Description");

				Type[] types = asm.GetTypes();

				foreach(Type t in types) {
					object[] objs = t.GetCustomAttributes(vehicleDesc, false);
					foreach(object o in objs)
						Console.WriteLine($"-> {t.Name}: {propDesc.GetValue(o, null)}");
				}
			}
			catch(Exception e) {
				Console.WriteLine(e.Message);
			}
		}
	}
}

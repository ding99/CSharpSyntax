using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CEnum {
	public class Default {

		enum CapMode {
			Subtitle = 0,
			CEA_608 = 1,
			Teletext = 2,

			Custom = 99,
			Default = Subtitle
		}

		public Default() {
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("--- default");
		}

		public void List() {
			Console.Write("Names :");
			foreach(var c in Enum.GetNames(typeof(CapMode)))
				Console.Write($" [{c}]");
			Console.WriteLine();
			Console.Write("Values:");
			foreach (var c in Enum.GetValues(typeof(CapMode)))
				Console.Write($" [{(int)c}]");
			Console.WriteLine();
		}
	}
}

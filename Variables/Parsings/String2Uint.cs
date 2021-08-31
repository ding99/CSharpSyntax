using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsings {
	public class String2Uint {
		public String2Uint() { Console.ForegroundColor = ConsoleColor.Cyan; }

		public void Start() {
			Parsing("ffml");
			Parsing("scc ");
		}

		private void Parsing(string source) {
			uint target1 = ((uint)source[0] << 24) + ((uint)source[1] << 16) + ((uint)source[2] << 8) + source[3];

			Console.WriteLine($"source [{source}], target1 [{target1}]");
		}
	}
}

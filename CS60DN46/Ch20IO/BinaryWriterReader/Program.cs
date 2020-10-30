using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BinaryWriterReader {
	class Program {
		static void Main() {
			Console.WriteLine("***** BinaryWriter / BinaryReader *****");
			WriteRead();
			Console.ResetColor();
		}

		private static void WriteRead() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=>");
		}
	}
}

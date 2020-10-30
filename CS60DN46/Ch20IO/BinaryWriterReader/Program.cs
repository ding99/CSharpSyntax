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
			Writing();
			Console.ResetColor();
		}

		private static void Writing() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			string path = @"E:\workFolder\cs60\ch20\files\binfile.dat";

			Console.WriteLine($"=> BinaryWrite ({path})");

			FileInfo f = new FileInfo(path);
			using(BinaryWriter writer = new BinaryWriter(f.OpenWrite())) {
				Console.WriteLine($"Base stream is: <{writer.BaseStream}>");

				double aDouble = 1234.67;
				int anInt = 34567;
				string aString = "A, B, C";
				Console.WriteLine($"variables: {aDouble}, {anInt}, {aString}");

				writer.Write(aDouble);
				writer.Write(anInt);
				writer.Write(aString);
			}

			Console.WriteLine("Done");
		}
	}
}

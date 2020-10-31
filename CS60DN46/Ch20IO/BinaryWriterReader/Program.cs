using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.Eventing.Reader;

namespace BinaryWriterReader {
	class Program {
		static void Main() {
			Console.WriteLine("***** BinaryWriter / BinaryReader *****");
			string path = @"E:\workFolder\cs60\ch20\files\binfile.dat";
			Writing(path);
			Reading(path);
			Console.ResetColor();
		}

		private static void Reading(string path) {
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine($"=> BinaryReader from ({path})");

			FileInfo f = new FileInfo(path);
			using (BinaryReader r = new BinaryReader(f.OpenRead())) {
				Console.WriteLine($"Base stream is: <{r.BaseStream}>");
				Console.WriteLine($"Read: <{r.ReadDouble()}> <{r.ReadInt32()}> <{r.ReadString()}>");
			}
		}

		private static void Writing(string path) {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine($"=> BinaryWrite to ({path})");

			FileInfo f = new FileInfo(path);
			using(BinaryWriter writer = new BinaryWriter(f.OpenWrite())) {
				Console.WriteLine($"Base stream is: <{writer.BaseStream}>");

				double aDouble = 1234.67;
				int anInt = 34567;
				string aString = "A, B, C";
				Console.WriteLine($"variables: <{aDouble}> <{anInt}> <{aString}>");

				writer.Write(aDouble);
				writer.Write(anInt);
				writer.Write(aString);
			}
		}
	}
}

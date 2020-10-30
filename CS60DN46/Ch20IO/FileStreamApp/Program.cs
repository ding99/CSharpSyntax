using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileStreamApp {
	class Program {
		static void Main() {
			Console.WriteLine("***** Working with FileStream *****");
			WriteSample();
			Console.ResetColor();
		}

		private static void WriteSample() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			string path = @"E:\workFolder\cs60\ch20\files\StreamWriting.txt";

			using(FileStream fs = File.Open(path, FileMode.Create)) {
				string msg = "Hello!";
				byte[] msgAsByteArray = Encoding.Default.GetBytes(msg);
				fs.Write(msgAsByteArray, 0, msgAsByteArray.Length);
				fs.Position = 0;

				Console.Write("Message as an array of bytes:");
				byte[] bytesFromFile = new byte[msgAsByteArray.Length];
				for(int i = 0; i < msgAsByteArray.Length; i++) {
					bytesFromFile[i] = (byte)fs.ReadByte();
					Console.Write(" " + bytesFromFile[i].ToString("X"));
				}
				Console.WriteLine();
				Console.Write("Decoded Messagse: ");
				Console.WriteLine(Encoding.Default.GetString(bytesFromFile));
			}
		}
	}
}

using System;
using System.IO;
using System.Text;

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
				fs.WriteByte(msgAsByteArray[0]);
				fs.WriteByte(msgAsByteArray[0]);
				fs.Position = 0;

				Console.Write("Message as an array of bytes:");
				byte[] bytesFromFile = new byte[msgAsByteArray.Length + 2];
				for(int i = 0; i < bytesFromFile.Length; i++) {
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

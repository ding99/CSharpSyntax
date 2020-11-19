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
			Console.WriteLine($"file <{path}>");

			using(FileStream fs = File.Open(path, FileMode.Create)) {
				string msg = "Hello!";
				Console.WriteLine($"msg <{msg}>, length {msg.Length}");
				byte[] msgAsByteArray = Encoding.Default.GetBytes(msg);
				Console.WriteLine($"byte[] size {msgAsByteArray.Length}");
				Console.WriteLine($"filestream size (before write) {fs.Length}");
				fs.Write(msgAsByteArray, 0, msgAsByteArray.Length);
				Console.WriteLine($"filestream size (after write) {fs.Length}");
				fs.WriteByte(msgAsByteArray[0]);
				fs.WriteByte(msgAsByteArray[0]);
				Console.WriteLine($"filestream size (after writebyte) {fs.Length}");
				fs.Position = 0;

				Console.Write("Message as an array of bytes:");
				byte[] bytesFromFile = new byte[msgAsByteArray.Length + 2];
				Console.WriteLine($"byte[] size {bytesFromFile.Length}.");
				for (int i = 0; i < bytesFromFile.Length; i++) {
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

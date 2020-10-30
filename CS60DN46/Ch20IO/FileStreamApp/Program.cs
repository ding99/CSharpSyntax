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
		}
	}
}

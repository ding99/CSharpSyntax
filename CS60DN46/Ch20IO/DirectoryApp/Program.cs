using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectoryApp {
	class Program {
		static void Main() {
			Console.WriteLine("***** Fun with Directory(Info) *****");
			string path = @"E:\workFolder\cs60\ch20\mouse";
			ShowWindowsDirectoryInfo(path);
			EnumerateFiles(path);
			Console.ResetColor();
		}

		private static void ShowWindowsDirectoryInfo(string path) {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine($"=> Directory Info : <{path}>");

			DirectoryInfo dir = new DirectoryInfo(path);
			Console.WriteLine($"FullName  : {dir.FullName}");
			Console.WriteLine($"Name      : {dir.Name}");
			Console.WriteLine($"Parent    : {dir.Parent}");
			Console.WriteLine($"Root      : {dir.Root}");
			Console.WriteLine($"Creation  : {dir.CreationTime}");
			Console.WriteLine($"Attributes: {dir.Attributes}");
		}

		private static void EnumerateFiles(string path) {
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine($"=> Enumerating Files with the DirectoryInfo Type : {path}");

			DirectoryInfo dir = new DirectoryInfo(path);
			FileInfo[] jpgs = dir.GetFiles("*.jpg", SearchOption.AllDirectories);

			foreach(FileInfo f in jpgs)
				Console.WriteLine($"File {f.FullName}, Size {f.Length}, Creation {f.CreationTime}, Attributes {f.Attributes}");
		}
	}
}

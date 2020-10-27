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
			ShowWindowsDirectoryInfo();
			Console.ResetColor();
		}

		private static void ShowWindowsDirectoryInfo() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			string path = @"E:\workFolder\cs60\ch20\mouse";
			Console.WriteLine($"=> Directory Info : <{path}>");

			DirectoryInfo dir = new DirectoryInfo(path);
			Console.WriteLine($"FullName  : {dir.FullName}");
			Console.WriteLine($"Name      : {dir.Name}");
			Console.WriteLine($"Parent    : {dir.Parent}");
			Console.WriteLine($"Root      : {dir.Root}");
			Console.WriteLine($"Creation  : {dir.CreationTime}");
			Console.WriteLine($"Attributes: {dir.Attributes}");
		}
	}
}

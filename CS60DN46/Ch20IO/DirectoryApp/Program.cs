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
			CreateSubDir(path);
			Console.ResetColor();
		}

		private static void CreateSubDir(string path) {
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			string sub1 = "Sub01", sub2 =@"Sub02\Data\Images";
			string new1 = Path.Combine(new string[] { path, sub1 });
			string new2 = Path.Combine(new string[] { path, sub2.Split('\\')[0] });
			string new3 = Path.Combine(new string[] { path, sub2 });

			Console.WriteLine($"<{new1}> existing: {Directory.Exists(new1)}");
			Console.WriteLine($"<{new2}> existing: {Directory.Exists(new2)}");
			Console.WriteLine($"<{new3}> existing: {Directory.Exists(new3)}");

			Console.WriteLine($"Create sub directory <{sub1}> and <{sub2}> in <{path}>");
			DirectoryInfo dir = new DirectoryInfo(path);
			dir.CreateSubdirectory(sub1);
			dir.CreateSubdirectory(sub2);

			Console.WriteLine($"<{new1}> existing: {Directory.Exists(new1)}");
			Console.WriteLine($"<{new2}> existing: {Directory.Exists(new2)}");
			Console.WriteLine($"<{new3}> existing: {Directory.Exists(new3)}");
		}

		private static void EnumerateFiles(string path) {
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine($"=> Enumerating Files with the DirectoryInfo Type : {path}");

			DirectoryInfo dir = new DirectoryInfo(path);
			FileInfo[] jpgs = dir.GetFiles("*.jpg", SearchOption.AllDirectories);

			foreach (FileInfo f in jpgs)
				Console.WriteLine($"File {f.FullName}, Size {f.Length}, Creation {f.CreationTime}, Attributes {f.Attributes}");
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
	}
}

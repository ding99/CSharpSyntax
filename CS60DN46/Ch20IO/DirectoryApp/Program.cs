using System;
using System.IO;
using System.Linq;

namespace DirectoryApp {
	class Program {
		static void Main() {
			Console.WriteLine("***** Fun with Directory(Info) *****");
			string path = @"E:\workFolder\cs60\ch20\mouse";
			ShowWindowsDirectoryInfo(path);
			EnumerateFiles(path);
			CreateSubDir(path);
			DirectoryType(path);
			DriveInfos();

			string file = @"E:\workFolder\cs60\ch20\files\cfileinfo.txt";
			FileInfos(file);
			file = @"E:\workFolder\cs60\ch20\files\cfiletype.txt";
			FileType(file);
			Console.ResetColor();
		}

		private static void FileType(string file) {
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("=> File Type");

			using (FileStream fs = File.Create(file)) {
				fs.WriteByte(0x31);
				fs.WriteByte(0x32);
				fs.WriteByte(0x33);
				Console.WriteLine($"filestream size {fs.Length}");
			}

			using (FileStream fs = File.Open(file, FileMode.Append, FileAccess.Write, FileShare.None)) {
				fs.WriteByte(0x41);
				fs.WriteByte(0x42);
				fs.WriteByte(0x43);
				Console.WriteLine($"filestream size {fs.Length}");
			}

			using (FileStream fs = File.OpenWrite(file)) {
				fs.WriteByte(0x61);
				fs.WriteByte(0x62);
				fs.WriteByte(0x63);
				Console.WriteLine($"filestream size {fs.Length}");
			}

			using (StreamWriter sw = File.AppendText(file)) {
				sw.Write("789");
				Console.WriteLine($"tream size {sw.BaseStream.Length}");
			}

			var r1 = File.ReadAllBytes(file); Console.Write($"size {r1.Length}:");
			foreach (var a in r1) Console.Write(" " + a); Console.WriteLine();
			var r2 = File.ReadAllLines(file); Console.Write(r2.Length);
			foreach (var a in r2) Console.Write(" " + a); Console.WriteLine();
			var r3 = File.ReadAllText(file); Console.WriteLine($"<{r3}> (size {r3.Length})");

			string[] tasks = { "call 01", "call 02", "call 03"};
			Console.Write($"Orig (size {tasks.Count()}):");
			foreach (var a in tasks) Console.Write($" <{a}>");
			Console.WriteLine();
			string newFile = file + "_a.txt";
			File.WriteAllLines(newFile, tasks);
			var r = File.ReadAllLines(newFile);
			Console.Write($"Read (size {r.Count()}):");
			foreach (var a in r) Console.Write($" <{a}>");
			Console.WriteLine();
		}

		private static void FileInfos(string file) {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> FileInfo");

			FileInfo f = new FileInfo(file);
			using (FileStream fs = f.Create()) {
				fs.WriteByte(0x31);
				fs.WriteByte(0x32);
				fs.WriteByte(0x33);
				Console.WriteLine($"filestream size {fs.Length}");
			}

			using (FileStream fs = f.Open(FileMode.Append, FileAccess.Write, FileShare.None)) {
				fs.WriteByte(0x41);
				fs.WriteByte(0x42);
				fs.WriteByte(0x43);
				Console.WriteLine($"filestream size {fs.Length}");
			}

			using (FileStream fs = f.OpenWrite()) {
				fs.WriteByte(0x61);
				fs.WriteByte(0x62);
				fs.WriteByte(0x63);
				Console.WriteLine($"filestream size {fs.Length}");
			}

			using(StreamWriter sw = f.AppendText()) {
				sw.Write("789");
				Console.WriteLine($"tream size {sw.BaseStream.Length}");
			}
		}

		private static void DriveInfos() {
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"=> DriveInfo");

			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach(DriveInfo d in drives) {
				Console.Write($"Name: {d.Name}, Type: {d.DriveType}");
				if(d.IsReady)
					Console.WriteLine($", Free Space {d.TotalFreeSpace}, Format: {d.DriveFormat}, Label: {d.VolumeLabel}");
				else Console.WriteLine();
			}
		}

		private static void DirectoryType(string path) {
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine($"=> Working with the Directory Type. <{path}>");

			string[] drives = Directory.GetLogicalDrives();
			Console.Write($"Drives (size {drives.Length}):");
			foreach (string d in drives) Console.Write(" " + d);
			Console.WriteLine();

			string sub1 = "Sub01", sub2 = @"Sub02\Data\Images";
			string new1 = Path.Combine(new string[] { path, sub1 });
			string new2 = Path.Combine(new string[] { path, sub2 });

			Console.WriteLine($"<{new1}> existing: {Directory.Exists(new1)}");
			Console.WriteLine($"<{new2}> existing: {Directory.Exists(new2)}");

			Console.WriteLine($"To erase directories <{new1}> and <{new2}>");

			try {
				Directory.Delete(new1);
				Directory.Delete(new2);
			}
			catch (Exception e) { Console.WriteLine(e.Message); }
			Console.WriteLine($"<{new1}> existing: {Directory.Exists(new1)}");
			Console.WriteLine($"<{new2}> existing: {Directory.Exists(new2)}");
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
			DirectoryInfo cre1 = dir.CreateSubdirectory(sub1);
			DirectoryInfo cre2 = dir.CreateSubdirectory(sub2);

			Console.WriteLine($"<{new1}> existing: {Directory.Exists(new1)}");
			Console.WriteLine($"<{new2}> existing: {Directory.Exists(new2)}");
			Console.WriteLine($"<{new3}> existing: {Directory.Exists(new3)}");

			Console.WriteLine($"created1 : <{cre1.FullName}>");
			Console.WriteLine($"created2 : <{cre2.FullName}>");
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

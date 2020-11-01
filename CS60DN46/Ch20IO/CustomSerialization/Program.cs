using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace CustomSerialization {
	class Program {
		static void Main() {
			Console.WriteLine("***** Custom Serialization *****");
			Customizing("MyData.soap");
			Console.ResetColor();
		}

		private static void Customizing(string file) {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine($"=> Serialize {file} as Soap");

			StringData myData = new StringData();

			SoapFormatter soap = new SoapFormatter();
			using(Stream s = new FileStream(file, FileMode.Create, FileAccess.Write, FileShare.None)) {
				soap.Serialize(s, myData);
			}
		}
	}
}

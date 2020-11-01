using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace CustomSerialization {
	class Program {
		static void Main() {
			Console.WriteLine("***** Custom Serialization *****");
			CustomizeByISerializable("MyDataISerializable.soap");
			CustomizeByAttributes("MyDataAttributes.soap");
			Console.ResetColor();
		}

		private static void CustomizeByAttributes(string file) {
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine($"=> Serialize {file} as Soap Using Attribute");

			MoreData myData = new MoreData();

			SoapFormatter soap = new SoapFormatter();
			using (Stream s = new FileStream(file, FileMode.Create, FileAccess.Write, FileShare.None)) {
				soap.Serialize(s, myData);
			}
		}

		private static void CustomizeByISerializable(string file) {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine($"=> Serialize {file} as Soap Using ISerializable");

			StringData myData = new StringData();

			SoapFormatter soap = new SoapFormatter();
			using(Stream s = new FileStream(file, FileMode.Create, FileAccess.Write, FileShare.None)) {
				soap.Serialize(s, myData);
			}
		}
	}
}

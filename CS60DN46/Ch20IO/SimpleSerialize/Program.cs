using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SimpleSerialize {
	class Program {
		static void Main() {
			Console.WriteLine("***** Simple Serialization *****");
			string file = "CarData.dat";
			Serialize(file);
			LoadFromBinaryFile(file);
			Console.ResetColor();
		}

		private static void LoadFromBinaryFile(string file) {
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine($"=> Load fro Binary File {file}");

			BinaryFormatter bf = new BinaryFormatter();
			using (Stream s = File.OpenRead(file)) {
				JamesBondCar c = (JamesBondCar)bf.Deserialize(s);
				Console.WriteLine($"Can this car fly? : {c.canFly}");
			}
		}

		private static void Serialize(string file) {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine($"=> Serialize and Save to {file}");

			JamesBondCar jbc = new JamesBondCar();
			jbc.canFly = true;
			jbc.canSubmerge = false;
			jbc.theRadio.stationPresets = new double[] { 89.3, 105.1, 97.1 };
			jbc.theRadio.hasSubWoofers = true;

			SaveAsBinaryFormat(jbc, file);
		}

		private static void SaveAsBinaryFormat(object o, string name) {
			BinaryFormatter bf = new BinaryFormatter();
			using(Stream s = new FileStream(name, FileMode.Create, FileAccess.Write, FileShare.None)) {
				bf.Serialize(s, o);
			}
			Console.WriteLine($"-> Saved car in binary format!");
		}
	}
}

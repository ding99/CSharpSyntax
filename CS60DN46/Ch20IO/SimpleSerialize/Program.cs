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
			Serialize();
			Console.ResetColor();
		}

		private static void Serialize() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			string file = "CarData.dat";
			Console.WriteLine($"=> Serialized stream saved to {file}");

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

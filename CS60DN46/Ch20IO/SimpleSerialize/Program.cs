using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Xml.Serialization;

namespace SimpleSerialize {
	class Program {
		static void Main() {
			Console.WriteLine("***** Simple Serialization *****");
			string file = "CarData.dat";
			BinSerialize(file);
			BinDeSerialize(file);

			SoapSerialize("CarData.soap");
			XmlSerialize("CarData.xml");
			SaveListOfCarsXml("Cars.xml");
			SaveListOfCarsBin("Cars.bin");
			Console.ResetColor();
		}

		private static void SaveListOfCarsBin(string name) {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Serialize Collection of Objects as binary");

			BinaryFormatter bf = new BinaryFormatter();
			using (Stream s = new FileStream(name, FileMode.Create, FileAccess.Write, FileShare.None)) {
				bf.Serialize(s, CreateCars());
			}

			Console.WriteLine("-> Saved list of cars as binary!");
		}

		private static void SaveListOfCarsXml(string name) {
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("=> Serialize Collection of Objects as XML");

			using (Stream s = new FileStream(name, FileMode.Create, FileAccess.Write, FileShare.None)) {
				XmlSerializer xs = new XmlSerializer(typeof(List<JamesBondCar>));
				xs.Serialize(s, CreateCars());
			}

			Console.WriteLine("-> Saved list of cars as Xml!");
		}

		private static List<JamesBondCar> CreateCars() {
			List<JamesBondCar> cars = new List<JamesBondCar>();
			cars.Add(new JamesBondCar(true, true));
			cars.Add(new JamesBondCar(true, false));
			cars.Add(new JamesBondCar(false, true));
			cars.Add(new JamesBondCar(false, false));
			Console.WriteLine($"Created a List of JamesBonderCar (size {cars.Count})");
			return cars;
		}

		private static void XmlSerialize(string file) {
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine($"=> Serialize Using XmlSerializer. Save to {file}");

			SaveAsXmlFormat(CreateJameBonderCar(), file);
		}

		private static void SaveAsXmlFormat(object o, string name) {
			XmlSerializer xs = new XmlSerializer(typeof(JamesBondCar));

			using(Stream s = new FileStream(name, FileMode.Create, FileAccess.Write, FileShare.None)) {
				xs.Serialize(s, o);
			}
			Console.WriteLine("-> Saved car in XML format!");
		}

		private static void SoapSerialize(string file) {
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine($"=> Serialize Using SoapFormater. Save to {file}");

			SaveAsSoapFormat(CreateJameBonderCar(), file);
		}

		private static void SaveAsSoapFormat(object o, string name) {
			SoapFormatter sf = new SoapFormatter();
			using (Stream s = new FileStream(name, FileMode.Create, FileAccess.Write, FileShare.None)) {
				sf.Serialize(s, o);
			}
			Console.WriteLine("-> Saved car in Soap format!");
		}

		private static void BinDeSerialize(string file) {
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine($"=> DeSerialize Using BinaryFormatter. Load from Binary File {file}");

			BinaryFormatter bf = new BinaryFormatter();
			using (Stream s = File.OpenRead(file)) {
				JamesBondCar c = (JamesBondCar)bf.Deserialize(s);
				Console.WriteLine($"Can this car fly? : {c.canFly}");
			}
		}

		private static void BinSerialize(string file) {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine($"=> Serialize Using BinaryFormatter. Save to {file}");

			SaveAsBinaryFormat(CreateJameBonderCar(), file);
		}

		private static JamesBondCar CreateJameBonderCar() {
			JamesBondCar jbc = new JamesBondCar();
			jbc.canFly = true;
			jbc.canSubmerge = false;
			jbc.theRadio.stationPresets = new double[] { 89.3, 105.1, 97.1 };
			jbc.theRadio.hasSubWoofers = true;

			StringBuilder b = new StringBuilder($"JamesBonderCar:\n  canFly {jbc.canFly}\n  canSubmerge {jbc.canSubmerge}\n  Radio.stationPreset");
			foreach (var f in jbc.theRadio.stationPresets)
				b.Append(" ").Append(f);
			b.Append($"\n  Radio.hasSubWoofers {jbc.theRadio.hasSubWoofers}");

			Console.WriteLine(b.ToString());

			return jbc;
		}

		private static void SaveAsBinaryFormat(object o, string name) {
			BinaryFormatter bf = new BinaryFormatter();
			using(Stream s = new FileStream(name, FileMode.Create, FileAccess.Write, FileShare.None)) {
				bf.Serialize(s, o);
			}
			Console.WriteLine("-> Saved car in binary format!");
		}
	}
}

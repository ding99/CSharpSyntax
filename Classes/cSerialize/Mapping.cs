using Newtonsoft.Json;
using System;

namespace CSerialize {

	public class Source {
		public int Id { get; set; }
		public string Name { get; set; }
		public string Home { get; set; }
		public int Age { get; set; }
	}

	public class Target {
		public string Name { get; set; }
		public int Age { get; set; }
	}

	public class Mapping {

		public Mapping() {
			Console.ForegroundColor = ConsoleColor.Yellow;
		}

		public void Start() {
			Console.WriteLine("-- Mapping");

			Source s1 = new Source {
				Id = 10,
				Name = "Tester",
				Home = "Place",
				Age = 30
			};

			string json1 = JsonConvert.SerializeObject(s1);
			Console.WriteLine(json1);

			var s2 = JsonConvert.DeserializeObject<Target>(json1);
			string json2 = JsonConvert.SerializeObject(s2);
			Console.WriteLine(json2);
		}
	}
}

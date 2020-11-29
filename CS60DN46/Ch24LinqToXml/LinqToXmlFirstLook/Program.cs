using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LinqToXmlFirstLook {
	class Program {
		static void Main() {
			Console.WriteLine("***** Linq to XML First Look *****");

			BuildXmlDocWithDOM();

			Console.ResetColor();
		}

		private static void BuildXmlDocWithDOM() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Build XML Doc with DOM");

			XmlDocument doc = new XmlDocument();

			XmlElement inventory = doc.CreateElement("Inventory");

			XmlElement car = doc.CreateElement("Car");
			car.SetAttribute("ID", "1000");

			XmlElement name = doc.CreateElement("PerName");
			name.InnerText = "Jimbo";
			XmlElement color = doc.CreateElement("Color");
			color.InnerText = "Red";
			XmlElement make = doc.CreateElement("Make");
			make.InnerText = "Ford";

			car.AppendChild(name);
			car.AppendChild(color);
			car.AppendChild(make);

			inventory.AppendChild(car);

			doc.AppendChild(inventory);
			doc.Save("Inventory.xml");
		}
	}
}

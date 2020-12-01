using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace LinqToXmlFirstLook {
	class Program {
		static void Main() {
			Console.WriteLine("***** Linq to XML First Look *****");

			BuildXmlDocWithDOM();
			BuildXmlDocWithLinqToXml();
			RemoveElement();

			Console.ResetColor();
		}

		private static void RemoveElement() {
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("=> Remove Element with Linq to XML");

			XElement doc =
			  new XElement("Inventory",
				new XElement("Car", new XAttribute("ID", "1001"),
				  new XElement("PetName", "Jimbo"),
				  new XElement("Color", "Red"),
				  new XElement("Make", "Ford")
				)
			  );

			var d = doc.Descendants("Car");
			foreach(var a in d)
				Console.WriteLine(a);

			doc.Descendants("PetName").Remove();
			doc.Save("InventoryWithLinqWithoutPetName.xml");
		}

		private static void BuildXmlDocWithLinqToXml() {
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=> Biuld XML Doc with Linq to XML");

			XElement doc =
			  new XElement("Inventory",
			    new XElement("Car", new XAttribute("ID", "1000"),
			      new XElement("PetName", "Jimbo"),
			      new XElement("Color", "Red"),
			      new XElement("Make", "Ford")
			    )
			  );

			doc.Save("InventoryWithLinq.xml");
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

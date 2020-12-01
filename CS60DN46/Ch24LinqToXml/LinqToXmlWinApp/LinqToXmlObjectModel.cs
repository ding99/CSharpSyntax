using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LinqToXmlWinApp {
	public class LinqToXmlObjectModel {

		public static XDocument GetXmlInventory() {
			try {
				XDocument inventory = XDocument.Load("Inventory.xml");
				return inventory;
			}
			catch(System.IO.FileNotFoundException ex) {
				MessageBox.Show(ex.Message);
				return null;
			}
		}

		public static void InsertNewElement(string make, string color, string petName) {
			string file = "Inventory.xml";
			XDocument inventoryDoc = XDocument.Load(file);

			Random r = new Random();

			XElement newElement = new XElement("Car", new XAttribute("ID", r.Next(50000)), new XElement("Color", color), new XElement("Make", make), new XElement("PetName", petName));

			inventoryDoc.Descendants("Inventory").First().Add(newElement);

			inventoryDoc.Save(file);
		}

		public static void LookUpColorsForMake(string make) {
			XDocument inventoryDoc = XDocument.Load("Inventory.xml");

			var makeInfo = from car in inventoryDoc.Descendants("Car") where (string)car.Element("Make") == make select car.Element("Color").Value;

			string data = string.Empty;
			foreach (var item in makeInfo.Distinct())
				data += string.Format("- {0}\n", item);

			MessageBox.Show(data, string.Format("{0} colors:", make));
		}
	}
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConstructingXmlDocs {
	class Program {
		static void Main() {
			Console.WriteLine("***** Constructing Xml Docs *****");
			CreateFullXDocument();
			CreateRootAndChildren();
			Console.ResetColor();
		}

		private static void CreateRootAndChildren() {
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("Root and Children");

			XDocument inventoryDoc =
				new XDocument(
					new XElement("Inventory",
						new XComment("Current Inventory of cars!"),
						new XElement("Car", new XAttribute("ID", "1"),
							new XElement("Color", "Green"),
							new XElement("Make", "BWM"),
							new XElement("PetName", "Stan")
						),
						new XElement("Car", new XAttribute("ID", "2"),
							new XElement("Color", "Pink"),
							new XElement("Make", "Yugo"),
							new XElement("PetName", "Melvin")
						)
					)
				);

			inventoryDoc.Save("RootInventory.xml");
		}

		private static void CreateFullXDocument() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Full XDocument");

			XDocument inventoryDoc =
				new XDocument(
					new XDeclaration("1.0", "utf-8", "yes"),
					new XComment("Current Inventory of cars!"),
					new XProcessingInstruction("xml-stylesheet", "href='MyStyles.css' title='Compact' type='text/css'"),
					new XElement("Inventory",
						new XElement("Car", new XAttribute("ID","1"),
							new XElement("Color", "Green"),
							new XElement("Make", "BWM"),
							new XElement("PetName", "Stan")
						),
						new XElement("Car", new XAttribute("ID", "2"),
							new XElement("Color", "Pink"),
							new XElement("Make", "Yugo"),
							new XElement("PetName", "Melvin")
						)
					)
				);

			inventoryDoc.Save("SampleInventory.xml");
		}
	}
}

﻿using System;
using System.Linq;
using System.Xml.Linq;

namespace ConstructingXmlDocs {
	class Program {
		static void Main() {
			Console.WriteLine("***** Constructing Xml Docs *****");
			CreateFullXDocument();
			CreateRootAndChildren();
			MakeXElementFromArray();
			ParseLoadXml();
			Console.ResetColor();
		}

		private static void ParseLoadXml() {
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			
			Console.WriteLine("-> Parsing XML Content");

			string myElement =
				@"<Car ID = '3'>
				<Color>Yellow</Color>
				<Make>Yugo</Make>
				</Car>";

			XElement newElement = XElement.Parse(myElement);
			Console.WriteLine(newElement);

			Console.WriteLine("-> Loading XML Content");
			XDocument myDoc = XDocument.Load("SimpleInventory.xml");
			Console.WriteLine(myDoc);
		}

		private static void MakeXElementFromArray() {
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("=> Generating Documents from Arrays and Containers");

			var people = new[] {
				new { FirstName = "Mandy", Age = 32 },
				new { FirstName = "Andrew", Age = 40 },
				new { FirstName = "Dave", Age = 41 },
				new { FirstName = "Sara", Age = 31 }
			};

			XElement peopleDoc = new XElement("People",
				from c in people select new XElement("Person", new XAttribute("Age", c.Age), new XElement("FirstName", c.FirstName))
			);
			Console.WriteLine(peopleDoc);

			Console.WriteLine("-- Onec again");
			var data = from c in people select new XElement("Person", new XAttribute("Age", c.Age), new XElement("FirstName", c.FirstName));
			XElement peopleDoc2 = new XElement("people", data);
			Console.WriteLine(peopleDoc2);
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

			Console.WriteLine(inventoryDoc);
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

			Console.WriteLine(inventoryDoc);
			inventoryDoc.Save("SimpleInventory.xml");
		}
	}
}

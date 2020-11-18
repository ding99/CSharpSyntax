using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using static System.Console;
using AutoLotDAL.Models;
using AutoLotDAL.ConnectedLayer;

namespace AutoLotCUIClient {
	class Program {
		static void Main() {
			WriteLine("***** The AutoLot Console UI *****");

			ForegroundColor = ConsoleColor.Yellow;

			string connectionString = ConfigurationManager.ConnectionStrings["AutoLotSqlProvider"].ConnectionString;
			bool userDone = false;
			string userCommand = "";

			WriteLine($"connectionString <{connectionString}>");

			InventoryDAL dal = new InventoryDAL();
			dal.OpenConnection(connectionString);

			try {
				ShowInstructions();
				do {
					Write("Please enter your command: ");
					userCommand = ReadLine();
					WriteLine();
					switch (userCommand?.ToUpper() ?? "") {
						case "I": InsertNewCar(dal); break;
						case "U": UpdateCarPetName(dal); break;
						case "D": DeleteCar(dal); break;
						case "L": ListInventory(dal); break;
						case "S": ShowInstructions(); break;
						case "P": LookUpPetName(dal); break;
						case "Q": userDone = true;  break;
						default: WriteLine("Bad data! Try again"); break;
					}
				} while (!userDone);
			} catch(Exception ex) {
				WriteLine(ex.Message);
			}
			finally { dal.CloseConnection(); }

			ResetColor();
		}

		private static void ListInventory(InventoryDAL dal) {
			DataTable dt = dal.GetAllInventoryAsDataTable();
			DisplayTable(dt);
			ListInventoryViaList(dal);
		}

		private static void DisplayTable(DataTable t) {
			for (int col = 0; col < t.Columns.Count; col++)
				Write($"{t.Columns[col].ColumnName}\t");
			WriteLine("\n--------------------------------");
			for(int row = 0; row < t.Rows.Count; row++) {
				for (int col = 0; col < t.Columns.Count; col++)
					Write($"{t.Rows[row][col]}\t");
				WriteLine();
			}
		}

		private static void ListInventoryViaList(InventoryDAL dal) {
			List<NewCar> record = dal.GetAllInventoryAsList();
			WriteLine("CarId:\tMake:\tColor:\tPetName:");
			foreach (NewCar c in record)
				WriteLine($"{c.CarId}\t{c.Make}\t{c.Color}\t{c.PetName}");
		}

		private static void DeleteCar(InventoryDAL dal) {
			Write("Enter ID of Car to delete: ");
			int id = int.Parse(ReadLine() ?? "0");

			try {
				dal.DeleteCar(id);
			} catch(Exception ex) { WriteLine(ex.Message);  }
		}

		private static void InsertNewCar(InventoryDAL dal) {
			Write("Enter Car ID: ");
			var newCarId = int.Parse(ReadLine() ?? "0");
			Write("Enter Car Color: ");
			var newColor = ReadLine();
			Write("Enter Car Make: ");
			var newMake = ReadLine();
			Write("Enter Pet Name: ");
			var newPetName = ReadLine();
			var c = new NewCar { CarId = newCarId, Color = newColor, Make = newMake, PetName = newPetName };
			dal.InsertAuto(c);
		}

		private static void UpdateCarPetName(InventoryDAL dal) {
			Write("Enter Car ID: ");
			var carID = int.Parse(ReadLine() ?? "0");
			Write("Enter New Pet Name: ");
			var newPetName = ReadLine();

			dal.UpdateCarPetName(carID, newPetName);
		}

		private static void LookUpPetName(InventoryDAL dal) {

		}

		private static void ShowInstructions() {
			WriteLine("I: Inserts a new car.");
			WriteLine("U: Updates an existing car.");
			WriteLine("D: Deletes an existing car.");
			WriteLine("L: Lists current inventory.");
			WriteLine("S: Shows these instructions.");
			WriteLine("P: Looks up pet name.");
			WriteLine("Q: Quits program.");
		}
	}
}

/**
I: Inserts a new record into the Inventory table
U: Updates an existing record in the Inventory table
D: Deletes an existing record from the Inventory table
L: Displays the current inventory using a data reader
S: Shows these options to the user
P: Looks up pet name from carID
Q: Quits the program
**/

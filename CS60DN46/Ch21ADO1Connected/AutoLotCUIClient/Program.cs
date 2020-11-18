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
			} catch(Exception ex) {
				WriteLine(ex.Message);
			}
			finally { dal.CloseConnection(); }

			ResetColor();
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

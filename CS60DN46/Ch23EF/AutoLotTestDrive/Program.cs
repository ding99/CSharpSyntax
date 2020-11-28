using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AutoLotDAL.Models;
using AutoLotDAL.EF;
using AutoLotDAL.Repos;
using static System.Console;

namespace AutoLotTestDrive {
	class Program {
		static void Main() {
			WriteLine("***** Fun with ADO.NET EF Code First *****");
			Database.SetInitializer(new DataInitializer());

			PrintAllInventory();

			ResetColor();
		}

		private static void PrintAllInventory() {
			ForegroundColor = ConsoleColor.Yellow;
			WriteLine("=> Print All Inventory");

			using (var repo = new InventoryRepo())
				foreach (Inventory c in repo.GetAll())
					WriteLine(c);
		}
	}
}

using AutoLotDAL.EF;
using AutoLotDAL.Models;
using AutoLotDAL.Repos;
using System;
using System.Data.Entity;

namespace AutoLotTestDrive {
	class Program {
		static void Main() {
			Console.WriteLine("***** ADO.NET EF Code First (Test Lib) *****");

			Database.SetInitializer(new DataInitializer());

			PrintAllInventory();

			Console.ResetColor();
		}

		private static void PrintAllInventory() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Print All Inventory");

			using (var repo = new InventoryRepo())
				foreach (Inventory c in repo.GetAll())
					Console.WriteLine(c);
		}
	}
}

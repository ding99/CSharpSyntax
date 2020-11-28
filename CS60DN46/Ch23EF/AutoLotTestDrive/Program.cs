using AutoLotDAL.EF;
using AutoLotDAL.Models;
using AutoLotDAL.Repos;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using static System.Console;

namespace AutoLotTestDrive {
	class Program {
		static void Main() {
			WriteLine("***** Fun with ADO.NET EF Code First *****");
			Database.SetInitializer(new DataInitializer());

			PrintAllInventory();
			AddNewCar();

			ResetColor();
		}

		private static void AddNewCar() {
			ForegroundColor = ConsoleColor.Cyan;
			WriteLine("=> Adding New Inventory");

			var car1 = new Inventory { Make="Yugo", Color = "Brown", PetName = "Brownie" };
			var car2 = new Inventory { Make = "SmartCar", Color = "Brown", PetName = "Shorty" };

			AddNewRecord(car1);
			AddNewRecords(new List<Inventory> { car1, car2 });

			PrintAllInventory();
		}

		private static void AddNewRecord(Inventory car) {
			using (var repo = new InventoryRepo())
				repo.Add(car);
		}

		private static void AddNewRecords(IList<Inventory> cars) {
			using (var repo = new InventoryRepo())
				repo.AddRange(cars);
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

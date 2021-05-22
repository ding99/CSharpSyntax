using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLotDAL.Models;
using AutoLotDAL.Repos;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using AutoLotDAL.EF;

namespace AutoLotTestDrive {
	class Program {
		static void Main() {
			Console.WriteLine("***** ADO.NET EF Code First *****");

			Database.SetInitializer(new DataInitializer());

			PrintAllInventory();
			//int id = AddNewCar();
			//UpdateRecord(id);
			//PrintAllInventory();

			//ShowAllOrders();
			//ShowAllOrdersEagerlyFetched();
			//UpdateCreditRisk();

			//UpdateRecordWithConcurrency();
			//PrintAllInventory();

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

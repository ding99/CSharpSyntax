using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AutoLotDAL.EF;
using AutoLotDAL.Repos;
using AutoLotDAL.Models;
using static System.Console;

namespace AutoLotTestDrive {
	class Program {
		static void Main() {
			Database.SetInitializer(new DataInitializer());
			WriteLine("***** Fun with ADO.NET EF Code First *****");


			ResetColor();
		}

		private static void PrintAllInventory() {
			using (var repo = new InventoryRepo())
				foreach (Inventory c in repo.GetAll())
					WriteLine(c);
		}
	}
}

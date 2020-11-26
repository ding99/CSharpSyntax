using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLotConsoleApp.EF;
using static System.Console;

namespace AutoLotConsoleApp {
	class Program {
		static void Main() {
			WriteLine("***** Code First from an Existing DB *****");

			WriteLine($"new car id {AddNewRecord()}");
			PrintAllInventory();
			LinqQueries();

			ResetColor();
		}

		private static void LinqQueries() {
			ForegroundColor = ConsoleColor.Green;
			WriteLine("=> Fun with Linq Queries");

			using (var context = new AutoLotEntities()) {
				WriteLine("-> Colors Makes");
				var colorsMakes = from item in context.cars select new { item.Color, item.Make };
				foreach (var item in colorsMakes)
					WriteLine(item);

				WriteLine("-> Black cars");
				var blackCars = from item in context.cars where item.Color == "Black" select item;
				foreach (var item in blackCars)
					WriteLine(item);
			}
		}

		private static void PrintAllInventory() {
			ForegroundColor = ConsoleColor.Cyan;
			WriteLine("=> Print All Inventory");

			using(var context = new AutoLotEntities()) {
				foreach(Car c in context.cars)
					WriteLine(c);

				ForegroundColor = ConsoleColor.DarkCyan;
				foreach(Car c in context.cars.SqlQuery("Select CarId,Make,Color,PetName as CarNickName from Inventory where Make=@p0", "BMW"))
					WriteLine(c);

				ForegroundColor = ConsoleColor.DarkYellow;
				foreach (Car c in context.cars.Where(c => c.Make == "BMW"))
					WriteLine(c);
			}
		}

		private static int AddNewRecord() {
			ForegroundColor = ConsoleColor.Yellow;
			WriteLine("=> Add New Record");

			using(var context = new AutoLotEntities()) {
				try {
					var car = new Car() { Make = "Yugo", Color = "Brown", CarNickName = "Brownie" };
					context.cars.Add(car);
					context.SaveChanges();
					return car.CarId;
				}
				catch (Exception e) {
					WriteLine(e.InnerException.Message);
					return 0;
				}
			}
		}
	}
}

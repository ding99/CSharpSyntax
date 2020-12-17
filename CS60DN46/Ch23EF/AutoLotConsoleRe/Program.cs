using AutoLotConsoleRe.EF;
using System;
using System.Linq;
using static System.Console;

namespace AutoLotConsoleRe {
	class Program {
		static void Main() {
			WriteLine("***** Review EF *****");

			int newId = AddNewRecord();
			WriteLine($"The new car is {newId}");
			PrintAllInventory();
			LinqQueries();

			ResetColor();
		}

		private static void LinqQueries() {
			ForegroundColor = ConsoleColor.DarkYellow;
			WriteLine("Linq Queries");

			using (var context = new AutoLotEntities()) {
				var allData = context.Cars.ToArray();

				var colorMakes = from item in allData select new { item.Color, item.Make };
				foreach (var item in colorMakes)
					WriteLine(item);

				var blueCars = from item in allData where item.Color == "Blue" select item;
				foreach (var item in blueCars)
					WriteLine(item);
			}
		}

		private static void PrintAllInventory() {
			ForegroundColor = ConsoleColor.Cyan;
			WriteLine("=> Print All Inventory");

			using(var context = new AutoLotEntities()) {
				foreach (Car c in context.Cars)
					WriteLine(c);
			}
		}

		private static int AddNewRecord() {
			ForegroundColor = ConsoleColor.Yellow;
			WriteLine("=> Add New Record");

			using(var context = new AutoLotEntities()) {
				try {
					var car = new Car { Make = "Mazda", Color="Blue",CarNickName="Flash" };
					context.Cars.Add(car);
					context.SaveChanges();
					return car.CarId;
				} catch(Exception ex) {
					WriteLine(ex.InnerException.Message);
					return 0;
				}
			}
		}
	}
}

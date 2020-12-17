using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLotConsoleRe.EF;
using static System.Console;

namespace AutoLotConsoleRe {
	class Program {
		static void Main() {
			WriteLine("***** Review EF *****");

			int newId = AddNewRecord();
			WriteLine($"The new car is {newId}");
			PrintAllInventory();

			ResetColor();
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

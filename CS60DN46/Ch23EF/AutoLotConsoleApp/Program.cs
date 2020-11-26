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

			ResetColor();
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

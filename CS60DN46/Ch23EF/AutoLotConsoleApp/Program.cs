using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLotConsoleApp.EF;

namespace AutoLotConsoleApp {
	class Program {
		static void Main() {
			Console.WriteLine("***** Code First from an Existing DB *****");

			Console.WriteLine($"new car id {AddNewRecord()}");
			PrintAllInventory();

			Console.ResetColor();
		}

		private static void PrintAllInventory() {
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=> Print All Inventory");

			using(var context = new AutoLotEntities())
				foreach(Car c in context.cars)
					Console.WriteLine(c);
		}

		private static int AddNewRecord() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Add New Record");

			using(var context = new AutoLotEntities()) {
				try {
					var car = new Car() { Make = "Yugo", Color = "Brown", CarNickName = "Brownie" };
					context.cars.Add(car);
					context.SaveChanges();
					return car.CarId;
				}
				catch (Exception e) {
					Console.WriteLine(e.InnerException.Message);
					return 0;
				}
			}
		}
	}
}

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
			Navigation();

			ResetColor();
		}

		private static void Navigation() {
			ForegroundColor = ConsoleColor.Yellow;
			WriteLine("=> Navigation Properties");

			using (var context = new AutoLotEntities()) {
				WriteLine("-> Lazy loading");
				foreach (Car c in context.cars)
					foreach (Order o in c.Orders)
						WriteLine($"{o.OrderId} - {o.CarId}({o.Car.CarNickName}) / {o.CustId}({o.Customer.FirstName} {o.Customer.LastName})");
			}

			using(var context = new AutoLotEntities()) {
				ForegroundColor = ConsoleColor.DarkYellow;
				WriteLine("-> Eager Loading");
				foreach(Car c in context.cars.Include("Orders"))
					foreach(Order o in c.Orders)
						WriteLine($"{o.OrderId} - {o.CarId}({o.Car.CarNickName}) / {o.CustId}({o.Customer.FirstName} {o.Customer.LastName})");
			}
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

				ForegroundColor = ConsoleColor.Red;
				var allData = context.cars.ToArray();
				WriteLine("-> Colors Makes");
				var colorsMakes2 = from item in allData select new { item.Color, item.Make };
				foreach (var item in colorsMakes2)
					WriteLine("  " + item);

				WriteLine("-> Black cars");
				var blackCars2 = from item in allData where item.Color == "Black" select item;
				foreach (var item in blackCars2)
					WriteLine("  " + item);
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
					//context.SaveChanges();
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

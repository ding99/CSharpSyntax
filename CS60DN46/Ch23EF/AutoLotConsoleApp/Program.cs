using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using AutoLotConsoleApp.EF;
using static System.Console;

namespace AutoLotConsoleApp {
	class Program {
		static void Main() {
			WriteLine("***** Code First from an Existing DB *****");

			int newId = AddNewRecord();
			WriteLine($"new car id {newId}");
			PrintAllInventory();
			LinqQueries();
			Navigation();
			ExplicitLoading();
			RemoveRecord(newId);
			RemoveRecordUasingEntityState();
			UpdateRecord();

			ResetColor();
		}

		private static void UpdateRecord() {
			ForegroundColor = ConsoleColor.Red;
			WriteLine("=> Delete a record");

			int carId = 0;
			string color = "Blue", color2 = "Yellow";
			using (var context = new AutoLotEntities()) {
				carId = context.cars.Max(x => x.CarId);
				Car car = context.cars.Find(carId);

				if(car.Color == color) color = color2;
			}

			UpdateColor(carId, color);
		}

		private static void UpdateColor(int carId, string color) {
			WriteLine($"Update the Color to {color} for CarId {carId} ");

			using(var context = new AutoLotEntities()) {
				Car carToUpdate = context.cars.Find(carId);
				if(carToUpdate != null) {
					WriteLine(context.Entry(carToUpdate).State);
					carToUpdate.Color = color;
					WriteLine(context.Entry(carToUpdate).State);
					context.SaveChanges();
				}
			}
		}

		private static void RemoveRecordUasingEntityState() {
			ForegroundColor = ConsoleColor.DarkCyan;
			WriteLine($"=> Deleting Record Using Entity State");

			int carId = AddNewRecord();
			ForegroundColor = ConsoleColor.DarkCyan;
			WriteLine($"CarID {carId} to delete");

			using(var context = new AutoLotEntities()) {
				Car carToDelete = new Car() { CarId = carId };
				context.Entry(carToDelete).State = EntityState.Deleted;
				try {
					context.SaveChanges();
				} catch(DbUpdateConcurrencyException ex) {
					WriteLine(ex.Message);
				}
			}
		}

		private static void RemoveRecord(int carId) {
			ForegroundColor = ConsoleColor.Cyan;
			WriteLine($"=> Deleting Record: {carId}");

			using (var context = new AutoLotEntities()) {
				Car carToRemove = context.cars.Find(carId);
				if(carToRemove != null){
					context.cars.Remove(carToRemove);
					context.SaveChanges();
				}
			}
		}

		private static void ExplicitLoading() {
			ForegroundColor = ConsoleColor.Blue;
			WriteLine("-> Explicit loading:");

			using (var context = new AutoLotEntities()) {
				context.Configuration.LazyLoadingEnabled = false;

				foreach (Car c in context.cars) {
					context.Entry(c).Collection(x => x.Orders).Load();

					Write($"CarID-{c.CarId}, Count-{c.Orders.Count}");
					foreach (Order o in c.Orders)
						Write($" : <OrderID-{o.OrderId}>");
					WriteLine();
				}
			}
		}

		private static void Navigation() {
			ForegroundColor = ConsoleColor.Yellow;
			WriteLine("=> Navigation Properties");

			Write("-> Lazy loading:");
			int n = 0;
			using (var context = new AutoLotEntities())
				foreach (Car c in context.cars) {
					Write($" {++n}");
					foreach (Order o in c.Orders)
						Write($" <{o.OrderId}.{o.Car.CarNickName}.{o.Customer.FirstName} {o.Customer.LastName}>");
				}
			WriteLine();

			ForegroundColor = ConsoleColor.DarkYellow;
			Write("-> Eager Loading:");
			n = 0;
			using (var context = new AutoLotEntities())
				foreach (Car c in context.cars.Include(c => c.Orders)) {
					Write($" {++n}");
					foreach (Order o in c.Orders)
						Write($" <{o.OrderId}.{o.Car.CarNickName}.{o.Customer.FirstName} {o.Customer.LastName}>");
				}
			WriteLine();
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

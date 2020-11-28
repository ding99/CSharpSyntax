using AutoLotDAL.EF;
using AutoLotDAL.Models;
using AutoLotDAL.Repos;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace AutoLotTestDrive {
	class Program {
		static void Main() {
			WriteLine("***** Fun with ADO.NET EF Code First *****");
			Database.SetInitializer(new DataInitializer());

			PrintAllInventory();
			int id = AddNewCar();
			UpdateRecord(id);
			PrintAllInventory();

			ShowAllOrders();
			ShowAllOrdersEagerlyFetched();
			UpdateCreditRisk();

			ResetColor();
		}

		private static void UpdateCreditRisk() {
			ForegroundColor = ConsoleColor.Blue;
			WriteLine("=> Make Customer Credit Risk");

		}

		private static CreditRisk MakeCustomerARisk(Customer customer) {
			using(var context = new AutoLotEntities()) {
				context.Customers.Attach(customer);
				context.Customers.Remove(customer);
				var creditRisk = new CreditRisk {
					FirstName = customer.FirstName,
					LastName = customer.LastName
				};
				context.CreditRisks.Add(creditRisk);
				try { context.SaveChanges(); }
				catch (DbUpdateException ex) { WriteLine(ex.Message); }
				catch (Exception ex) { WriteLine(ex.Message); }
				return creditRisk;
			}
		}

		private static void ShowAllOrdersEagerlyFetched() {
			ForegroundColor = ConsoleColor.Green;
			WriteLine("=> Show All Orders Eagerly Fetched");

			using(var context = new AutoLotEntities()) {
				var orders = context.Orders.Include(x => x.Customer).Include(y => y.Car).ToList();
				foreach (var itm in orders)
					WriteLine($"{itm.Customer.FullName} is waiting on {itm.Car.PetName}");
			}
		}

		private static void ShowAllOrders() {
			ForegroundColor = ConsoleColor.DarkCyan;
			WriteLine("=> Show All Orders");

			using(var repo = new OrderRepo()) {
				foreach (var itm in repo.GetAll())
					WriteLine($"{itm.Customer.FullName} is waiting on {itm.Car.PetName}");
			}
		}

		private static void UpdateRecord(int carId) {
			ForegroundColor = ConsoleColor.DarkYellow;
			WriteLine($"=> Updating Record with carId {carId}");

			using (var repo = new InventoryRepo()) {
				var carToUpdate = repo.GetOne(carId);
				if (carToUpdate != null) {
					WriteLine($"Before change: {repo.Context.Entry(carToUpdate).State}");

					carToUpdate.Color = "Blue";
					WriteLine($"After change: {repo.Context.Entry(carToUpdate).State}");

					repo.Save(carToUpdate);
					WriteLine($"After save: {repo.Context.Entry(carToUpdate).State}");
				} else WriteLine($"Not found record {carId}");
			}
		}

		private static int AddNewCar() {
			ForegroundColor = ConsoleColor.Cyan;
			WriteLine("=> Adding New Inventory");

			var car1 = new Inventory { Make="Yugo", Color = "Brown", PetName = "Brownie" };
			var car2 = new Inventory { Make = "SmartCar", Color = "Brown", PetName = "Shorty" };

			AddNewRecord(car1);
			int id = car1.CarId;
			AddNewRecords(new List<Inventory> { car1, car2 });

			return id;
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

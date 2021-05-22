using AutoLotDAL.EF;
using AutoLotDAL.Models;
using AutoLotDAL.Repos;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace AutoLotTestDrive {
	class Program {
		static void Main() {
			Console.WriteLine("***** ADO.NET EF Code First (Test Lib) *****");

			Database.SetInitializer(new DataInitializer());
			PrintAllInventory();

			int id = AddNewCar();
			UpdateRecord(id);
			PrintAllInventory();

			ShowAllOrders();
			ShowAllOrdersEagerlyFetched();
			UpdateCreditRisk();

			UpdateRecordWithConcurrency();
			PrintAllInventory();

			Console.ResetColor();
		}

		private static void UpdateRecordWithConcurrency() {
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=> Update Record with Concurrency");

			var car = new Inventory { Make = "Yugo", Color = "Brown", PetName = "Brownie" };
			AddNewRecord(car);

			Console.WriteLine($"The new carId : {car.CarId}");

			var repo1 = new InventoryRepo();
			var car1 = repo1.GetOne(car.CarId);
			car1.PetName = "Updated1";

			var repo2 = new InventoryRepo();
			var car2 = repo2.GetOne(car.CarId);
			car2.Make = "Nissan";

			repo1.Save(car1);
			try { repo2.Save(car2); }
			catch (DbUpdateConcurrencyException ex) { Console.WriteLine(ex.Message); }
			catch (Exception ex) { Console.WriteLine(ex.Message); }

			RemoveRecordById(car1.CarId);
		}

		private static void RemoveRecordById(int id) {
			Console.WriteLine($"Remove a record with id {id}");

			using (var repo = new InventoryRepo())
				repo.Delete(id);
		}

		private static void UpdateCreditRisk() {
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("=> Make Customer Credit Risk");

			PrintAllCustomersCreditRisks();
			var customerRepo = new CustomerRepo();
			var customer = customerRepo.GetOne(4);
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine($"To move: {customer.CustId} {customer.FullName}");
			customerRepo.Context.Entry(customer).State = EntityState.Detached;
			var risk = MakeCustomerARisk(customer);
			PrintAllCustomersCreditRisks();
		}

		private static void PrintAllCustomersCreditRisks() {
			Console.ForegroundColor = ConsoleColor.DarkYellow;

			Console.WriteLine("-> Customers");
			using (var repo = new CustomerRepo())
				foreach (var cust in repo.GetAll())
					Console.WriteLine($"{cust.FirstName} {cust.LastName} is a Customer.");

			Console.WriteLine("-> CreditRisks");
			using (var repo = new CreditRiskRepo())
				foreach (var cust in repo.GetAll())
					Console.WriteLine($"{cust.FirstName} {cust.LastName} is a Credit Risk!");
		}

		private static CreditRisk MakeCustomerARisk(Customer customer) {
			using (var context = new AutoLotEntities()) {
				context.Customers.Attach(customer);
				context.Customers.Remove(customer);
				var creditRisk = new CreditRisk {
					FirstName = customer.FirstName,
					LastName = customer.LastName
				};
				context.CreditRisks.Add(creditRisk);

				var creditRiskDupe = new CreditRisk {
					FirstName = customer.FirstName,
					LastName = customer.LastName
				};
				context.CreditRisks.Add(creditRiskDupe);

				//exception occurs because of adding the record twice
				try { context.SaveChanges(); }
				catch (DbUpdateException ex) {
					Console.WriteLine($"Db Update Exception: {ex.Message}");
				}
				catch (Exception ex) { Console.WriteLine($"Exception: {ex.Message}"); }

				return creditRisk;
			}
		}

		private static void ShowAllOrdersEagerlyFetched() {
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("=> Show All Orders Eagerly Fetched");

			using (var context = new AutoLotEntities()) {
				var orders = context.Orders.Include(x => x.Customer).Include(y => y.Car).ToList();
				foreach (var itm in orders)
					Console.WriteLine($"{itm.Customer.FullName} is waiting on {itm.Car.PetName}");
			}
		}

		private static void ShowAllOrders() {
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine("=> Show All Orders");

			using (var repo = new OrderRepo()) {
				foreach (var itm in repo.GetAll())
					Console.WriteLine($"{itm.Customer.FullName} is waiting on {itm.Car.PetName}");
			}
		}

		private static void UpdateRecord(int carId) {
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine($"=> Updating Record with carId {carId}");

			using (var repo = new InventoryRepo()) {
				var carToUpdate = repo.GetOne(carId);
				if (carToUpdate != null) {
					Console.WriteLine($"Before change: {repo.Context.Entry(carToUpdate).State}");

					carToUpdate.Color = "Blue";
					Console.WriteLine($"After change: {repo.Context.Entry(carToUpdate).State}");

					repo.Save(carToUpdate);
					Console.WriteLine($"After save: {repo.Context.Entry(carToUpdate).State}");
				} else Console.WriteLine($"Not found record {carId}");
			}
		}
		private static int AddNewCar() {
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=> Adding New Inventory");

			var car1 = new Inventory { Make = "Yugo", Color = "Brown", PetName = "Brownie" };
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
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Print All Inventory");

			using (var repo = new InventoryRepo())
				foreach (Inventory c in repo.GetAll())
					Console.WriteLine(c);
		}
	}
}

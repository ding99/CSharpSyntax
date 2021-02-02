using AutoLotDAL.Models;
using System;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.Interception;
using System.Web;

namespace AutoLotDAL.EF {
	public class AutoLotEntities : DbContext {
		// connection string: 'AutoLotEntities'.
		// target: 'AutoLotDAL.EF.AutoLotEntities' database on your LocalDb instance. 
		// If you wish to target a different database and/or database provider, modify the 'AutoLotEntities' connection string in the configuration file.

		static readonly DatabaseLogger dbLogger = new DatabaseLogger($"{HttpRuntime.AppDomainAppPath}/sqllog.txt", true);

		public AutoLotEntities() : base("name=AutoLotConnection") {
			//DbInterception.Add(new ConsoleWriterInterceptor());
			dbLogger.StartLogging();
			DbInterception.Add(dbLogger);

			var context = (this as IObjectContextAdapter).ObjectContext;
			context.SavingChanges += OnSavingChanges;
		}

		private void OnSavingChanges(object sender, EventArgs args) {
			var context = sender as ObjectContext;
			if (context == null) return;

			foreach(ObjectStateEntry item in context.ObjectStateManager.GetObjectStateEntries(EntityState.Modified | EntityState.Added)) {
				if((item.Entity as Inventory) != null) {
					var entity = (Inventory)item.Entity;
					Console.WriteLine($"-- OnSavingChanges. Color <{entity.Color}>");
					if (entity.Color == "Red")
						item.RejectPropertyChanges(nameof(entity.Color));
				}
			}
		}

		public virtual DbSet<CreditRisk> CreditRisks { get; set; }
		public virtual DbSet<Customer> Customers { get; set; }
		public virtual DbSet<Inventory> Inventory { get; set; }
		public virtual DbSet<Order> Orders { get; set; }

		protected override void Dispose(bool disposing) {
			DbInterception.Remove(dbLogger);
			dbLogger.StartLogging();

			base.Dispose(disposing);
		}
	}
}
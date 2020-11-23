using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AutoLotConsoleApp.EF {
	public partial class AutoLotEntities : DbContext {
		public AutoLotEntities()
			: base("name=AutoLotConnection") {
		}

		public virtual DbSet<CreditRisk> CreditRisks { get; set; }
		public virtual DbSet<Customer> Customers { get; set; }
		public virtual DbSet<Inventory> Inventories { get; set; }
		public virtual DbSet<Order> Orders { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder) {
			modelBuilder.Entity<Customer>()
				.HasMany(e => e.Orders)
				.WithRequired(e => e.Customer)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Inventory>()
				.HasMany(e => e.Orders)
				.WithRequired(e => e.Inventory)
				.WillCascadeOnDelete(false);
		}
	}
}

using System.Data.Entity;

namespace AutoLotConsoleApp.EF {
	public partial class AutoLotEntities : DbContext {
		public AutoLotEntities()
			: base("name=AutoLotConnection") {
		}

		public virtual DbSet<CreditRisk> CreditRisks { get; set; }
		public virtual DbSet<Customer> Customers { get; set; }
		public virtual DbSet<Car> cars { get; set; }
		public virtual DbSet<Order> Orders { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder) {
			modelBuilder.Entity<Customer>()
				.HasMany(e => e.Orders)
				.WithRequired(e => e.Customer)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Car>()
				.HasMany(e => e.Orders)
				.WithRequired(e => e.Car)
				.WillCascadeOnDelete(false);
		}
	}
}

using AutoLotDAL.Models;
using System.Data.Entity;

namespace AutoLotDAL.EF {
	public class AutoLotEntities : DbContext {
		public AutoLotEntities()
			: base("name=AutoLotConnection") {
		}

		public virtual DbSet<CreditRisk> CreditRisks { get; set; }
		public virtual DbSet<Customer> Customers { get; set; }
		public virtual DbSet<Inventory> Inventory { get; set; }
		public virtual DbSet<Order> Orders { get; set; }

	}
}
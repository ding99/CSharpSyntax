using System;
using System.Data.Entity;
using System.Linq;
using AutoLotDAL.Models;

namespace AutoLotDAL.EF {
	public class AutoLotEntities : DbContext {
		// connection string: 'AutoLotEntities'.
		// target: 'AutoLotDAL.EF.AutoLotEntities' database on your LocalDb instance. 
		// If you wish to target a different database and/or database provider, modify the 'AutoLotEntities' connection string in the configuration file.
		public AutoLotEntities() : base("name=AutoLotConnection") {}

		public virtual DbSet<CreditRisk> CreditRisks { get; set; }
		public virtual DbSet<Customer> Customers { get; set; }
		public virtual DbSet<Inventory> Inventory { get; set; }
		public virtual DbSet<Order> Orders { get; set; }
	}
}
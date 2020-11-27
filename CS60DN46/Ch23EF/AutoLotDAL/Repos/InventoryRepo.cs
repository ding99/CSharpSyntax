﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLotDAL.EF;
using AutoLotDAL.Models;
using System.Data.Entity;

namespace AutoLotDAL.Repos {
	public class InventoryRepo : BaseRepo<Inventory>, IRepo<Inventory> {
		public InventoryRepo() { Table = Context.Inventory; }

		public int Delete(int id) {
			Context.Entry(new Inventory() { CarId = id }).State = EntityState.Deleted;
			return SaveChanges();
		}
		public Task<int> DeleteAsync(int id) {
			Context.Entry(new Inventory() { CarId = id }).State = EntityState.Deleted;
			return SaveChangesAsync();
		}
	}
}

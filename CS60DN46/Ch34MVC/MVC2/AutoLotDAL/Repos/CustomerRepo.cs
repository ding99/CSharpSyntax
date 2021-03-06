﻿using AutoLotDAL.Models;
using System.Data.Entity;
using System.Threading.Tasks;

namespace AutoLotDAL.Repos {
	public class CustomerRepo : BaseRepo<Customer>, IRepo<Customer> {
		public CustomerRepo() {
			Table = Context.Customers;
		}

		public int Delete(int id) {
			Context.Entry(new Customer { CustId = id }).State = EntityState.Deleted;
			return SaveChanges();
		}

		public Task<int> DeleteAsync(int id) {
			Context.Entry(new Customer { CustId = id }).State = EntityState.Deleted;
			return SaveChangesAsync();
		}
	}
}

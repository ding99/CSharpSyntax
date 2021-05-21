using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AutoLotDAL.Models;

namespace AutoLotDAL.Repos {
	public class OrderRepo : BaseRepo<Order>, IRepo<Order> {
		public OrderRepo() {
			Table = Context.Orders;
		}

		public int Delete(int id) {
			Context.Entry(new Order { OrderId = id }).State = EntityState.Deleted;
			return SaveChanges();
		}

		public Task<int> DeleteAsync(int id) {
			Context.Entry(new Order { OrderId = id }).State = EntityState.Deleted;
			return SaveChangesAsync();
		}
	}
}

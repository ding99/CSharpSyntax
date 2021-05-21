﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoLotDAL.Models;

namespace AutoLotDAL.Repos {
	public class InventoryRepo : BaseRepo<Inventory>, IRepo<Inventory> {
		public InventoryRepo() {
			Table = Context.Inventory;
		}
	}
}

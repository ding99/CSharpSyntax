﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using AutoLotDAL.Repos;
using AutoLotDAL.Models;

public partial class Default2 : System.Web.UI.Page {
	protected void Page_Load(object sender, EventArgs e) {

	}

	public IEnumerable<Inventory> GetData() => new InventoryRepo().GetAll();
}
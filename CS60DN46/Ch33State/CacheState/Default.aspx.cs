using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AutoLotDAL.Repos;
using AutoLotDAL.Models;

public partial class _Default : System.Web.UI.Page {
	protected void Page_Load(object sender, EventArgs e) {
		if (!IsPostBack) {
			carsGridView.DataSource = (IList<Inventory>)Cache["AppDataTable"];
			carsGridView.DataBind();
		}
	}

	protected void btnAddCar_Click(object sender, EventArgs e) {
		new InventoryRepo().Add(new Inventory() {
			Color = txtCarColor.Text,
			Make = txtCarMake.Text,
			PetName = txtCarPetName.Text
		});
		RefreshGrid();
	}

	private void RefreshGrid() {
		carsGridView.DataSource = new InventoryRepo().GetAll();
		carsGridView.DataBind();
	}
}
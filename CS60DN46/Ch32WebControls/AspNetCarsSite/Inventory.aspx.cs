using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using AutoLotDAL.Repos;
using AutoLotDAL.Models;

public partial class InventoryPage : System.Web.UI.Page {
	protected void Page_Load(object sender, EventArgs e) {

	}

	public IEnumerable<Inventory> GetData() => new InventoryRepo().GetAll();

	public void Delete(int carId, byte[] timeStamp) {
		new InventoryRepo().Delete(carId, timeStamp);
	}

	//explicit
	//public async void Update(int carID) {
	//	var inv = new Inventory() { CarId = carID };
	//	if (TryUpdateModel(inv)) {
	//		await new InventoryRepo().SaveAsync(inv);
	//	}
	//}

	//implicit
	public async void Update(Inventory inventory) {
		if (ModelState.IsValid)
			await new InventoryRepo().SaveAsync(inventory);
	}
}
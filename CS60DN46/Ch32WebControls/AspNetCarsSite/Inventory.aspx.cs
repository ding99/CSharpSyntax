using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.ModelBinding;

using AutoLotDAL.Repos;
using AutoLotDAL.Models;

public partial class InventoryPage : System.Web.UI.Page {
	protected void Page_Load(object sender, EventArgs e) {

	}

	public IQueryable<Inventory> GetData([Control("cboMake")] string make = "") {
		return string.IsNullOrEmpty(make) ?
			new InventoryRepo().GetAll().AsQueryable() :
			new InventoryRepo().GetAll().Where(x => x.Make == make).AsQueryable();
	}

	public void Delete(int carId, byte[] timeStamp) {
		new InventoryRepo().Delete(carId, timeStamp);
	}

	//explicit
	public async void Update(int carID) {
		var inv = new Inventory() { CarId = carID };
		if (TryUpdateModel(inv)) {
			await new InventoryRepo().SaveAsync(inv);
		}
	}

	//implicit
	//public async void Update(Inventory inventory) {
	//	if (ModelState.IsValid)
	//		await new InventoryRepo().SaveAsync(inventory);
	//}

	public IEnumerable GetMakes() => new InventoryRepo().GetAll().Select(x => new {x.Make}).Distinct();
}
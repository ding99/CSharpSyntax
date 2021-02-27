using System;

public partial class Annotations : System.Web.UI.Page {

	private Inventory _model = null;
	protected void Page_Load(object sender, EventArgs e) {

	}

	public void SaveCar(Inventory car) {
		if (ModelState.IsValid) {
			_model = car;
			//Add new record here
		}
	}

	public void UpdateCar(int carID) {
		Inventory car = new Inventory();
		if (TryUpdateModel(car)) {
			_model = car;
			//Update record here
		}
	}

	public Inventory GetCar() => _model;
}
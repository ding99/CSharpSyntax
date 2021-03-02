using System;

public partial class _Default : System.Web.UI.Page {

	// State data
	private string userFavoriteCar = "initialized: Yugo";

	protected void Page_Load(object sender, EventArgs e) {
	}

	protected void btnSetCar_Click(object sender, EventArgs e) {
		userFavoriteCar = txtFavCar.Text;
		//lblFavCar.Text = userFavoriteCar;
		Session["UserFavCar"] = $"set: {txtFavCar.Text}";
	}

	protected void btnGetCar_Click(object sender, EventArgs e) {
		//lblFavCar.Text = userFavoriteCar;
		lblFavCar.Text = $"In variable: [{userFavoriteCar}];  In Session [{(string)Session["UserFavCar"]}]";
	}
}
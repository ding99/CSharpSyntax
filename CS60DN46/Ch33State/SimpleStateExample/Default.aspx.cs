using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page {

	// State data
	//private string userFavoriteCar = "Yugo";

	protected void Page_Load(object sender, EventArgs e) {
	}

	protected void btnSetCar_Click(object sender, EventArgs e) {
		//userFavoriteCar = txtFavCar.Text;
		//lblFavCar.Text = userFavoriteCar;
		Session["UserFavCar"] = txtFavCar.Text;
	}

	protected void btnGetCar_Click(object sender, EventArgs e) {
		//lblFavCar.Text = userFavoriteCar;
		lblFavCar.Text = (string)Session["UserFavCar"];
	}
}
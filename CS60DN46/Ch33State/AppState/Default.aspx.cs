using System;

public partial class _Default : System.Web.UI.Page {
	protected void Page_Load(object sender, EventArgs e) {
	}

	protected void btnShowCarOnSale_Click(object sender, EventArgs e) {
		//lblCurrCarOnSale.Text = string.Format("Sale on {0}'s today!", (string)Application["CurrentCarOnSale"]);
		CarLotInfo car = ((CarLotInfo)Application["CarSiteInfo"]);
		string appState = $"<li>Car on sale: [{ car.CurrentCarOnSale }]</li>";
		lblCurrCarOnSale.Text = appState;
	}

	protected void btnSaveCarOnSale_Click(object sender, EventArgs e) {
		Application.Lock();
		((CarLotInfo)Application["CarSiteInfo"]).CurrentCarOnSale = txtCurrCarOnSale.Text;
		Application.UnLock();
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page {
	protected void Page_Load(object sender, EventArgs e) {
		GetUserAddress();
	}

	protected void btnSubmit_Click(object sender, EventArgs e) {
		Profile.StreetAddress = txtStreet.Text;
		Profile.City = txtCity.Text;
		Profile.State = txtState.Text;

		GetUserAddress();
	}

	private void GetUserAddress() {
		lblUserData.Text = $"You live here: {Profile.StreetAddress}, {Profile.City}, {Profile.State}";
	}
}
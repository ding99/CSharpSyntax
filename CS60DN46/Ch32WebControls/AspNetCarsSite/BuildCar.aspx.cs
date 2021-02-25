using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page {
	protected void Page_Load(object sender, EventArgs e) {

	}

	protected void ColorID_FinishButtonClick(object sender, WizardNavigationEventArgs e) {
		string order = $"{NameID.Text}, your {ColorID.SelectedValue} {ModelID.Text} will arrive on {DateID.SelectedDate.ToShortDateString()}";
		lblOrder.Text = order;
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page {
	protected void Page_Load(object sender, EventArgs e) {
		if (!IsPostBack) {
			myListBox.Items.Add("Item One");
			myListBox.Items.Add("Item Two");
			myListBox.Items.Add("Item Three");
			myListBox.Items.Add("Item Four");
		}
	}

	protected void btnPostback_Click(object sender, EventArgs e) {
	}

	protected void btnAddToVS_Click(object sender, EventArgs e) {
		ViewState["CustomViewStateItem"] = "Some user data";
		lblVSValues.Text = (string)ViewState["CustomViewStateItem"];
	}
}
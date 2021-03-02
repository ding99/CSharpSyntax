using System;
using System.Web.UI;

public partial class _Default : Page {
	protected void Page_Load(object sender, EventArgs e) {
		if (!IsPostBack) {
			myListBox.Items.Add("Item One");
			myListBox.Items.Add("Item Two");
			myListBox.Items.Add("Item Three");
			myListBox.Items.Add("Item Four");
		}

		ViewState["LoadState"] = "Loaded";
	}

	protected void btnPostback_Click(object sender, EventArgs e) {
	}

	protected void btnAddToVS_Click(object sender, EventArgs e) {
		ViewState["CustomViewStateItem"] = "Some user data";
		lblVSValues.Text = $"(1) [{(string)ViewState["CustomViewStateItem"]}], (2) [{(string)ViewState["LoadState"]}]";
	}
}
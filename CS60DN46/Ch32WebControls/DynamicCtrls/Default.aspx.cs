using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page {
	protected void Page_Load(object sender, EventArgs e) {
		ListControlsInPanel();
	}

	protected void btnClearPanel_Click(object sender, System.EventArgs e) {
		myPanel.Controls.Clear();
		ListControlsInPanel();
	}

	protected void btnAddWidgets_Click(object sender, System.EventArgs e) {
		for(int i = 0; i < 3; i++) {
			TextBox t = new TextBox { ID = $"newTextBox{i}", Text = $"TextBox{i}" };
			myPanel.Controls.Add(t);
			ListControlsInPanel();
		}
	}

	private void ListControlsInPanel() {
		StringBuilder b = new StringBuilder(
		$"<b>Does the panel have controls? {myPanel.HasControls()} </b><br/>");

		foreach(Control c in myPanel.Controls) {
			if(!object.ReferenceEquals(c.GetType(), typeof(System.Web.UI.LiteralControl))) {
				b.Append("*********************************************<br/>");
				b.Append($"Contol Name? {c} <br/>");
				b.Append($"ID? {c.ID} <br/>");
				b.Append($"Control Visibale? {c.Visible} <br/>");
				b.Append($"ViewState? {c.EnableViewState} <br/>");
			}
		}

		lblControlInfo.Text = b.ToString();
	}
}
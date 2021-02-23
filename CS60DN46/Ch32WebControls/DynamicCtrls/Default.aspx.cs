using System;
using System.Text;
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
		for(int i = 0; i < 3; i++)
			myPanel.Controls.Add(new TextBox { ID = $"newTextBox{i}", Text = $"Text{i}" });
		ListControlsInPanel();
	}

	protected void btnGetTextData_Click(object sender, System.EventArgs e) {
		StringBuilder b = new StringBuilder($"*** Request Forms ({Request.Form.Count})<br/>");
		for(int i = 0; i < Request.Form.Count; i++) {
			b.Append($"<li>{Request.Form[i]}</li><br/>");
		}
		lblTextBoxData.Text = b.ToString();
	}

	protected void btnGetAddedTextData_Click(object sender, System.EventArgs e) {
		StringBuilder b = new StringBuilder($"*** Added Text Box Data<br/>");
		for (int i = 0; i < 3; i++) {
			b.Append($"<li>{Request.Form.Get($"newTextBox{i}")}</li><br/>");
		}
		lblTextBoxData.Text = b.ToString();
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
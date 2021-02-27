using System;

public partial class _Default : System.Web.UI.Page {
	protected void Page_Load(object sender, EventArgs e) {
	}

	protected void btnNoTheme_Click(object sender, System.EventArgs e) {
		Session["UserTheme"] = "";
		Server.Transfer(Request.FilePath);
	}

	protected void btnGreenTheme_Click(object sender, EventArgs e) {
		Session["UserTheme"] = "BasicGreen";
		Server.Transfer(Request.FilePath);
	}

	protected void btnOrangeTheme_Click(object sender, EventArgs e) {
		Session["UserTheme"] = "CrazyOrange";
		Server.Transfer(Request.FilePath);
	}

	protected void Page_PreInit(object sender, EventArgs e) {
		try {
			Theme = Session["UserTheme"].ToString();
		}
		catch {
			Theme = "";
		}
	}
}
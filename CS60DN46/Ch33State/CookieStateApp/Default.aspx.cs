using System;
using System.Web;
using System.Web.UI;

public partial class _Default : Page {
	protected void Page_Load(object sender, EventArgs e) {

	}

	protected void btnWrite_Click(object sender, EventArgs e) {
		HttpCookie theCookie = new HttpCookie(txtName.Text, txtValue.Text);
		//theCookie.Expires = DateTime.Now.AddMonths(3); // persistent cookie
		Response.Cookies.Add(theCookie);
	}

	protected void btnShow_Click(object sender, EventArgs e) {
		string cookieData = "";
		foreach(string s in Request.Cookies) {
			cookieData += $"<li><b>Name</b>: {s}, <b>Value</b>: {Request.Cookies[s]?.Value}</li>";
		}
		lblCookieData.Text = cookieData;
	}
}
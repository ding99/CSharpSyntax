using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page {
	protected void Page_Load(object sender, EventArgs e) {
	}

	protected void btnGetBrowserStats_Click(object sender, EventArgs e) {
		string theInfo = "";
		theInfo += $"<li>Is the client AOL? {Request.Browser.AOL}</li>";
		theInfo += $"<li>Does the client support ActiveX? {Request.Browser.ActiveXControls}</li>";
		theInfo += $"<li>Is the client a Beta? {Request.Browser.Beta}</li>";
		theInfo += $"<li>Does the client support Java Applets? {Request.Browser.JavaApplets}</li>";
		theInfo += $"<li>Does the client support Cookies? {Request.Browser.Cookies}</li>";
		theInfo += $"<li>Does the client support VBScript? {Request.Browser.VBScript}</li>";
		theInfo += $"<li>What is the screen size? {Request.Browser.ScreenPixelsWidth} x {Request.Browser.ScreenPixelsHeight}</li>";
		lblOutput.Text = theInfo;
	}
}
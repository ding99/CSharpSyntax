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

		theInfo += "<br/>";
		theInfo += $"<li>Text Name [{txtFirstName.Text}]</li>";
		theInfo += $"<li>Text Name (Get) [{Request.Form.Get("txtFirstName")}]</li>";
		theInfo += $"<li>Query String Count [{Request.QueryString.Count}]</li>";
		theInfo += $"<li>Raw Url [{Request.RawUrl}]</li>";
		theInfo += $"<li>Request Type [{Request.RequestType}]</li>";
		theInfo += $"<li>Http Method [{Request.HttpMethod}]</li>";
		theInfo += $"<li>App Path [{Request.ApplicationPath}]</li>";
		theInfo += $"<li>User Host Address [{Request.UserHostAddress}]</li>";
		theInfo += $"<li>User Host Name [{Request.UserHostName}]</li>";
		theInfo += $"<li>User Agent [{Request.UserAgent}]</li>";

		string terms = string.Empty;
		foreach (var a in Request.Cookies)
			terms += $"({a})";
		theInfo += $"<br/><li>Cookies [{Request.Cookies.Count} {terms}]</li>";

		theInfo += getList("Headers", Request.Headers);
		theInfo += getList("Form", Request.Form);
		theInfo += getList("Server Variables", Request.ServerVariables);
		/*
		theInfo += "<br/>";
		terms = string.Empty;
		foreach(var key in Request.Headers.AllKeys)
			terms += $"({key}::{Request.Headers[key]})";
		theInfo += $"<li>Headers [{Request.Headers.Count} {terms}]</li>";

		theInfo += "<br/>";
		terms = string.Empty;
		foreach (var key in Request.Form.AllKeys)
			terms += $"({key}::{Request.Form[key]})";
		theInfo += $"<li>Form [{Request.Headers.Count} {terms}]</li>";

		theInfo += "<br/>";
		terms = string.Empty;
		foreach (var key in Request.ServerVariables.AllKeys)
			terms += $"({key}::{Request.ServerVariables[key]})";
		theInfo += $"<li>Form [{Request.ServerVariables.Count} {terms}]</li>";
		*/
		lblOutput.Text = theInfo;
	}

	private string getList(string name, System.Collections.Specialized.NameValueCollection collection) {
		string terms = string.Empty;
		foreach (var key in collection.AllKeys)
			terms += $"({key}::{collection[key]})";
		return $"<br/><li>{name} [{collection.Count} {terms}]</li>";

	}

	protected void btnGetFormData_Click(object sender, EventArgs e) {
		string txtName = Request.Form.Get("txtFirstName");
		lblOutput.Text = txtName;
	}
}
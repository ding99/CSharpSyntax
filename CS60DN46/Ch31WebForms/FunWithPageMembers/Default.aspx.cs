﻿using System;
using System.Text;

public partial class _Default : System.Web.UI.Page {

	void Page_Error(object sender, EventArgs e) {
		Response.Clear();
		Response.Write("I am sorry... I can't find a required file.<br>");
		Response.Write($"The error was : <b>{Server.GetLastError().Message }</b>");
		Server.ClearError();
	}

	protected void btnTriggerError_Click(object sender, EventArgs e) {
		System.IO.File.ReadAllText(@"E:\workFolder\AspNet\IDontExist.txt");
	}

	protected void Page_Load(object sender, EventArgs e) {
		Response.Write("Load event fired!");
	}

	protected void btnGetBrowserStats_Click(object sender, EventArgs e) {
		StringBuilder builder = new StringBuilder();
		builder.Append($"<li>Is the client AOL? {Request.Browser.AOL}</li>");
		builder.Append($"<li>Does the client support ActiveX? {Request.Browser.ActiveXControls}</li>");
		builder.Append($"<li>Is the client a Beta? {Request.Browser.Beta}</li>");
		builder.Append($"<li>Does the client support Java Applets? {Request.Browser.JavaApplets}</li>");
		builder.Append($"<li>Does the client support Cookies? {Request.Browser.Cookies}</li>");
		builder.Append($"<li>Does the client support VBScript? {Request.Browser.VBScript}</li>");
		builder.Append($"<li>What is the screen size? {Request.Browser.ScreenPixelsWidth} x {Request.Browser.ScreenPixelsHeight}</li>");

		builder.Append("<br/>");
		builder.Append($"<li>Text Name [{txtFirstName.Text}]</li>");
		builder.Append($"<li>Text Name (Get) [{Request.Form.Get("txtFirstName")}]</li>");
		builder.Append($"<li>Raw Url [{Request.RawUrl}]</li>");
		builder.Append($"<li>Request Type [{Request.RequestType}]</li>");
		builder.Append($"<li>Http Method [{Request.HttpMethod}]</li>");
		builder.Append($"<li>App Path [{Request.ApplicationPath}]</li>");
		builder.Append($"<li>User Host Address [{Request.UserHostAddress}]</li>");
		builder.Append($"<li>User Host Name [{Request.UserHostName}]</li>");
		builder.Append($"<li>User Agent [{Request.UserAgent}]</li>");

		builder.Append("<br/>");
		StringBuilder term = new StringBuilder();
		foreach (var cookie in Request.Cookies)
			term.Append($"({cookie})");
		builder.Append($"<li>Cookies [{Request.Cookies.Count}{(term.Length < 1 ? "" : " ")}{term}]</li>");

		builder.Append(getList("Query Strings", Request.QueryString));
		builder.Append(getList("Headers", Request.Headers));
		builder.Append(getList("Form", Request.Form));
		builder.Append(getList("Server Variables", Request.ServerVariables));

		lblOutput.Text = builder.ToString();
	}

	private string getList(string name, System.Collections.Specialized.NameValueCollection collection) {
		StringBuilder terms = new StringBuilder();
		foreach (var key in collection.AllKeys)
			terms.Append($"({key}::{collection[key]})");
		return $"<br/><li>{name} [{collection.Count}{(collection.Count == 0 ? "" : " ")}{terms}]</li>";

	}

	protected void btnGetFormData_Click(object sender, EventArgs e) {
		string txtName = Request.Form.Get("txtFirstName");
		lblOutput.Text = txtName;
	}

	protected void btnHttpResponse_Click(object sender, EventArgs e) {
		Response.Write("<b>My name is:</b><br>");
		Response.Write(Request.Form.Get("txtFirstName") +"<br><br>");
	}

	protected void Page_Unload(object sender, EventArgs e) {
		System.IO.File.WriteAllText(@"e:\workFolder\AspNet\mylog.txt", "Page unloading!");
	}
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page {
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
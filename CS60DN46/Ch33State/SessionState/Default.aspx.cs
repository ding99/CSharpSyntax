﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page {
	protected void Page_Load(object sender, EventArgs e) {
		lblID.Text = $"Here is your ID: {Session.SessionID}";
	}

	protected void btnSubmit_Click(object sender, EventArgs e) {
		var cart = (UserShoppingCart)Session["UserShoppingCartInfo"];
		cart.DateOfPickUp = myCalender.SelectedDate;
		cart.DesiredCar = txtMake.Text;
		cart.DesiredCarColor = txtColor.Text;
		cart.DownPayment = float.Parse(txtDownPay.Text);
		cart.IsLeasing = chkLease.Checked;
		lblInfo.Text = cart.ToString();
		Session["UserShoppingCartInfo"] = cart;
	}
}
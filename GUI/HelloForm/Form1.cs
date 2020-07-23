using System;
using System.Windows.Forms;

namespace HelloForm
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnClickThis_Click(object sender, EventArgs e)
		{
			lblHello.Text = "Hello WinForm!";
		}
	}
}

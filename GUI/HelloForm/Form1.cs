using System;
using System.Windows.Forms;

namespace HelloForm
{
	public partial class TopForm : Form
	{
		public TopForm()
		{
			InitializeComponent();
		}

		private void btnClickThis_Click(object sender, EventArgs e)
		{
			lblHello.Text = "Hello WinForm!";
		}
	}
}

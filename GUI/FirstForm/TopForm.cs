using System;
using System.Windows.Forms;

namespace FirstForm
{
	public partial class TopForm : Form
	{
		public TopForm()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnClickThis_Click(object sender, EventArgs e)
		{
			lblHello.Text = "Hello WinForm!";
		}
	}
}

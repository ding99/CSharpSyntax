using System;
using System.Windows.Forms;

namespace LinqToXmlWinApp {
	public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e) {
			txtInventory.Text = LinqToXmlObjectModel.GetXmlInventory().ToString();
		}

		private void btnAddNewItem_Click(object sender, EventArgs e) {
			LinqToXmlObjectModel.InsertNewElement(txtMake.Text, txtColor.Text, txtPetName.Text);

			txtInventory.Text = LinqToXmlObjectModel.GetXmlInventory().ToString();
		}

		private void btnLookUpColors_Click(object sender, EventArgs e) {
			LinqToXmlObjectModel.LookUpColorsForMake(txtMakeToLookUp.Text);
		}
	}
}

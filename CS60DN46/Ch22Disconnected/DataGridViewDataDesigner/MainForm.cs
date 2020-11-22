using System;
using System.Windows.Forms;

namespace DataGridViewDataDesigner {
	public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e) {
			// TODO: This line of code loads data into the 'inventoryDataSet.Inventory' table. You can move, or remove it, as needed.
			this.inventoryTableAdapter.Fill(this.inventoryDataSet.Inventory);

		}

		private void btnUpdateInventory_Click(object sender, EventArgs e) {
			try {
				this.inventoryTableAdapter.Update(this.inventoryDataSet.Inventory);
			} catch(Exception ex) { MessageBox.Show(ex.Message); }
		}
	}
}

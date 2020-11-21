using AutoLotDAL.DisconnectedLayer;
using System;
using System.Data;
using System.Windows.Forms;

namespace InventoryDALDisconnectedGUI {
	public partial class MainForm : Form {
		InventoryDALDC _dal = null;
		public MainForm() {
			InitializeComponent();

			string cnStr = @"Data Source=(local);Initial Catalog=AutoLot;Integrated Security=True;Pooling=False";
			_dal = new InventoryDALDC(cnStr);

			inventoryGrid.DataSource = _dal.GetAllInventory();
		}

		private void btnUpdateInventory_Click(object sender, EventArgs e){
			DataTable changedDT = (DataTable)inventoryGrid.DataSource;

			try {
				_dal.UpdateInventory(changedDT);
				inventoryGrid.DataSource = _dal.GetAllInventory();
			} catch(Exception ex) { MessageBox.Show(ex.Message); }
		}
	}
}

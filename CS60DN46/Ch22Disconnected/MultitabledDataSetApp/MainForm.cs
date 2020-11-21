using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.Configuration;

namespace MultitabledDataSetApp {
	public partial class MainForm : Form {
		private DataSet _autoLotDs = new DataSet("AutoLot");

		private SqlCommandBuilder _sqlCbInventory;
		private SqlCommandBuilder _sqlCbCustomers;
		private SqlCommandBuilder _sqlCbOrders;

		private SqlDataAdapter _invAdapter;
		private SqlDataAdapter _custAdapter;
		private SqlDataAdapter _ordAdapter;

		private string _connectionString;

		public MainForm() {
			InitializeComponent();

			_connectionString = ConfigurationManager.ConnectionStrings["AutoLotSqlProvider"].ConnectionString;

			_invAdapter = new SqlDataAdapter("Select * from Inventory", _connectionString);
			_custAdapter = new SqlDataAdapter("Select * from Customers", _connectionString);
			_ordAdapter = new SqlDataAdapter("Select * from Orders", _connectionString);

			_sqlCbInventory = new SqlCommandBuilder(_invAdapter);
			_sqlCbCustomers = new SqlCommandBuilder(_custAdapter);
			_sqlCbOrders = new SqlCommandBuilder(_ordAdapter);

			_invAdapter.Fill(_autoLotDs, "Inventory");
			_custAdapter.Fill(_autoLotDs, "Customers");
			_ordAdapter.Fill(_autoLotDs, "Orders");

			BuildTableRelationship();

			dataGridViewInventory.DataSource = _autoLotDs.Tables["Inventory"];
			dataGridViewCustomers.DataSource = _autoLotDs.Tables["Customers"];
			dataGridViewOrders.DataSource = _autoLotDs.Tables["Orders"];
		}

		private void BuildTableRelationship() {
			DataRelation dr = new DataRelation("CustomerOrder", _autoLotDs.Tables["Customers"].Columns["CustID"], _autoLotDs.Tables["Orders"].Columns["CustID"]);
			_autoLotDs.Relations.Add(dr);

			dr = new DataRelation("InventoryOrder", _autoLotDs.Tables["Inventory"].Columns["CarID"], _autoLotDs.Tables["Orders"].Columns["CarID"]);
			_autoLotDs.Relations.Add(dr);
		}

		private void btnUpdateDatabase_Click(object sender, EventArgs e) {
			try {
				_invAdapter.Update(_autoLotDs, "Inventory");
				_custAdapter.Update(_autoLotDs, "Customers");
				_ordAdapter.Update(_autoLotDs, "Orders");
			} catch(Exception ex) { MessageBox.Show(ex.Message);  }
		}
	}
}

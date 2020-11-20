using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDataBinding {
	public partial class MainForm : Form {

		List<Car> listCars = null;
		DataTable inventoryTable = new DataTable();

		public MainForm() {
			InitializeComponent();

			listCars = new List<Car> {
				new Car{ Id=1, PetName="Chucky", Make="BMW", Color="Green" },
				new Car{ Id=2, PetName="Tiny", Make="Yugo", Color="White" },
				new Car{ Id=3, PetName="Ami", Make="Jeep", Color="Tan" },
				new Car{ Id=4, PetName="Pain Inducer", Make="Caravan", Color="Pink" },
				new Car{ Id=5, PetName="Fred", Make="BMW", Color="Green" },
				new Car{ Id=6, PetName="Sidd", Make="BMW", Color="Black" },
				new Car{ Id=7, PetName="Mel", Make="Firebird", Color="Red" },
				new Car{ Id=8, PetName="Sarah", Make="Colt", Color="Black" }
			};

			CreateDataTable();
		}

		void CreateDataTable() {
			var carIDColumn = new DataColumn("Id", typeof(int));
			var carMakeColumn = new DataColumn("Make", typeof(string));
			var carColorColumn = new DataColumn("Color", typeof(string));
			var carPetNameColumn = new DataColumn("PetName", typeof(string)) { Caption = "Pet Name" };
			inventoryTable.Columns.AddRange(new[] {
				carIDColumn, carMakeColumn, carColorColumn, carPetNameColumn
			});

			foreach(var c in listCars) {
				var newRow = inventoryTable.NewRow();
				newRow["Id"] = c.Id;
				newRow["Make"] = c.Make;
				newRow["Color"] = c.Color;
				newRow["PetName"] = c.PetName;
				inventoryTable.Rows.Add(newRow);
			}

			carInventoryGridView.DataSource = inventoryTable;
		}

		private void btnRemoveCar_Click(object sender, EventArgs e) {
			try {
				DataRow[] rowToDelete = inventoryTable.Select($"Id={int.Parse(txtCarToRemove.Text)}");

				rowToDelete[0].Delete();
				inventoryTable.AcceptChanges();
			} catch(Exception ex) { MessageBox.Show(ex.Message); }
		}

		private void btnDisplayMakes_Click(object sender, EventArgs e) {
			string filter = $"Make='{txtMakeToView.Text}'";

			DataRow[] makes = inventoryTable.Select(filter, "PetName DESC");

			if (makes.Length == 0)
				MessageBox.Show("Sorry, no cars...", "Selection error!");
			else {
				string strMake = null;
				for (var i = 0; i < makes.Length; i++)
					strMake += makes[i]["PetName"] + "\n";
				MessageBox.Show(strMake, $"We have {txtMakeToView.Text}s named:");
			}
		}

		private void btnChangeMake_Click(object sender, EventArgs e) {
			string src = txtChangeMake.Text;
			if (DialogResult.Yes != MessageBox.Show($"Are you sure? {src} are much nicer than Yogos!", "Please Confirm!", MessageBoxButtons.YesNo)) return;
			string filterStr = $"Make='{src}'";

			DataRow[] makes = inventoryTable.Select(filterStr);
			for (int i = 0; i < makes.Length; i++)
				makes[i]["Make"] = "Yugo";
		}
	}
}

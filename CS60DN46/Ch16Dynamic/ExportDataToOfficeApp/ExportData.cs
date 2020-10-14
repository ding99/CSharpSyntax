using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExportDataToOfficeApp {
	public partial class ExportData : Form {
		List<Car> carsInStock = null;

		public ExportData() {
			InitializeComponent();
		}

		private void ExportData_Load(object sender, EventArgs e) {
			carsInStock = new List<Car> {
				new Car { Color = "Green", Make = "VW", Name = "Mary" },
				new Car { Color = "Red", Make = "Saab", Name = "Mel" },
				new Car { Color = "Black", Make = "Ford", Name = "Hank" },
				new Car { Color = "Yellow", Make = "BMW", Name = "Davie" }
			};
			UpdateGrid();
		}

		private void UpdateGrid() {
			//reset the source of data
			dataGridCars.DataSource = null;
			dataGridCars.DataSource = carsInStock;
		}

		private void btnAddNewCar_Click(object sender, EventArgs e) {
			NewCarDialog d = new NewCarDialog();
			if(d.ShowDialog() == DialogResult.OK) {
				carsInStock.Add(d.theCar);
				UpdateGrid();

			}
		}
	}
}

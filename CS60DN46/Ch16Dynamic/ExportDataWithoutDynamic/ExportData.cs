using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExportDataWithoutDynamic {
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
			if (d.ShowDialog() == DialogResult.OK) {
				carsInStock.Add(d.theCar);
				UpdateGrid();
			}
		}

		private void btnExportToExcel_Click(object sender, EventArgs e) {
			ExportToExcel2008(carsInStock);
		}

		static void ExportToExcel2008(List<Car> carsInStock) {
			Excel.Application excelApp = new Excel.Application();
			//make mark missing params!
			excelApp.Workbooks.Add(Type.Missing);

			//must cast Object as _Worksheet!
			Excel._Worksheet workSheet = (Excel._Worksheet)excelApp.ActiveSheet;

			//must cast each Object as Range object then
			//call low-level Value2 property
			((Excel.Range)excelApp.Cells[1, "A"]).Value2 = "Make";
			((Excel.Range)excelApp.Cells[1, "B"]).Value2 = "Color";
			((Excel.Range)excelApp.Cells[1, "C"]).Value2 = "Pet Name";

			//must cast each Object as Range and call low-level Value2 prop!
			int row = 1;
			foreach (Car c in carsInStock) {
				row++;
				((Excel.Range)workSheet.Cells[row, "A"]).Value2 = c.Make;
				((Excel.Range)workSheet.Cells[row, "B"]).Value2 = c.Color;
				((Excel.Range)workSheet.Cells[row, "C"]).Value2 = c.Name;
			}

			//must call get_Range method and then specify all missing args!
			excelApp.get_Range("A1", Type.Missing).AutoFormat(
				Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic2,
				Type.Missing, Type.Missing, Type.Missing,
				Type.Missing, Type.Missing, Type.Missing);

			//must specify all missing optional args!
			workSheet.SaveAs(string.Format(@"{0}\Inventory1.xlsx", Environment.CurrentDirectory),
				Type.Missing, Type.Missing, Type.Missing,
				Type.Missing, Type.Missing, Type.Missing,
				Type.Missing, Type.Missing, Type.Missing);

			excelApp.Quit();
			MessageBox.Show("The Inventory1.xslx file has been saved to your app folder", "Export completed!");
		}
	}
}

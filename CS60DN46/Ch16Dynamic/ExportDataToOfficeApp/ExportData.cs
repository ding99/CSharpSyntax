using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

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

		private void btnExportToExcel_Click(object sender, EventArgs e) {
			ExportToExcel(carsInStock);
		}

		static void ExportToExcel(List<Car> carsInStock) {
			//Load up Excel, then make a new empty workbook
			Excel.Application excelApp = new Excel.Application();
			//excelApp.Visible = true; //make excel visible on the computer
			excelApp.Workbooks.Add();

			//this example uses a single workSheet
			Excel._Worksheet workSheet = excelApp.ActiveSheet;

			//establish column headings in cells
			workSheet.Cells[1, "A"] = "Make";
			workSheet.Cells[1, "B"] = "Color";
			workSheet.Cells[1, "C"] = "Pet Name";

			//map all data in List<Car> to the cells of the spreadsheet
			int row = 1;
			foreach(Car c in carsInStock) {
				row++;
				workSheet.Cells[row, "A"] = c.Make;
				workSheet.Cells[row, "B"] = c.Color;
				workSheet.Cells[row, "C"] = c.Name;
			}

			//give our table data a nice look and fell
			workSheet.Range["A1"].AutoFormat(Excel.XlRangeAutoFormat.xlRangeAutoFormat3DEffects2);

			//save the file, quit Excel, and display message to user
			workSheet.SaveAs(string.Format(@"{0}\Inventory.xlsx", Environment.CurrentDirectory));
			excelApp.Quit();
			MessageBox.Show("The Inventory.xslx file has been saved to your app folder", "Export completed!");
		}
	}
}

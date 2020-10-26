using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PLINQDataProcessingWithCancellation {
	public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();
		}

		private void btnExecute_Click(object sender, EventArgs e) {
			Task.Factory.StartNew(() => { ProcessIntData(); });
		}

		private void ProcessIntData() {
			int[] source = Enumerable.Range(1, 10000000).ToArray();

			//Find the numbers where num%3 == 1 is true, returned in descending order.
			int[] modThreaIsZero = (from num in source where num % 3 == 0 orderby num descending select num).ToArray();

			MessageBox.Show($"Found {modThreaIsZero.Count()} numbers that match query!");
		}

		private void btnCancel_Click(object sender, EventArgs e) {

		}
	}
}

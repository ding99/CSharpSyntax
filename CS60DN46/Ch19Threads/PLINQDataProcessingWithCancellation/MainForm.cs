using System;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLINQDataProcessingWithCancellation {
	public partial class MainForm : Form {
		private CancellationTokenSource cancelToken = new CancellationTokenSource();
		public MainForm() {
			InitializeComponent();
		}

		private void btnExecute_Click(object sender, EventArgs e) {
			Task.Factory.StartNew(() => ProcessIntData());
		}

		private void ProcessIntData() {
			int[] source = Enumerable.Range(1, 100000000).ToArray();

			//Find the numbers where num%3 == 1 is true, returned in descending order.
			//int[] modThreaIsZero = (from num in source.AsParallel() where num % 3 == 0 orderby num descending select num).ToArray();
			int[] modThreaIsZero = null;
			try {
				modThreaIsZero = (from num in source.AsParallel().WithCancellation(cancelToken.Token) where num % 3 == 0 orderby num descending select num).ToArray();

				MessageBox.Show($"Found {modThreaIsZero.Count()} numbers that match query!");
			}
			catch (OperationCanceledException e) {
				this.Invoke((Action)delegate { this.Text = e.Message; });
			}
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			cancelToken.Cancel();
		}
	}
}

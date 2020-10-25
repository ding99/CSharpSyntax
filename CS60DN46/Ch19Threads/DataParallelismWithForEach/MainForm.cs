using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataParallelismWithForEach {
	public partial class MainForm : Form {

		private CancellationTokenSource cancelToken = new CancellationTokenSource();

		public MainForm() {
			InitializeComponent();
		}

		private void btnProcessImages_Click(object sender, EventArgs e) {
			Task.Factory.StartNew(() => ProcessFiles());
		}

		private void ProcessFiles() {
			ParallelOptions parOpts = new ParallelOptions();
			parOpts.CancellationToken = cancelToken.Token;
			parOpts.MaxDegreeOfParallelism = Environment.ProcessorCount;

			//load up all *.jpg files, and make a new folder for the modified data
			string[] files = Directory.GetFiles(@"E:\test\Parallel\Source", "*.jpg", SearchOption.AllDirectories);
			string newDir = @"E:\test\Parallel\Target";
			Directory.CreateDirectory(newDir);

			try {
				Parallel.ForEach(files, parOpts, file => {
					parOpts.CancellationToken.ThrowIfCancellationRequested();

					string name = Path.GetFileName(file);
					using (Bitmap bm = new Bitmap(file)) {
						bm.RotateFlip(RotateFlipType.Rotate180FlipNone);
						bm.Save(Path.Combine(newDir, name));
						this.Invoke((Action)delegate {
							this.Text = $"Processing {name} on thread {Thread.CurrentThread.ManagedThreadId}";
						});
					}
				});
			} catch(OperationCanceledException e) {
				this.Invoke((Action)delegate {
					this.Text = e.Message;
				});
			}
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			cancelToken.Cancel();
		}
	}
}

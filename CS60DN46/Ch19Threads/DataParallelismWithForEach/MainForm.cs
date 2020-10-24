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
using System.IO;

namespace DataParallelismWithForEach {
	public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();
		}

		private void btnProcessImages_Click(object sender, EventArgs e) { ProcessFiles(); }

		private void ProcessFiles() {
			//load up all *.jpg files, and make a new folder for the modified data
			string[] files = Directory.GetFiles(@"E:\test\Parallel\Source", "*.jpg", SearchOption.AllDirectories);
			string newDir = @"E:\test\Parallel\Target";
			Directory.CreateDirectory(newDir);

			Parallel.ForEach(files, file => {
				string name = Path.GetFileName(file);
				using (Bitmap bm = new Bitmap(file)) {
					bm.RotateFlip(RotateFlipType.Rotate180FlipNone);
					bm.Save(Path.Combine(newDir, name));

					//this.Text = string.Format($"Processing {name} on thread {Thread.CurrentThread.ManagedThreadId}");
					this.Invoke((Action)delegate {
						this.Text = $"Processing {name} on thread {Thread.CurrentThread.ManagedThreadId}";
					});
				}
			});
		}
	}
}

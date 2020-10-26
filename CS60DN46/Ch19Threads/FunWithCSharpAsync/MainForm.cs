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

namespace FunWithCSharpAsync {
	public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();
		}

		private void btnCallMethod_Click(object sender, EventArgs e) {
			this.Text = DoWork();
		}

		private string DoWork() {
			Thread.Sleep(10000);
			return "Done With work!";
		}
	}
}

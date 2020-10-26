using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunWithCSharpAsync {
	public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();
		}

		private async Task btnCallMethod_Click(object sender, EventArgs e) {
			this.Text = await DoWorkAsync();
		}

		private async Task<string> DoWorkAsync() {
			return await Task.Run(() => {
				Thread.Sleep(10000);
				return "Done With work!";
			});
		}
	}
}

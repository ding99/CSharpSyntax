using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunWithCSharpAsync {
	public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();
		}

		private async void btnCallMethod_Click(object sender, EventArgs e) {
			this.Text = await DoWorkAsync();
		}

		private async Task<string> DoWorkAsync() {
			return await Task.Run(() => {
				Thread.Sleep(10000);
				return "Done With work!";
			});
		}

		private async void btnVoidMethodCall_Click(object sender, EventArgs e) {
			await MethodReturningVoidAsync();
			MessageBox.Show("Done");
		}

		private async Task MethodReturningVoidAsync() {
			await Task.Run(() => Thread.Sleep(4000));
		}

		private async void btnMultiAwaits_Click(object sender, EventArgs e) {
			await Task.Run(() => Thread.Sleep(2000) );
			MessageBox.Show("Done with first task!");

			await Task.Run(() => Thread.Sleep(2000));
			MessageBox.Show("Done with second task!");

			await Task.Run(() => Thread.Sleep(2000));
			MessageBox.Show("Done with third task!");
		}
	}
}

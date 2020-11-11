using System.Windows;
using System.Windows.Controls;

namespace MyWordPad {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
		}

		protected void FileExit_Click(object sender, RoutedEventArgs e) {
			this.Close();
		}

		protected void ToolsSpellingHints_Click(object sender, RoutedEventArgs e) {
			string spellingHints = string.Empty;
			// Try to get a spelling error at the current caret location.
			SpellingError error = txtData.GetSpellingError(txtData.CaretIndex);
			if (error != null) {
				// Build a string of spelling suggestions.
				foreach (string s in error.Suggestions) {
					spellingHints += $"{s}\n";
				}
				// Show suggestions and expand the expander.
				lblSpellingHints.Content = spellingHints;
				expanderSpelling.IsExpanded = true;
			}
		}

		protected void MouseEnterExitArea(object sender, RoutedEventArgs e) {
			statBarText.Text = "Exit the Application";
		}

		protected void MouseLeaveArea(object sender, RoutedEventArgs e) {
			statBarText.Text = "Ready";
		}

		protected void MouseEnterToolsHintsArea(object sender, RoutedEventArgs e) {
			statBarText.Text = "Show Spelling Suggestions";
		}
	}
}

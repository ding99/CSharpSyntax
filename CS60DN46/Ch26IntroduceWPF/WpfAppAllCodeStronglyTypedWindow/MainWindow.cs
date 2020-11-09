using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfAppAllCodeStronglyTypedWindow {
	class MainWindow : Window {
		//Our UI element
		private Button btnExitApp = new Button();
		public MainWindow(string windowTitle, int height, int width) {
			//configure button and set the child control
			btnExitApp.Click += new RoutedEventHandler(btnExitApp_Clicked);
			btnExitApp.Content = "Exit Application";
			btnExitApp.Height = 25;
			btnExitApp.Width = 100;

			//set the content of this window to a single button
			this.Content = btnExitApp;

			this.Closing += MainWindow_Closing;
			this.Closed += MainWindow_CLosed;
			this.MouseMove += MainWindow_MouseMove;

			this.Title = windowTitle;
			this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
			this.Height = height;
			this.Width = width;
		}

		private void MainWindow_MouseMove(object sender, System.Windows.Input.MouseEventArgs e) {
			this.Title = e.GetPosition(this).ToString();
		}

		private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
			string msg = "Do you want to close without saving?";
			MessageBoxResult result = MessageBox.Show(msg, "My App", MessageBoxButton.YesNo, MessageBoxImage.Warning);
			if(result == MessageBoxResult.No) {
				e.Cancel = true;
			}
		}

		private void MainWindow_CLosed(object sender, EventArgs e) {
			MessageBox.Show("See ya!");
		}

		private void btnExitApp_Clicked(object sender, RoutedEventArgs e) {
			if ((bool)Application.Current.Properties["GodMode"])
				MessageBox.Show("Cheater!");
			//Close the window
			this.Close();
		}
	}
}

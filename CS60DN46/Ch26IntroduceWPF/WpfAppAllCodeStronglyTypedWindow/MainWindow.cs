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

			this.Title = windowTitle;
			this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
			this.Height = height;
			this.Width = width;
		}

		private void btnExitApp_Clicked(object sender, RoutedEventArgs e) {
			//Close the window
			this.Close();
		}
	}
}

using System.Windows;

namespace WpfAppAllCodeStronglyTypedWindow {
	class MainWindow : Window {
		public MainWindow(string windowTitle, int height, int width) {
			this.Title = windowTitle;
			this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
			this.Height = height;
			this.Width = width;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfAppAllCode {
	class Program : Application {
		[STAThread]
		static void Main() {
			//Handle the Startup and Exit events, and then run the application.
			Program app = new Program();
			app.Startup += AppStartUp;
			app.Exit += AppExit;
			app.Run();
		}

		static void AppExit(object sender, ExitEventArgs e) {
			MessageBox.Show("App has exited");
		}

		static void AppStartUp(object sender, StartupEventArgs e) {
			Window mainWindow = new Window();
			mainWindow.Title = "My First WPF App!";
			mainWindow.Height = 200;
			mainWindow.Width = 300;
			mainWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
			mainWindow.Show();
		}
	}
}

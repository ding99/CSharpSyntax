﻿using System;
using System.Configuration;
using System.Windows;

namespace WpfAppAllCodeStronglyTypedWindow {
	class Program : Application {
		[STAThread]
		static void Main(string[] args) {
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
			Application.Current.Properties["GodMode"] = false;
			foreach(string arg in e.Args) {
				if(arg.ToLower() == "/godmode") {
					Application.Current.Properties["GodMode"] = true;
					break;
				}
			}

			var main = new MainWindow("May better WPF APP!", 200, 300);
			main.Show();
		}
	}
}

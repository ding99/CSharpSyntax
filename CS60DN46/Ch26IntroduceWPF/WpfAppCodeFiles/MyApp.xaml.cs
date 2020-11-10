using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfAppAllXaml{
	public partial class MyApp : Application {
		public void AppExit(object sender, ExitEventArgs e){
			MessageBox.Show("App has exited");
		}
	}
}
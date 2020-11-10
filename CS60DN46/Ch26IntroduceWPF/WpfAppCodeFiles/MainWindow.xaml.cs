using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfAppAllXaml{
	public partial class MainWindow : Window{
		public MainWindow(){
			InitializeComponent();
		}

		private void btnExitApp_Clicked(object sender, RoutedEventArgs e){
			this.Close();
        }
	}
}
	
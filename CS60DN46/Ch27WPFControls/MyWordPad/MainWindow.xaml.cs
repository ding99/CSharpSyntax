﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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

		}

		protected void MouseEnterExitArea(object sender, RoutedEventArgs e) {

		}

		protected void MouseLeaveArea(object sender, RoutedEventArgs e) {

		}

		protected void MouseEnterToolsHintsArea(object sender, RoutedEventArgs e) {

		}
	}
}

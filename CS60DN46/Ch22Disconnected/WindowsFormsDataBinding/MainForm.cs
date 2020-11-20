﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDataBinding {
	public partial class MainForm : Form {

		List<Car> listCars = null;
		DataTable inventoryTable = new DataTable();

		public MainForm() {
			InitializeComponent();

			listCars = new List<Car> {
				new Car{ Id=1, PetName="Chucky", Make="BMW", Color="Green" },
				new Car{ Id=2, PetName="Tiny", Make="Yugo", Color="White" },
				new Car{ Id=3, PetName="Ami", Make="Jeep", Color="Tan" },
				new Car{ Id=4, PetName="Pain Inducer", Make="Caravan", Color="Pink" },
				new Car{ Id=5, PetName="Fred", Make="BMW", Color="Green" },
				new Car{ Id=6, PetName="Sidd", Make="BMW", Color="Black" },
				new Car{ Id=7, PetName="Mel", Make="Firebird", Color="Red" },
				new Car{ Id=8, PetName="Sarah", Make="Colt", Color="Black" },
			};
		}

		void CreateDataTable() {

		}
	}
}

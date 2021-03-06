﻿using System.Runtime.InteropServices;

namespace ExportDataWithoutDynamic {
	partial class ExportData {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.lblInstructions = new System.Windows.Forms.Label();
			this.dataGridCars = new System.Windows.Forms.DataGridView();
			this.btnAddNewCar = new System.Windows.Forms.Button();
			this.btnExportToExcel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridCars)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.lblInstructions.AutoSize = true;
			this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInstructions.Location = new System.Drawing.Point(15, 7);
			this.lblInstructions.Name = "label1";
			this.lblInstructions.Size = new System.Drawing.Size(148, 20);
			this.lblInstructions.TabIndex = 0;
			this.lblInstructions.Text = "Current Inventory";
			// 
			// dataGridCars
			// 
			this.dataGridCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridCars.Location = new System.Drawing.Point(19, 40);
			this.dataGridCars.Name = "dataGridCars";
			this.dataGridCars.Size = new System.Drawing.Size(498, 162);
			this.dataGridCars.TabIndex = 1;
			// 
			// button1
			// 
			this.btnAddNewCar.Location = new System.Drawing.Point(19, 227);
			this.btnAddNewCar.Name = "button1";
			this.btnAddNewCar.Size = new System.Drawing.Size(247, 23);
			this.btnAddNewCar.TabIndex = 2;
			this.btnAddNewCar.Text = "Add New Entry to Inventory";
			this.btnAddNewCar.UseVisualStyleBackColor = true;
			this.btnAddNewCar.Click += new System.EventHandler(this.btnAddNewCar_Click);
			// 
			// button2
			// 
			this.btnExportToExcel.Location = new System.Drawing.Point(272, 225);
			this.btnExportToExcel.Name = "button2";
			this.btnExportToExcel.Size = new System.Drawing.Size(246, 23);
			this.btnExportToExcel.TabIndex = 3;
			this.btnExportToExcel.Text = "Export Current Inventory to Excel";
			this.btnExportToExcel.UseVisualStyleBackColor = true;
			this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
			// 
			// ExportData
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(544, 281);
			this.Controls.Add(this.btnExportToExcel);
			this.Controls.Add(this.btnAddNewCar);
			this.Controls.Add(this.dataGridCars);
			this.Controls.Add(this.lblInstructions);
			this.Name = "ExportData";
			this.Text = "The Office COM Interop App !";
			((System.ComponentModel.ISupportInitialize)(this.dataGridCars)).EndInit();
			this.Load += new System.EventHandler(this.ExportData_Load);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Label lblInstructions;
		private System.Windows.Forms.DataGridView dataGridCars;
		private System.Windows.Forms.Button btnAddNewCar;
		private System.Windows.Forms.Button btnExportToExcel;
	}
}


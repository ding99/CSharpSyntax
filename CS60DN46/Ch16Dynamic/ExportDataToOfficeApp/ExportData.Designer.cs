namespace ExportDataToOfficeApp {
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
			this.dataGridCars = new System.Windows.Forms.DataGridView();
			this.btnAddNewCar = new System.Windows.Forms.Button();
			this.btnExportToExcel = new System.Windows.Forms.Button();
			this.lblInstructions = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridCars)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.lblInstructions.AutoSize = true;
			this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInstructions.Location = new System.Drawing.Point(13, 25);
			this.lblInstructions.Name = "label1";
			this.lblInstructions.Size = new System.Drawing.Size(148, 20);
			this.lblInstructions.TabIndex = 3;
			this.lblInstructions.Text = "Current Inventory";
			// 
			// dataGridCars
			// 
			this.dataGridCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridCars.Location = new System.Drawing.Point(12, 67);
			this.dataGridCars.Name = "dataGridCars";
			this.dataGridCars.Size = new System.Drawing.Size(616, 214);
			this.dataGridCars.TabIndex = 0;
			// 
			// btnAddNewCar
			// 
			this.btnAddNewCar.Location = new System.Drawing.Point(13, 303);
			this.btnAddNewCar.Name = "btnAddNewCar";
			this.btnAddNewCar.Size = new System.Drawing.Size(296, 31);
			this.btnAddNewCar.TabIndex = 1;
			this.btnAddNewCar.Text = "Add New Entry to Inventory";
			this.btnAddNewCar.UseVisualStyleBackColor = true;
			this.btnAddNewCar.Click += new System.EventHandler(this.btnAddNewCar_Click);
			// 
			// btnExportToExcel
			// 
			this.btnExportToExcel.Location = new System.Drawing.Point(354, 302);
			this.btnExportToExcel.Name = "btnExportToExcel";
			this.btnExportToExcel.Size = new System.Drawing.Size(274, 31);
			this.btnExportToExcel.TabIndex = 2;
			this.btnExportToExcel.Text = "Export Current Inventory to Excel";
			this.btnExportToExcel.UseVisualStyleBackColor = true;
			this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
			// 
			// ExportData
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(640, 360);
			this.Controls.Add(this.lblInstructions);
			this.Controls.Add(this.btnExportToExcel);
			this.Controls.Add(this.btnAddNewCar);
			this.Controls.Add(this.dataGridCars);
			this.Name = "ExportData";
			this.Text = "The Office COM Interop App!";
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


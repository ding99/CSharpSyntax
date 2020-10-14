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
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridCars = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridCars)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(15, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(148, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Current Inventory";
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
			this.button1.Location = new System.Drawing.Point(19, 227);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(247, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Add New Entry to Inventory";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(272, 225);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(246, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Export Current Inventory to Excel";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// ExportData
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(544, 281);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dataGridCars);
			this.Controls.Add(this.label1);
			this.Name = "ExportData";
			this.Text = "Export Data Without Dynamic !";
			((System.ComponentModel.ISupportInitialize)(this.dataGridCars)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridCars;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}


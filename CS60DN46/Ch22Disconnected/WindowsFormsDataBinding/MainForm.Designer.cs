
namespace WindowsFormsDataBinding {
	partial class MainForm {
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
			this.carInventoryGridView = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCarToRemove = new System.Windows.Forms.TextBox();
			this.btnRemoveCar = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.carInventoryGridView)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// carInventoryGridView
			// 
			this.carInventoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.carInventoryGridView.Location = new System.Drawing.Point(12, 51);
			this.carInventoryGridView.Name = "carInventoryGridView";
			this.carInventoryGridView.Size = new System.Drawing.Size(464, 219);
			this.carInventoryGridView.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(287, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Here is what we have in stock";
			// 
			// txtCarToRemove
			// 
			this.txtCarToRemove.Location = new System.Drawing.Point(9, 25);
			this.txtCarToRemove.Name = "txtCarToRemove";
			this.txtCarToRemove.Size = new System.Drawing.Size(100, 20);
			this.txtCarToRemove.TabIndex = 2;
			// 
			// btnRemoveCar
			// 
			this.btnRemoveCar.Location = new System.Drawing.Point(137, 25);
			this.btnRemoveCar.Name = "btnRemoveCar";
			this.btnRemoveCar.Size = new System.Drawing.Size(96, 23);
			this.btnRemoveCar.TabIndex = 3;
			this.btnRemoveCar.Text = "Delete!";
			this.btnRemoveCar.UseVisualStyleBackColor = true;
			this.btnRemoveCar.Click += new System.EventHandler(this.btnRemoveCar_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtCarToRemove);
			this.groupBox1.Controls.Add(this.btnRemoveCar);
			this.groupBox1.Location = new System.Drawing.Point(13, 277);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(463, 58);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Enter ID of Car to Delete";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(488, 347);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.carInventoryGridView);
			this.Name = "MainForm";
			this.Text = "Windows Forms Data Binding";
			((System.ComponentModel.ISupportInitialize)(this.carInventoryGridView)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView carInventoryGridView;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCarToRemove;
		private System.Windows.Forms.Button btnRemoveCar;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}


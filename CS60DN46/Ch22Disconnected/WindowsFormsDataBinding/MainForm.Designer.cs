
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnDisplayMakes = new System.Windows.Forms.Button();
			this.txtMakeToView = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtChangeMake = new System.Windows.Forms.TextBox();
			this.btnChangeMake = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.carInventoryGridView)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
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
			this.txtCarToRemove.Size = new System.Drawing.Size(92, 20);
			this.txtCarToRemove.TabIndex = 2;
			// 
			// btnRemoveCar
			// 
			this.btnRemoveCar.Location = new System.Drawing.Point(9, 51);
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
			this.groupBox1.Size = new System.Drawing.Size(154, 83);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Enter ID of Car to Delete";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnDisplayMakes);
			this.groupBox2.Controls.Add(this.txtMakeToView);
			this.groupBox2.Location = new System.Drawing.Point(173, 277);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(134, 83);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Enter Make to View";
			// 
			// btnDisplayMakes
			// 
			this.btnDisplayMakes.Location = new System.Drawing.Point(6, 51);
			this.btnDisplayMakes.Name = "btnDisplayMakes";
			this.btnDisplayMakes.Size = new System.Drawing.Size(99, 22);
			this.btnDisplayMakes.TabIndex = 1;
			this.btnDisplayMakes.Text = "View!";
			this.btnDisplayMakes.UseVisualStyleBackColor = true;
			this.btnDisplayMakes.Click += new System.EventHandler(this.btnDisplayMakes_Click);
			// 
			// txtMakeToView
			// 
			this.txtMakeToView.Location = new System.Drawing.Point(6, 26);
			this.txtMakeToView.Name = "txtMakeToView";
			this.txtMakeToView.Size = new System.Drawing.Size(96, 20);
			this.txtMakeToView.TabIndex = 0;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnChangeMake);
			this.groupBox3.Controls.Add(this.txtChangeMake);
			this.groupBox3.Location = new System.Drawing.Point(318, 277);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(157, 85);
			this.groupBox3.TabIndex = 6;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Change to Yugo";
			// 
			// txtChangeMake
			// 
			this.txtChangeMake.Location = new System.Drawing.Point(7, 25);
			this.txtChangeMake.Name = "txtChangeMake";
			this.txtChangeMake.Size = new System.Drawing.Size(103, 20);
			this.txtChangeMake.TabIndex = 0;
			// 
			// btnChangeMake
			// 
			this.btnChangeMake.Location = new System.Drawing.Point(7, 51);
			this.btnChangeMake.Name = "btnChangeMake";
			this.btnChangeMake.Size = new System.Drawing.Size(103, 23);
			this.btnChangeMake.TabIndex = 1;
			this.btnChangeMake.Text = "Change!";
			this.btnChangeMake.UseVisualStyleBackColor = true;
			this.btnChangeMake.Click += new System.EventHandler(this.btnChangeMake_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(488, 374);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.carInventoryGridView);
			this.Name = "MainForm";
			this.Text = "Windows Forms Data Binding";
			((System.ComponentModel.ISupportInitialize)(this.carInventoryGridView)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView carInventoryGridView;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCarToRemove;
		private System.Windows.Forms.Button btnRemoveCar;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnDisplayMakes;
		private System.Windows.Forms.TextBox txtMakeToView;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btnChangeMake;
		private System.Windows.Forms.TextBox txtChangeMake;
	}
}


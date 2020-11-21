
namespace MultitabledDataSetApp {
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
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridViewInventory = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
			this.btnUpdateDatabase = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Current Inventory";
			// 
			// dataGridViewInventory
			// 
			this.dataGridViewInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewInventory.Location = new System.Drawing.Point(12, 25);
			this.dataGridViewInventory.Name = "dataGridViewInventory";
			this.dataGridViewInventory.Size = new System.Drawing.Size(473, 171);
			this.dataGridViewInventory.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(9, 199);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(134, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Current Customers";
			// 
			// dataGridViewCustomers
			// 
			this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewCustomers.Location = new System.Drawing.Point(15, 218);
			this.dataGridViewCustomers.Name = "dataGridViewCustomers";
			this.dataGridViewCustomers.Size = new System.Drawing.Size(470, 112);
			this.dataGridViewCustomers.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 333);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(108, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Current Orders";
			// 
			// dataGridViewOrders
			// 
			this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewOrders.Location = new System.Drawing.Point(12, 352);
			this.dataGridViewOrders.Name = "dataGridViewOrders";
			this.dataGridViewOrders.Size = new System.Drawing.Size(473, 112);
			this.dataGridViewOrders.TabIndex = 5;
			// 
			// btnUpdateDatabase
			// 
			this.btnUpdateDatabase.Location = new System.Drawing.Point(340, 470);
			this.btnUpdateDatabase.Name = "btnUpdateDatabase";
			this.btnUpdateDatabase.Size = new System.Drawing.Size(145, 27);
			this.btnUpdateDatabase.TabIndex = 6;
			this.btnUpdateDatabase.Text = "Update Database";
			this.btnUpdateDatabase.UseVisualStyleBackColor = true;
			this.btnUpdateDatabase.Click += new System.EventHandler(this.btnUpdateDatabase_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(495, 503);
			this.Controls.Add(this.btnUpdateDatabase);
			this.Controls.Add(this.dataGridViewOrders);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dataGridViewCustomers);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridViewInventory);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "AutoLot Database Multipulator";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridViewInventory;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridViewCustomers;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dataGridViewOrders;
		private System.Windows.Forms.Button btnUpdateDatabase;
	}
}


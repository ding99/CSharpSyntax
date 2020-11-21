
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtCustID = new System.Windows.Forms.TextBox();
			this.btnGetOrderInfo = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
			this.groupBox1.SuspendLayout();
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
			this.dataGridViewInventory.Size = new System.Drawing.Size(473, 156);
			this.dataGridViewInventory.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(9, 182);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(134, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Current Customers";
			// 
			// dataGridViewCustomers
			// 
			this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewCustomers.Location = new System.Drawing.Point(15, 201);
			this.dataGridViewCustomers.Name = "dataGridViewCustomers";
			this.dataGridViewCustomers.Size = new System.Drawing.Size(470, 102);
			this.dataGridViewCustomers.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 303);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(108, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Current Orders";
			// 
			// dataGridViewOrders
			// 
			this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewOrders.Location = new System.Drawing.Point(12, 322);
			this.dataGridViewOrders.Name = "dataGridViewOrders";
			this.dataGridViewOrders.Size = new System.Drawing.Size(473, 112);
			this.dataGridViewOrders.TabIndex = 5;
			// 
			// btnUpdateDatabase
			// 
			this.btnUpdateDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdateDatabase.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.btnUpdateDatabase.Location = new System.Drawing.Point(392, 441);
			this.btnUpdateDatabase.Name = "btnUpdateDatabase";
			this.btnUpdateDatabase.Size = new System.Drawing.Size(91, 50);
			this.btnUpdateDatabase.TabIndex = 6;
			this.btnUpdateDatabase.Text = "Update Database";
			this.btnUpdateDatabase.UseVisualStyleBackColor = true;
			this.btnUpdateDatabase.Click += new System.EventHandler(this.btnUpdateDatabase_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.btnGetOrderInfo);
			this.groupBox1.Controls.Add(this.txtCustID);
			this.groupBox1.Location = new System.Drawing.Point(12, 441);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(323, 50);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Lookup Customer Order";
			// 
			// txtCustID
			// 
			this.txtCustID.Location = new System.Drawing.Point(99, 22);
			this.txtCustID.Name = "txtCustID";
			this.txtCustID.Size = new System.Drawing.Size(78, 20);
			this.txtCustID.TabIndex = 0;
			// 
			// btnGetOrderInfo
			// 
			this.btnGetOrderInfo.Location = new System.Drawing.Point(193, 21);
			this.btnGetOrderInfo.Name = "btnGetOrderInfo";
			this.btnGetOrderInfo.Size = new System.Drawing.Size(111, 21);
			this.btnGetOrderInfo.TabIndex = 1;
			this.btnGetOrderInfo.Text = "Get Order Details";
			this.btnGetOrderInfo.UseVisualStyleBackColor = true;
			this.btnGetOrderInfo.Click += new System.EventHandler(this.btnGetOrderInfo_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(9, 23);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 16);
			this.label4.TabIndex = 2;
			this.label4.Text = "Customer ID:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(495, 503);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnUpdateDatabase);
			this.Controls.Add(this.dataGridViewOrders);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dataGridViewCustomers);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridViewInventory);
			this.Controls.Add(this.label1);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Name = "MainForm";
			this.Text = "AutoLot Database Multipulator";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
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
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnGetOrderInfo;
		private System.Windows.Forms.TextBox txtCustID;
	}
}



namespace InventoryDALDisconnectedGUI {
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
			this.inventoryGrid = new System.Windows.Forms.DataGridView();
			this.btnUpdateInventory = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.inventoryGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(197, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Data of Inventory Table";
			// 
			// inventoryGrid
			// 
			this.inventoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.inventoryGrid.Location = new System.Drawing.Point(15, 36);
			this.inventoryGrid.Name = "inventoryGrid";
			this.inventoryGrid.Size = new System.Drawing.Size(507, 271);
			this.inventoryGrid.TabIndex = 1;
			// 
			// btnUpdateInventory
			// 
			this.btnUpdateInventory.Location = new System.Drawing.Point(181, 322);
			this.btnUpdateInventory.Name = "btnUpdateInventory";
			this.btnUpdateInventory.Size = new System.Drawing.Size(182, 31);
			this.btnUpdateInventory.TabIndex = 2;
			this.btnUpdateInventory.Text = "Update Inventory";
			this.btnUpdateInventory.UseVisualStyleBackColor = true;
			this.btnUpdateInventory.Click += new System.EventHandler(this.btnUpdateInventory_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(535, 378);
			this.Controls.Add(this.btnUpdateInventory);
			this.Controls.Add(this.inventoryGrid);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Simple GUI Front End to the Inventory Table";
			((System.ComponentModel.ISupportInitialize)(this.inventoryGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView inventoryGrid;
		private System.Windows.Forms.Button btnUpdateInventory;
	}
}


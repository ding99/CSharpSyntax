
namespace DataGridViewDataDesigner {
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
			this.components = new System.ComponentModel.Container();
			this.inventoryDataGridView = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.inventoryDataSet = new DataGridViewDataDesigner.InventoryDataSet();
			this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.inventoryTableAdapter = new DataGridViewDataDesigner.InventoryDataSetTableAdapters.InventoryTableAdapter();
			this.carIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.makeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.petNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// inventoryDataGridView
			// 
			this.inventoryDataGridView.AutoGenerateColumns = false;
			this.inventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.inventoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carIdDataGridViewTextBoxColumn,
            this.makeDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.petNameDataGridViewTextBoxColumn});
			this.inventoryDataGridView.DataSource = this.inventoryBindingSource;
			this.inventoryDataGridView.Location = new System.Drawing.Point(9, 35);
			this.inventoryDataGridView.Name = "inventoryDataGridView";
			this.inventoryDataGridView.Size = new System.Drawing.Size(441, 289);
			this.inventoryDataGridView.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(295, 341);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(159, 26);
			this.button1.TabIndex = 1;
			this.button1.Text = "Update";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// inventoryDataSet
			// 
			this.inventoryDataSet.DataSetName = "InventoryDataSet";
			this.inventoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// inventoryBindingSource
			// 
			this.inventoryBindingSource.DataMember = "Inventory";
			this.inventoryBindingSource.DataSource = this.inventoryDataSet;
			// 
			// inventoryTableAdapter
			// 
			this.inventoryTableAdapter.ClearBeforeFill = true;
			// 
			// carIdDataGridViewTextBoxColumn
			// 
			this.carIdDataGridViewTextBoxColumn.DataPropertyName = "CarId";
			this.carIdDataGridViewTextBoxColumn.HeaderText = "CarId";
			this.carIdDataGridViewTextBoxColumn.Name = "carIdDataGridViewTextBoxColumn";
			this.carIdDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// makeDataGridViewTextBoxColumn
			// 
			this.makeDataGridViewTextBoxColumn.DataPropertyName = "Make";
			this.makeDataGridViewTextBoxColumn.HeaderText = "Make";
			this.makeDataGridViewTextBoxColumn.Name = "makeDataGridViewTextBoxColumn";
			// 
			// colorDataGridViewTextBoxColumn
			// 
			this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
			this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
			this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
			// 
			// petNameDataGridViewTextBoxColumn
			// 
			this.petNameDataGridViewTextBoxColumn.DataPropertyName = "PetName";
			this.petNameDataGridViewTextBoxColumn.HeaderText = "PetName";
			this.petNameDataGridViewTextBoxColumn.Name = "petNameDataGridViewTextBoxColumn";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(462, 382);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.inventoryDataGridView);
			this.Name = "MainForm";
			this.Text = "Windows Forms Data Wizerds";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.inventoryDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView inventoryDataGridView;
		private System.Windows.Forms.Button button1;
		private InventoryDataSet inventoryDataSet;
		private System.Windows.Forms.BindingSource inventoryBindingSource;
		private InventoryDataSetTableAdapters.InventoryTableAdapter inventoryTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn carIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn makeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn petNameDataGridViewTextBoxColumn;
	}
}


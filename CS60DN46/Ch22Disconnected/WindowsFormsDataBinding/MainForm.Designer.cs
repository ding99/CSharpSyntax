
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
			((System.ComponentModel.ISupportInitialize)(this.carInventoryGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// carInventoryGridView
			// 
			this.carInventoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.carInventoryGridView.Location = new System.Drawing.Point(12, 51);
			this.carInventoryGridView.Name = "carInventoryGridView";
			this.carInventoryGridView.Size = new System.Drawing.Size(464, 233);
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
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(488, 296);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.carInventoryGridView);
			this.Name = "MainForm";
			this.Text = "Windows Forms Data Binding";
			((System.ComponentModel.ISupportInitialize)(this.carInventoryGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView carInventoryGridView;
		private System.Windows.Forms.Label label1;
	}
}


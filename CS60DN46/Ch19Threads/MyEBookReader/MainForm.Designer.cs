namespace MyEBookReader {
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
			this.txtBook = new System.Windows.Forms.TextBox();
			this.btnDownload = new System.Windows.Forms.Button();
			this.btnGetStart = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtBook
			// 
			this.txtBook.Location = new System.Drawing.Point(12, 46);
			this.txtBook.Multiline = true;
			this.txtBook.Name = "txtBook";
			this.txtBook.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtBook.Size = new System.Drawing.Size(456, 262);
			this.txtBook.TabIndex = 0;
			// 
			// btnDownload
			// 
			this.btnDownload.Location = new System.Drawing.Point(12, 12);
			this.btnDownload.Name = "btnDownload";
			this.btnDownload.Size = new System.Drawing.Size(141, 24);
			this.btnDownload.TabIndex = 1;
			this.btnDownload.Text = "Download";
			this.btnDownload.UseVisualStyleBackColor = true;
			this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
			// 
			// btnGetStart
			// 
			this.btnGetStart.Location = new System.Drawing.Point(321, 12);
			this.btnGetStart.Name = "btnGetStart";
			this.btnGetStart.Size = new System.Drawing.Size(147, 24);
			this.btnGetStart.TabIndex = 2;
			this.btnGetStart.Text = "Extraction";
			this.btnGetStart.UseVisualStyleBackColor = true;
			this.btnGetStart.Click += new System.EventHandler(this.btnGetStart_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(480, 320);
			this.Controls.Add(this.btnGetStart);
			this.Controls.Add(this.btnDownload);
			this.Controls.Add(this.txtBook);
			this.Name = "MainForm";
			this.Text = "EBook Reader";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtBook;
		private System.Windows.Forms.Button btnDownload;
		private System.Windows.Forms.Button btnGetStart;
	}
}


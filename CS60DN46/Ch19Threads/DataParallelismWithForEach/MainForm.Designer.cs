﻿namespace DataParallelismWithForEach {
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnProcessImages = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 23);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(456, 20);
			this.textBox1.TabIndex = 0;
			// 
			// btnProcessImages
			// 
			this.btnProcessImages.Location = new System.Drawing.Point(129, 64);
			this.btnProcessImages.Name = "btnProcessImages";
			this.btnProcessImages.Size = new System.Drawing.Size(236, 36);
			this.btnProcessImages.TabIndex = 1;
			this.btnProcessImages.Text = "Process Images";
			this.btnProcessImages.UseVisualStyleBackColor = true;
			this.btnProcessImages.Click += new System.EventHandler(this.btnProcessImages_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(480, 120);
			this.Controls.Add(this.btnProcessImages);
			this.Controls.Add(this.textBox1);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btnProcessImages;
	}
}


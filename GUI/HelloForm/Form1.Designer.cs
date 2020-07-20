namespace HelloForm
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnClickThis = new System.Windows.Forms.Button();
			this.lblHello = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnClickThis
			// 
			this.btnClickThis.Location = new System.Drawing.Point(59, 52);
			this.btnClickThis.Name = "btnClickThis";
			this.btnClickThis.Size = new System.Drawing.Size(75, 23);
			this.btnClickThis.TabIndex = 0;
			this.btnClickThis.Text = "Click This";
			this.btnClickThis.UseVisualStyleBackColor = true;
			this.btnClickThis.Click += new System.EventHandler(this.btnClickThis_Click);
			// 
			// lblHello
			// 
			this.lblHello.AutoSize = true;
			this.lblHello.Location = new System.Drawing.Point(59, 104);
			this.lblHello.Name = "lblHello";
			this.lblHello.Size = new System.Drawing.Size(35, 13);
			this.lblHello.TabIndex = 1;
			this.lblHello.Text = "label1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(216, 230);
			this.Controls.Add(this.lblHello);
			this.Controls.Add(this.btnClickThis);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnClickThis;
		private System.Windows.Forms.Label lblHello;
	}
}


namespace FunWithCSharpAsync {
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
			this.btnCallMethod = new System.Windows.Forms.Button();
			this.txtInput = new System.Windows.Forms.TextBox();
			this.btnVoidMethodCall = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnCallMethod
			// 
			this.btnCallMethod.Location = new System.Drawing.Point(29, 48);
			this.btnCallMethod.Name = "btnCallMethod";
			this.btnCallMethod.Size = new System.Drawing.Size(261, 25);
			this.btnCallMethod.TabIndex = 0;
			this.btnCallMethod.Text = "CallMethod";
			this.btnCallMethod.UseVisualStyleBackColor = true;
			this.btnCallMethod.Click += new System.EventHandler(this.btnCallMethod_Click);
			// 
			// txtInput
			// 
			this.txtInput.Location = new System.Drawing.Point(29, 12);
			this.txtInput.Name = "txtInput";
			this.txtInput.Size = new System.Drawing.Size(261, 20);
			this.txtInput.TabIndex = 1;
			// 
			// btnVoidMethodCall
			// 
			this.btnVoidMethodCall.Location = new System.Drawing.Point(29, 79);
			this.btnVoidMethodCall.Name = "btnVoidMethodCall";
			this.btnVoidMethodCall.Size = new System.Drawing.Size(261, 23);
			this.btnVoidMethodCall.TabIndex = 2;
			this.btnVoidMethodCall.Text = "VoidMethodCall";
			this.btnVoidMethodCall.UseVisualStyleBackColor = true;
			this.btnVoidMethodCall.Click += new System.EventHandler(this.btnVoidMethodCall_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(320, 180);
			this.Controls.Add(this.btnVoidMethodCall);
			this.Controls.Add(this.txtInput);
			this.Controls.Add(this.btnCallMethod);
			this.Name = "MainForm";
			this.Text = "Asynchronous App";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCallMethod;
		private System.Windows.Forms.TextBox txtInput;
		private System.Windows.Forms.Button btnVoidMethodCall;
	}
}


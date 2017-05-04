namespace Database_Project
{
	partial class MainWindow
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
			this.hello_label = new System.Windows.Forms.Label();
			this.search_button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// hello_label
			// 
			this.hello_label.AutoSize = true;
			this.hello_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hello_label.Location = new System.Drawing.Point(33, 26);
			this.hello_label.Name = "hello_label";
			this.hello_label.Size = new System.Drawing.Size(69, 24);
			this.hello_label.TabIndex = 0;
			this.hello_label.Text = "Hello,  ";
			// 
			// search_button
			// 
			this.search_button.Location = new System.Drawing.Point(12, 255);
			this.search_button.Name = "search_button";
			this.search_button.Size = new System.Drawing.Size(114, 64);
			this.search_button.TabIndex = 1;
			this.search_button.Text = "Search";
			this.search_button.UseVisualStyleBackColor = true;
			this.search_button.Click += new System.EventHandler(this.search_button_Click);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(425, 331);
			this.Controls.Add(this.search_button);
			this.Controls.Add(this.hello_label);
			this.Name = "MainWindow";
			this.Text = "MainWindow";
			this.Load += new System.EventHandler(this.MainWindow_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label hello_label;
		private System.Windows.Forms.Button search_button;
	}
}
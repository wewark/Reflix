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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.hello_label = new System.Windows.Forms.Label();
            this.search_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.view_button = new System.Windows.Forms.Button();
            this.return_button = new System.Windows.Forms.Button();
            this.Credits_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.search_button.Location = new System.Drawing.Point(37, 74);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(108, 40);
            this.search_button.TabIndex = 1;
            this.search_button.Text = "Search and Rent";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(163, 74);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(108, 40);
            this.update_button.TabIndex = 2;
            this.update_button.Text = "Update your data";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // view_button
            // 
            this.view_button.Location = new System.Drawing.Point(37, 120);
            this.view_button.Name = "view_button";
            this.view_button.Size = new System.Drawing.Size(108, 40);
            this.view_button.TabIndex = 3;
            this.view_button.Text = "View The Movies ";
            this.view_button.UseVisualStyleBackColor = true;
            this.view_button.Click += new System.EventHandler(this.view_button_Click);
            // 
            // return_button
            // 
            this.return_button.Location = new System.Drawing.Point(163, 120);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(108, 40);
            this.return_button.TabIndex = 5;
            this.return_button.Text = "Rented and Return";
            this.return_button.UseVisualStyleBackColor = true;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // Credits_button
            // 
            this.Credits_button.Location = new System.Drawing.Point(101, 169);
            this.Credits_button.Name = "Credits_button";
            this.Credits_button.Size = new System.Drawing.Size(108, 40);
            this.Credits_button.TabIndex = 6;
            this.Credits_button.Text = "Credits";
            this.Credits_button.UseVisualStyleBackColor = true;
            this.Credits_button.Click += new System.EventHandler(this.Credits_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 197);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 324);
            this.Controls.Add(this.Credits_button);
            this.Controls.Add(this.return_button);
            this.Controls.Add(this.view_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.hello_label);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label hello_label;
		private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button view_button;
        private System.Windows.Forms.Button return_button;
        private System.Windows.Forms.Button Credits_button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
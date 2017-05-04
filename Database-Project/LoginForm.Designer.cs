namespace Database_Project
{
	partial class LoginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.username_textBox = new System.Windows.Forms.TextBox();
			this.password_textBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.login_button = new System.Windows.Forms.Button();
			this.register_button = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.err_label = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// username_textBox
			// 
			this.username_textBox.Location = new System.Drawing.Point(164, 132);
			this.username_textBox.Name = "username_textBox";
			this.username_textBox.Size = new System.Drawing.Size(100, 20);
			this.username_textBox.TabIndex = 0;
			// 
			// password_textBox
			// 
			this.password_textBox.Location = new System.Drawing.Point(164, 158);
			this.password_textBox.Name = "password_textBox";
			this.password_textBox.Size = new System.Drawing.Size(100, 20);
			this.password_textBox.TabIndex = 1;
			this.password_textBox.UseSystemPasswordChar = true;
			this.password_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_textBox_KeyDown);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(103, 135);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Username";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(105, 161);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Password";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// login_button
			// 
			this.login_button.Location = new System.Drawing.Point(103, 224);
			this.login_button.Name = "login_button";
			this.login_button.Size = new System.Drawing.Size(75, 23);
			this.login_button.TabIndex = 2;
			this.login_button.Text = "Login";
			this.login_button.UseVisualStyleBackColor = true;
			this.login_button.Click += new System.EventHandler(this.login_button_Click);
			// 
			// register_button
			// 
			this.register_button.Location = new System.Drawing.Point(184, 224);
			this.register_button.Name = "register_button";
			this.register_button.Size = new System.Drawing.Size(75, 23);
			this.register_button.TabIndex = 3;
			this.register_button.Text = "Register";
			this.register_button.UseVisualStyleBackColor = true;
			this.register_button.Click += new System.EventHandler(this.register_button_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(84, -5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(200, 200);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// err_label
			// 
			this.err_label.AutoSize = true;
			this.err_label.ForeColor = System.Drawing.Color.Red;
			this.err_label.Location = new System.Drawing.Point(143, 198);
			this.err_label.Name = "err_label";
			this.err_label.Size = new System.Drawing.Size(0, 13);
			this.err_label.TabIndex = 5;
			this.err_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(346, 287);
			this.Controls.Add(this.err_label);
			this.Controls.Add(this.register_button);
			this.Controls.Add(this.login_button);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.password_textBox);
			this.Controls.Add(this.username_textBox);
			this.Controls.Add(this.pictureBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "LoginForm";
			this.Text = "Reflix";
			this.Load += new System.EventHandler(this.LoginForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox username_textBox;
		private System.Windows.Forms.TextBox password_textBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button login_button;
		private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label err_label;
	}
}


namespace Database_Project
{
	partial class AddMovieForm
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
			this.name_textBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.year_textBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.director_textBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.actor1_textBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.actor2_textBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.price_textBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.category_textBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.add_button = new System.Windows.Forms.Button();
			this.err_label = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// name_textBox
			// 
			this.name_textBox.Location = new System.Drawing.Point(90, 22);
			this.name_textBox.Name = "name_textBox";
			this.name_textBox.Size = new System.Drawing.Size(180, 20);
			this.name_textBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(49, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Name";
			// 
			// year_textBox
			// 
			this.year_textBox.Location = new System.Drawing.Point(90, 48);
			this.year_textBox.Name = "year_textBox";
			this.year_textBox.Size = new System.Drawing.Size(180, 20);
			this.year_textBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(55, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Year";
			// 
			// director_textBox
			// 
			this.director_textBox.Location = new System.Drawing.Point(90, 100);
			this.director_textBox.Name = "director_textBox";
			this.director_textBox.Size = new System.Drawing.Size(180, 20);
			this.director_textBox.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(40, 103);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Director";
			// 
			// actor1_textBox
			// 
			this.actor1_textBox.Location = new System.Drawing.Point(90, 126);
			this.actor1_textBox.Name = "actor1_textBox";
			this.actor1_textBox.Size = new System.Drawing.Size(180, 20);
			this.actor1_textBox.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(52, 129);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "Actor";
			// 
			// actor2_textBox
			// 
			this.actor2_textBox.Location = new System.Drawing.Point(90, 152);
			this.actor2_textBox.Name = "actor2_textBox";
			this.actor2_textBox.Size = new System.Drawing.Size(180, 20);
			this.actor2_textBox.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(52, 155);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 13);
			this.label5.TabIndex = 1;
			this.label5.Text = "Actor";
			// 
			// price_textBox
			// 
			this.price_textBox.Location = new System.Drawing.Point(90, 178);
			this.price_textBox.Name = "price_textBox";
			this.price_textBox.Size = new System.Drawing.Size(180, 20);
			this.price_textBox.TabIndex = 6;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 181);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 13);
			this.label6.TabIndex = 1;
			this.label6.Text = "Price / Month";
			// 
			// category_textBox
			// 
			this.category_textBox.Location = new System.Drawing.Point(90, 74);
			this.category_textBox.Name = "category_textBox";
			this.category_textBox.Size = new System.Drawing.Size(180, 20);
			this.category_textBox.TabIndex = 2;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(35, 77);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(49, 13);
			this.label7.TabIndex = 1;
			this.label7.Text = "Category";
			// 
			// add_button
			// 
			this.add_button.Location = new System.Drawing.Point(12, 234);
			this.add_button.Name = "add_button";
			this.add_button.Size = new System.Drawing.Size(299, 59);
			this.add_button.TabIndex = 7;
			this.add_button.Text = "Add";
			this.add_button.UseVisualStyleBackColor = true;
			this.add_button.Click += new System.EventHandler(this.add_button_Click);
			// 
			// err_label
			// 
			this.err_label.AutoSize = true;
			this.err_label.ForeColor = System.Drawing.Color.Red;
			this.err_label.Location = new System.Drawing.Point(92, 212);
			this.err_label.Name = "err_label";
			this.err_label.Size = new System.Drawing.Size(74, 13);
			this.err_label.TabIndex = 3;
			this.err_label.Text = "Error message";
			// 
			// AddMovieForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(323, 305);
			this.Controls.Add(this.err_label);
			this.Controls.Add(this.add_button);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.price_textBox);
			this.Controls.Add(this.actor2_textBox);
			this.Controls.Add(this.actor1_textBox);
			this.Controls.Add(this.category_textBox);
			this.Controls.Add(this.director_textBox);
			this.Controls.Add(this.year_textBox);
			this.Controls.Add(this.name_textBox);
			this.Name = "AddMovieForm";
			this.Text = "AddMovieForm";
			this.Load += new System.EventHandler(this.AddMovieForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox name_textBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox year_textBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox director_textBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox actor1_textBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox actor2_textBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox price_textBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox category_textBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button add_button;
		private System.Windows.Forms.Label err_label;
	}
}
namespace Database_Project
{
	partial class SearchForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
			this.search_textBox = new System.Windows.Forms.TextBox();
			this.search_button = new System.Windows.Forms.Button();
			this.result_listView = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.rent_button = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// search_textBox
			// 
			this.search_textBox.Location = new System.Drawing.Point(274, 14);
			this.search_textBox.Name = "search_textBox";
			this.search_textBox.Size = new System.Drawing.Size(124, 20);
			this.search_textBox.TabIndex = 0;
			// 
			// search_button
			// 
			this.search_button.Location = new System.Drawing.Point(404, 12);
			this.search_button.Name = "search_button";
			this.search_button.Size = new System.Drawing.Size(75, 23);
			this.search_button.TabIndex = 1;
			this.search_button.Text = "Search";
			this.search_button.UseVisualStyleBackColor = true;
			this.search_button.Click += new System.EventHandler(this.search_button_Click);
			// 
			// result_listView
			// 
			this.result_listView.CheckBoxes = true;
			this.result_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.result_listView.FullRowSelect = true;
			this.result_listView.GridLines = true;
			this.result_listView.Location = new System.Drawing.Point(12, 59);
			this.result_listView.Name = "result_listView";
			this.result_listView.Size = new System.Drawing.Size(617, 392);
			this.result_listView.TabIndex = 3;
			this.result_listView.UseCompatibleStateImageBehavior = false;
			this.result_listView.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Name";
			this.columnHeader1.Width = 144;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Year";
			this.columnHeader2.Width = 130;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Director";
			this.columnHeader3.Width = 138;
			// 
			// rent_button
			// 
			this.rent_button.Location = new System.Drawing.Point(485, 473);
			this.rent_button.Name = "rent_button";
			this.rent_button.Size = new System.Drawing.Size(144, 56);
			this.rent_button.TabIndex = 4;
			this.rent_button.Text = "Rent";
			this.rent_button.UseVisualStyleBackColor = true;
			this.rent_button.Click += new System.EventHandler(this.rent_button_Click);
			// 
			// SearchForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(641, 541);
			this.Controls.Add(this.rent_button);
			this.Controls.Add(this.result_listView);
			this.Controls.Add(this.search_button);
			this.Controls.Add(this.search_textBox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SearchForm";
			this.Text = "SearchForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox search_textBox;
		private System.Windows.Forms.Button search_button;
		private System.Windows.Forms.ListView result_listView;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Button rent_button;
	}
}
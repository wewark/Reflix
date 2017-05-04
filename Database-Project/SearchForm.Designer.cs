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
			this.search_textBox = new System.Windows.Forms.TextBox();
			this.search_button = new System.Windows.Forms.Button();
			this.result_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.result_tableLayoutPanel.SuspendLayout();
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
			// result_tableLayoutPanel
			// 
			this.result_tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.result_tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.result_tableLayoutPanel.ColumnCount = 3;
			this.result_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 242F));
			this.result_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 261F));
			this.result_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 189F));
			this.result_tableLayoutPanel.Controls.Add(this.label2, 1, 0);
			this.result_tableLayoutPanel.Controls.Add(this.label3, 2, 0);
			this.result_tableLayoutPanel.Controls.Add(this.label1, 0, 0);
			this.result_tableLayoutPanel.Location = new System.Drawing.Point(12, 38);
			this.result_tableLayoutPanel.Name = "result_tableLayoutPanel";
			this.result_tableLayoutPanel.RowCount = 1;
			this.result_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.result_tableLayoutPanel.Size = new System.Drawing.Size(692, 491);
			this.result_tableLayoutPanel.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(247, 1);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(255, 489);
			this.label2.TabIndex = 0;
			this.label2.Text = "Year";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(4, 1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(236, 489);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(509, 1);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(183, 489);
			this.label3.TabIndex = 0;
			this.label3.Text = "Director";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// SearchForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(716, 541);
			this.Controls.Add(this.result_tableLayoutPanel);
			this.Controls.Add(this.search_button);
			this.Controls.Add(this.search_textBox);
			this.Name = "SearchForm";
			this.Text = "SearchForm";
			this.result_tableLayoutPanel.ResumeLayout(false);
			this.result_tableLayoutPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox search_textBox;
		private System.Windows.Forms.Button search_button;
		private System.Windows.Forms.TableLayoutPanel result_tableLayoutPanel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
	}
}
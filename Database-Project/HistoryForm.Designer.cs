namespace Database_Project
{
	partial class HistoryForm
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
			this.history_listView = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// history_listView
			// 
			this.history_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.history_listView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.history_listView.FullRowSelect = true;
			this.history_listView.GridLines = true;
			this.history_listView.Location = new System.Drawing.Point(0, 0);
			this.history_listView.Name = "history_listView";
			this.history_listView.Size = new System.Drawing.Size(481, 384);
			this.history_listView.TabIndex = 4;
			this.history_listView.UseCompatibleStateImageBehavior = false;
			this.history_listView.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Name";
			this.columnHeader1.Width = 144;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Start Date";
			this.columnHeader2.Width = 130;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "End Date";
			this.columnHeader3.Width = 138;
			// 
			// HistoryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(481, 384);
			this.Controls.Add(this.history_listView);
			this.Name = "HistoryForm";
			this.Text = "HistoryForm";
			this.Load += new System.EventHandler(this.HistoryForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView history_listView;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
	}
}
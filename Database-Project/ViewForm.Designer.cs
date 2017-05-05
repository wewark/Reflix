namespace Database_Project
{
	partial class ViewForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewForm));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mOVIEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reflixDataSet = new Database_Project.ReflixDataSet();
            this.mOVIETableAdapter = new Database_Project.ReflixDataSetTableAdapters.MOVIETableAdapter();
            this.reflixDataSet1 = new Database_Project.reflixDataSet1();
            this.mOVIEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mOVIETableAdapter1 = new Database_Project.reflixDataSet1TableAdapters.MOVIETableAdapter();
            this.movieidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directoridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movienameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieyearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moviecategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moviepricepermonthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mOVIEBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reflixDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reflixDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movieidDataGridViewTextBoxColumn,
            this.directoridDataGridViewTextBoxColumn,
            this.adminidDataGridViewTextBoxColumn,
            this.movienameDataGridViewTextBoxColumn,
            this.movieyearDataGridViewTextBoxColumn,
            this.moviecategoryDataGridViewTextBoxColumn,
            this.moviepricepermonthDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mOVIEBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(31, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 386);
            this.dataGridView1.TabIndex = 1;
            // 
            // mOVIEBindingSource
            // 
            this.mOVIEBindingSource.DataMember = "MOVIE";
            this.mOVIEBindingSource.DataSource = this.reflixDataSet;
            // 
            // reflixDataSet
            // 
            this.reflixDataSet.DataSetName = "ReflixDataSet";
            this.reflixDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mOVIETableAdapter
            // 
            this.mOVIETableAdapter.ClearBeforeFill = true;
            // 
            // reflixDataSet1
            // 
            this.reflixDataSet1.DataSetName = "reflixDataSet1";
            this.reflixDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mOVIEBindingSource1
            // 
            this.mOVIEBindingSource1.DataMember = "MOVIE";
            this.mOVIEBindingSource1.DataSource = this.reflixDataSet1;
            // 
            // mOVIETableAdapter1
            // 
            this.mOVIETableAdapter1.ClearBeforeFill = true;
            // 
            // movieidDataGridViewTextBoxColumn
            // 
            this.movieidDataGridViewTextBoxColumn.DataPropertyName = "movie_id";
            this.movieidDataGridViewTextBoxColumn.HeaderText = "movie_id";
            this.movieidDataGridViewTextBoxColumn.Name = "movieidDataGridViewTextBoxColumn";
            this.movieidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // directoridDataGridViewTextBoxColumn
            // 
            this.directoridDataGridViewTextBoxColumn.DataPropertyName = "director_id";
            this.directoridDataGridViewTextBoxColumn.HeaderText = "director_id";
            this.directoridDataGridViewTextBoxColumn.Name = "directoridDataGridViewTextBoxColumn";
            // 
            // adminidDataGridViewTextBoxColumn
            // 
            this.adminidDataGridViewTextBoxColumn.DataPropertyName = "admin_id";
            this.adminidDataGridViewTextBoxColumn.HeaderText = "admin_id";
            this.adminidDataGridViewTextBoxColumn.Name = "adminidDataGridViewTextBoxColumn";
            // 
            // movienameDataGridViewTextBoxColumn
            // 
            this.movienameDataGridViewTextBoxColumn.DataPropertyName = "movie_name";
            this.movienameDataGridViewTextBoxColumn.HeaderText = "movie_name";
            this.movienameDataGridViewTextBoxColumn.Name = "movienameDataGridViewTextBoxColumn";
            // 
            // movieyearDataGridViewTextBoxColumn
            // 
            this.movieyearDataGridViewTextBoxColumn.DataPropertyName = "movie_year";
            this.movieyearDataGridViewTextBoxColumn.HeaderText = "movie_year";
            this.movieyearDataGridViewTextBoxColumn.Name = "movieyearDataGridViewTextBoxColumn";
            // 
            // moviecategoryDataGridViewTextBoxColumn
            // 
            this.moviecategoryDataGridViewTextBoxColumn.DataPropertyName = "movie_category";
            this.moviecategoryDataGridViewTextBoxColumn.HeaderText = "movie_category";
            this.moviecategoryDataGridViewTextBoxColumn.Name = "moviecategoryDataGridViewTextBoxColumn";
            // 
            // moviepricepermonthDataGridViewTextBoxColumn
            // 
            this.moviepricepermonthDataGridViewTextBoxColumn.DataPropertyName = "movie_pricepermonth";
            this.moviepricepermonthDataGridViewTextBoxColumn.HeaderText = "movie_pricepermonth";
            this.moviepricepermonthDataGridViewTextBoxColumn.Name = "moviepricepermonthDataGridViewTextBoxColumn";
            // 
            // mOVIEBindingSource2
            // 
            this.mOVIEBindingSource2.DataMember = "MOVIE";
            this.mOVIEBindingSource2.DataSource = this.reflixDataSet1;
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 471);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewForm";
            this.Load += new System.EventHandler(this.ViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reflixDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reflixDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEBindingSource2)).EndInit();
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ReflixDataSet reflixDataSet;
        private System.Windows.Forms.BindingSource mOVIEBindingSource;
        private ReflixDataSetTableAdapters.MOVIETableAdapter mOVIETableAdapter;
        private reflixDataSet1 reflixDataSet1;
        private System.Windows.Forms.BindingSource mOVIEBindingSource1;
        private reflixDataSet1TableAdapters.MOVIETableAdapter mOVIETableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn directoridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movienameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieyearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moviecategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moviepricepermonthDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mOVIEBindingSource2;
    }
}
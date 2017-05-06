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
            this.mOVIEBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.reflixDataSet1 = new Database_Project.reflixDataSet1();
            this.mOVIEBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.mOVIEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reflixDataSet = new Database_Project.ReflixDataSet();
            this.mOVIETableAdapter = new Database_Project.ReflixDataSetTableAdapters.MOVIETableAdapter();
            this.mOVIEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mOVIETableAdapter1 = new Database_Project.reflixDataSet1TableAdapters.MOVIETableAdapter();
            this.uSERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uSERSTableAdapter = new Database_Project.reflixDataSet1TableAdapters.USERSTableAdapter();
            this.tableAdapterManager = new Database_Project.ReflixDataSetTableAdapters.TableAdapterManager();
            this.tableAdapterManager1 = new Database_Project.reflixDataSet1TableAdapters.TableAdapterManager();
            this.result_listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reflixDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reflixDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // mOVIEBindingSource3
            // 
            this.mOVIEBindingSource3.DataMember = "MOVIE";
            this.mOVIEBindingSource3.DataSource = this.reflixDataSet1;
            // 
            // reflixDataSet1
            // 
            this.reflixDataSet1.DataSetName = "reflixDataSet1";
            this.reflixDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mOVIEBindingSource2
            // 
            this.mOVIEBindingSource2.DataMember = "MOVIE";
            this.mOVIEBindingSource2.DataSource = this.reflixDataSet1;
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
            // mOVIEBindingSource1
            // 
            this.mOVIEBindingSource1.DataMember = "MOVIE";
            this.mOVIEBindingSource1.DataSource = this.reflixDataSet1;
            // 
            // mOVIETableAdapter1
            // 
            this.mOVIETableAdapter1.ClearBeforeFill = true;
            // 
            // uSERSBindingSource
            // 
            this.uSERSBindingSource.DataMember = "USERS";
            this.uSERSBindingSource.DataSource = this.reflixDataSet1;
            // 
            // uSERSTableAdapter
            // 
            this.uSERSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ACTORTableAdapter = null;
            this.tableAdapterManager.ACTSTableAdapter = null;
            this.tableAdapterManager.ADMINTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIRECTORTableAdapter = null;
            this.tableAdapterManager.MOVIETableAdapter = this.mOVIETableAdapter;
            this.tableAdapterManager.RENTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Database_Project.ReflixDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERTableAdapter = null;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.ACTORTableAdapter = null;
            this.tableAdapterManager1.ACTSTableAdapter = null;
            this.tableAdapterManager1.ADMINTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.DIRECTORTableAdapter = null;
            this.tableAdapterManager1.MOVIETableAdapter = this.mOVIETableAdapter1;
            this.tableAdapterManager1.RENTTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Database_Project.reflixDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.USERSTableAdapter = this.uSERSTableAdapter;
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
            this.result_listView.Location = new System.Drawing.Point(26, 65);
            this.result_listView.Name = "result_listView";
            this.result_listView.Size = new System.Drawing.Size(416, 442);
            this.result_listView.TabIndex = 4;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Movies";
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 535);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result_listView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewForm";
            this.Load += new System.EventHandler(this.ViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reflixDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reflixDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mOVIEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSERSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private ReflixDataSet reflixDataSet;
        private System.Windows.Forms.BindingSource mOVIEBindingSource;
        private ReflixDataSetTableAdapters.MOVIETableAdapter mOVIETableAdapter;
        private reflixDataSet1 reflixDataSet1;
        private System.Windows.Forms.BindingSource mOVIEBindingSource1;
        private reflixDataSet1TableAdapters.MOVIETableAdapter mOVIETableAdapter1;
        private System.Windows.Forms.BindingSource mOVIEBindingSource2;
        private System.Windows.Forms.BindingSource uSERSBindingSource;
        private reflixDataSet1TableAdapters.USERSTableAdapter uSERSTableAdapter;
        private System.Windows.Forms.BindingSource mOVIEBindingSource3;
        private ReflixDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private reflixDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ListView result_listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
    }
}
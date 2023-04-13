namespace QLDSV_TC.Views
{
    partial class FrmQLHP
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            this.lblMain = new DevExpress.XtraEditors.LabelControl();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSV_TCDataSet = new QLDSV_TC.QLDSV_TCDataSet();
            this.fKSINHVIENLOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lOPTableAdapter = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.LOPTableAdapter();
            this.sINHVIENTableAdapter = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.SINHVIENTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKSINHVIENLOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.False;
            this.lblMain.Appearance.Font = new System.Drawing.Font("SF Mono", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.Appearance.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblMain.Appearance.Options.UseFont = true;
            this.lblMain.Appearance.Options.UseForeColor = true;
            this.lblMain.Appearance.Options.UseTextOptions = true;
            this.lblMain.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblMain.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lblMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMain.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.lblMain.LineVisible = true;
            this.lblMain.Location = new System.Drawing.Point(0, 0);
            this.lblMain.Name = "lblMain";
            this.lblMain.Padding = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.lblMain.Size = new System.Drawing.Size(1698, 67);
            this.lblMain.TabIndex = 8;
            this.lblMain.Text = "QUẢN LÝ HỌC PHÍ CỦA SINH VIÊN";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 67);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1698, 593);
            this.dataLayoutControl1.TabIndex = 9;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.qLDSV_TCDataSet;
            // 
            // qLDSV_TCDataSet
            // 
            this.qLDSV_TCDataSet.DataSetName = "QLDSV_TCDataSet";
            this.qLDSV_TCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fKSINHVIENLOPBindingSource
            // 
            this.fKSINHVIENLOPBindingSource.DataMember = "FK_SINHVIEN_LOP";
            this.fKSINHVIENLOPBindingSource.DataSource = this.lOPBindingSource;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition1.Width = 100D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 100D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2});
            rowDefinition1.Height = 100D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            rowDefinition2.Height = 100D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2});
            this.Root.Size = new System.Drawing.Size(1698, 593);
            this.Root.TextVisible = false;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // FrmQLHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1698, 660);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.lblMain);
            this.Name = "FrmQLHP";
            this.Text = "QUẢN LÝ HỌC PHÍ";
            this.Load += new System.EventHandler(this.FrmQLHP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKSINHVIENLOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblMain;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private QLDSV_TCDataSet qLDSV_TCDataSet;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private QLDSV_TCDataSetTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.BindingSource fKSINHVIENLOPBindingSource;
        private QLDSV_TCDataSetTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
    }
}
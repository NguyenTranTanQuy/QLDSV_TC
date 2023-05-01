namespace QLDSV_TC.Views
{
    partial class RpfListPayTuitionOfClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RpfListPayTuitionOfClass));
            this.lblMain = new DevExpress.XtraEditors.LabelControl();
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            this.cbHOCKY = new System.Windows.Forms.ComboBox();
            this.cbNIENKHOA = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lkLOP = new DevExpress.XtraEditors.LookUpEdit();
            this.bdsLOP = new System.Windows.Forms.BindingSource(this.components);
            this.QLDSV_TCDataSet = new QLDSV_TC.QLDSV_TCDataSet1();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.LOPTableAdapter = new QLDSV_TC.QLDSV_TCDataSet1TableAdapters.LOPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lkLOP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLDSV_TCDataSet)).BeginInit();
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
            this.lblMain.Margin = new System.Windows.Forms.Padding(6);
            this.lblMain.Name = "lblMain";
            this.lblMain.Padding = new System.Windows.Forms.Padding(31, 15, 31, 15);
            this.lblMain.Size = new System.Drawing.Size(946, 81);
            this.lblMain.TabIndex = 30;
            this.lblMain.Text = "IN DANH SÁCH HỌC PHÍ LỚP";
            // 
            // btnPreview
            // 
            this.btnPreview.Appearance.Font = new System.Drawing.Font("SF Mono", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Appearance.Options.UseFont = true;
            this.btnPreview.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPreview.ImageOptions.Image")));
            this.btnPreview.Location = new System.Drawing.Point(210, 292);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(10);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(256, 47);
            this.btnPreview.TabIndex = 75;
            this.btnPreview.Text = "XEM BẢN THẢO";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // cbHOCKY
            // 
            this.cbHOCKY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHOCKY.Font = new System.Drawing.Font("SF Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHOCKY.FormattingEnabled = true;
            this.cbHOCKY.ItemHeight = 21;
            this.cbHOCKY.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbHOCKY.Location = new System.Drawing.Point(210, 230);
            this.cbHOCKY.Margin = new System.Windows.Forms.Padding(5);
            this.cbHOCKY.Name = "cbHOCKY";
            this.cbHOCKY.Size = new System.Drawing.Size(642, 29);
            this.cbHOCKY.TabIndex = 74;
            // 
            // cbNIENKHOA
            // 
            this.cbNIENKHOA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNIENKHOA.Font = new System.Drawing.Font("SF Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNIENKHOA.FormattingEnabled = true;
            this.cbNIENKHOA.ItemHeight = 21;
            this.cbNIENKHOA.Location = new System.Drawing.Point(210, 173);
            this.cbNIENKHOA.Margin = new System.Windows.Forms.Padding(5);
            this.cbNIENKHOA.Name = "cbNIENKHOA";
            this.cbNIENKHOA.Size = new System.Drawing.Size(642, 29);
            this.cbNIENKHOA.TabIndex = 71;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("SF Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(82, 233);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(77, 21);
            this.labelControl2.TabIndex = 73;
            this.labelControl2.Text = "HỌC KỲ:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("SF Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(82, 176);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(10);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(110, 21);
            this.labelControl7.TabIndex = 72;
            this.labelControl7.Text = "NIÊN KHÓA:";
            // 
            // lkLOP
            // 
            this.lkLOP.Location = new System.Drawing.Point(210, 122);
            this.lkLOP.Margin = new System.Windows.Forms.Padding(6);
            this.lkLOP.Name = "lkLOP";
            this.lkLOP.Properties.Appearance.Font = new System.Drawing.Font("SF Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkLOP.Properties.Appearance.Options.UseFont = true;
            this.lkLOP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkLOP.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MALOP", "MALOP", 51, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENLOP", "TENLOP", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("KHOAHOC", "KHOAHOC", 68, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MAKHOA", "MAKHOA", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lkLOP.Properties.DataSource = this.bdsLOP;
            this.lkLOP.Properties.DisplayMember = "MALOP";
            this.lkLOP.Properties.NullText = "Chọn lớp học";
            this.lkLOP.Properties.ValueMember = "MALOP";
            this.lkLOP.Size = new System.Drawing.Size(642, 28);
            this.lkLOP.TabIndex = 77;
            // 
            // bdsLOP
            // 
            this.bdsLOP.DataMember = "LOP";
            this.bdsLOP.DataSource = this.QLDSV_TCDataSet;
            // 
            // QLDSV_TCDataSet
            // 
            this.QLDSV_TCDataSet.DataSetName = "QLDSV_TCDataSet1";
            this.QLDSV_TCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("SF Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(82, 125);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 21);
            this.labelControl1.TabIndex = 76;
            this.labelControl1.Text = "LỚP:";
            // 
            // LOPTableAdapter
            // 
            this.LOPTableAdapter.ClearBeforeFill = true;
            // 
            // RpfListPayTuitionOfClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 368);
            this.Controls.Add(this.lkLOP);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.cbHOCKY);
            this.Controls.Add(this.cbNIENKHOA);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.lblMain);
            this.Name = "RpfListPayTuitionOfClass";
            this.Text = "DSHP LỚP";
            this.Load += new System.EventHandler(this.RpfListPayTuitionOfClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lkLOP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLDSV_TCDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblMain;
        private DevExpress.XtraEditors.SimpleButton btnPreview;
        private System.Windows.Forms.ComboBox cbHOCKY;
        private System.Windows.Forms.ComboBox cbNIENKHOA;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LookUpEdit lkLOP;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private QLDSV_TCDataSet1 QLDSV_TCDataSet;
        private System.Windows.Forms.BindingSource bdsLOP;
        private QLDSV_TCDataSet1TableAdapters.LOPTableAdapter LOPTableAdapter;
    }
}
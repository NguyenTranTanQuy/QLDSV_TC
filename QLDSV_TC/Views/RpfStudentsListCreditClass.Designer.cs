namespace QLDSV_TC.Views
{
    partial class RpfStudentsListCreditClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RpfStudentsListCreditClass));
            this.lblMain = new DevExpress.XtraEditors.LabelControl();
            this.panelChonKhoa = new DevExpress.XtraEditors.PanelControl();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.QLDSV_TCDataSet = new QLDSV_TC.QLDSV_TCDataSet();
            this.bdsMONHOC = new System.Windows.Forms.BindingSource(this.components);
            this.MONHOCTableAdapter = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.MONHOCTableAdapter();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            this.nmNHOM = new System.Windows.Forms.NumericUpDown();
            this.lkMONHOC = new DevExpress.XtraEditors.LookUpEdit();
            this.cbHOCKY = new System.Windows.Forms.ComboBox();
            this.cbNIENKHOA = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelChonKhoa)).BeginInit();
            this.panelChonKhoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QLDSV_TCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMONHOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmNHOM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkMONHOC.Properties)).BeginInit();
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
            this.lblMain.Margin = new System.Windows.Forms.Padding(5);
            this.lblMain.Name = "lblMain";
            this.lblMain.Padding = new System.Windows.Forms.Padding(25, 12, 25, 12);
            this.lblMain.Size = new System.Drawing.Size(729, 126);
            this.lblMain.TabIndex = 8;
            this.lblMain.Text = "IN DANH SÁCH SINH VIÊN LỚP TÍN CHỈ";
            // 
            // panelChonKhoa
            // 
            this.panelChonKhoa.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelChonKhoa.Controls.Add(this.cbKhoa);
            this.panelChonKhoa.Controls.Add(this.label3);
            this.panelChonKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChonKhoa.Location = new System.Drawing.Point(0, 126);
            this.panelChonKhoa.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panelChonKhoa.Name = "panelChonKhoa";
            this.panelChonKhoa.Size = new System.Drawing.Size(729, 53);
            this.panelChonKhoa.TabIndex = 28;
            // 
            // cbKhoa
            // 
            this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa.Enabled = false;
            this.cbKhoa.Font = new System.Drawing.Font("SF Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.ItemHeight = 21;
            this.cbKhoa.Location = new System.Drawing.Point(192, 10);
            this.cbKhoa.Margin = new System.Windows.Forms.Padding(5);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(443, 29);
            this.cbKhoa.TabIndex = 1;
            this.cbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbKhoa_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SF Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "KHOA:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // QLDSV_TCDataSet
            // 
            this.QLDSV_TCDataSet.DataSetName = "QLDSV_TCDataSet";
            this.QLDSV_TCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsMONHOC
            // 
            this.bdsMONHOC.DataMember = "MONHOC";
            this.bdsMONHOC.DataSource = this.QLDSV_TCDataSet;
            // 
            // MONHOCTableAdapter
            // 
            this.MONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.btnPreview);
            this.panelControl1.Controls.Add(this.nmNHOM);
            this.panelControl1.Controls.Add(this.lkMONHOC);
            this.panelControl1.Controls.Add(this.cbHOCKY);
            this.panelControl1.Controls.Add(this.cbNIENKHOA);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 179);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(729, 357);
            this.panelControl1.TabIndex = 29;
            // 
            // btnPreview
            // 
            this.btnPreview.Appearance.Font = new System.Drawing.Font("SF Mono", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Appearance.Options.UseFont = true;
            this.btnPreview.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPreview.ImageOptions.Image")));
            this.btnPreview.Location = new System.Drawing.Point(190, 260);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(8);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(230, 51);
            this.btnPreview.TabIndex = 75;
            this.btnPreview.Text = "XEM BẢN THẢO";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // nmNHOM
            // 
            this.nmNHOM.Font = new System.Drawing.Font("SF Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmNHOM.Location = new System.Drawing.Point(190, 210);
            this.nmNHOM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmNHOM.Name = "nmNHOM";
            this.nmNHOM.Size = new System.Drawing.Size(441, 29);
            this.nmNHOM.TabIndex = 74;
            this.nmNHOM.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lkMONHOC
            // 
            this.lkMONHOC.Location = new System.Drawing.Point(190, 154);
            this.lkMONHOC.Margin = new System.Windows.Forms.Padding(6);
            this.lkMONHOC.Name = "lkMONHOC";
            this.lkMONHOC.Properties.Appearance.Font = new System.Drawing.Font("SF Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkMONHOC.Properties.Appearance.Options.UseFont = true;
            this.lkMONHOC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkMONHOC.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MAMH", "MAMH", 92, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENMH", "TENMH", 101, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SOTIET_LT", "SOTIET_LT", 149, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SOTIET_TH", "SOTIET_TH", 151, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lkMONHOC.Properties.DataSource = this.bdsMONHOC;
            this.lkMONHOC.Properties.DisplayMember = "TENMH";
            this.lkMONHOC.Properties.NullText = "Chọn môn học";
            this.lkMONHOC.Properties.ValueMember = "MAMH";
            this.lkMONHOC.Size = new System.Drawing.Size(443, 28);
            this.lkMONHOC.TabIndex = 73;
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
            this.cbHOCKY.Location = new System.Drawing.Point(192, 108);
            this.cbHOCKY.Name = "cbHOCKY";
            this.cbHOCKY.Size = new System.Drawing.Size(441, 29);
            this.cbHOCKY.TabIndex = 72;
            // 
            // cbNIENKHOA
            // 
            this.cbNIENKHOA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNIENKHOA.Font = new System.Drawing.Font("SF Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNIENKHOA.FormattingEnabled = true;
            this.cbNIENKHOA.ItemHeight = 21;
            this.cbNIENKHOA.Location = new System.Drawing.Point(192, 51);
            this.cbNIENKHOA.Name = "cbNIENKHOA";
            this.cbNIENKHOA.Size = new System.Drawing.Size(441, 29);
            this.cbNIENKHOA.TabIndex = 67;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("SF Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(73, 210);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 21);
            this.labelControl3.TabIndex = 71;
            this.labelControl3.Text = "NHÓM:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("SF Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(73, 108);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(77, 21);
            this.labelControl2.TabIndex = 70;
            this.labelControl2.Text = "HỌC KỲ:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("SF Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(73, 157);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(88, 21);
            this.labelControl1.TabIndex = 69;
            this.labelControl1.Text = "MÔN HỌC:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("SF Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(73, 54);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(6);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(110, 21);
            this.labelControl7.TabIndex = 68;
            this.labelControl7.Text = "NIÊN KHÓA:";
            // 
            // RpfStudentsListCreditClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 536);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelChonKhoa);
            this.Controls.Add(this.lblMain);
            this.Name = "RpfStudentsListCreditClass";
            this.Text = "DSSV LỚP TÍN CHỈ";
            this.Load += new System.EventHandler(this.RpfStudentsListCreditClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelChonKhoa)).EndInit();
            this.panelChonKhoa.ResumeLayout(false);
            this.panelChonKhoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QLDSV_TCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMONHOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmNHOM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkMONHOC.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblMain;
        private DevExpress.XtraEditors.PanelControl panelChonKhoa;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Label label3;
        private QLDSV_TCDataSet QLDSV_TCDataSet;
        private System.Windows.Forms.BindingSource bdsMONHOC;
        private QLDSV_TCDataSetTableAdapters.MONHOCTableAdapter MONHOCTableAdapter;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnPreview;
        private System.Windows.Forms.NumericUpDown nmNHOM;
        private DevExpress.XtraEditors.LookUpEdit lkMONHOC;
        private System.Windows.Forms.ComboBox cbHOCKY;
        private System.Windows.Forms.ComboBox cbNIENKHOA;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
    }
}
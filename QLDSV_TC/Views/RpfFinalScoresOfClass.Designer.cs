namespace QLDSV_TC.Views
{
    partial class RpfFinalScoresOfClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RpfFinalScoresOfClass));
            this.panelChonKhoa = new DevExpress.XtraEditors.PanelControl();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMain = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lkLOP = new DevExpress.XtraEditors.LookUpEdit();
            this.bdsLOP = new System.Windows.Forms.BindingSource(this.components);
            this.QLDSV_TCDataSet = new QLDSV_TC.QLDSV_TCDataSet();
            this.btnPreview = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.LOPTableAdapter = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.LOPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelChonKhoa)).BeginInit();
            this.panelChonKhoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkLOP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLDSV_TCDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChonKhoa
            // 
            this.panelChonKhoa.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelChonKhoa.Controls.Add(this.cbKhoa);
            this.panelChonKhoa.Controls.Add(this.label3);
            this.panelChonKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChonKhoa.Location = new System.Drawing.Point(0, 132);
            this.panelChonKhoa.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.panelChonKhoa.Name = "panelChonKhoa";
            this.panelChonKhoa.Size = new System.Drawing.Size(728, 52);
            this.panelChonKhoa.TabIndex = 32;
            // 
            // cbKhoa
            // 
            this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa.Enabled = false;
            this.cbKhoa.Font = new System.Drawing.Font("SF Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.ItemHeight = 21;
            this.cbKhoa.Location = new System.Drawing.Point(244, 12);
            this.cbKhoa.Margin = new System.Windows.Forms.Padding(6);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(436, 29);
            this.cbKhoa.TabIndex = 1;
            this.cbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbKhoa_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SF Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(112, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "KHOA:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.lblMain.Size = new System.Drawing.Size(728, 132);
            this.lblMain.TabIndex = 31;
            this.lblMain.Text = "IN BẢNG ĐIỂM TỔNG KẾT CUỐI KHÓA";
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.lkLOP);
            this.panelControl1.Controls.Add(this.btnPreview);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 184);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(6);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(728, 166);
            this.panelControl1.TabIndex = 33;
            // 
            // lkLOP
            // 
            this.lkLOP.Location = new System.Drawing.Point(116, 32);
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
            this.lkLOP.Size = new System.Drawing.Size(564, 28);
            this.lkLOP.TabIndex = 78;
            // 
            // bdsLOP
            // 
            this.bdsLOP.DataMember = "LOP";
            this.bdsLOP.DataSource = this.QLDSV_TCDataSet;
            // 
            // QLDSV_TCDataSet
            // 
            this.QLDSV_TCDataSet.DataSetName = "QLDSV_TCDataSet";
            this.QLDSV_TCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPreview
            // 
            this.btnPreview.Appearance.Font = new System.Drawing.Font("SF Mono", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Appearance.Options.UseFont = true;
            this.btnPreview.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPreview.ImageOptions.Image")));
            this.btnPreview.Location = new System.Drawing.Point(244, 91);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(10);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(217, 47);
            this.btnPreview.TabIndex = 70;
            this.btnPreview.Text = "XEM BẢN THẢO";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("SF Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(57, 35);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(10);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(44, 21);
            this.labelControl7.TabIndex = 67;
            this.labelControl7.Text = "LỚP:";
            // 
            // LOPTableAdapter
            // 
            this.LOPTableAdapter.ClearBeforeFill = true;
            // 
            // RpfFinalScoresOfClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 350);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelChonKhoa);
            this.Controls.Add(this.lblMain);
            this.Name = "RpfFinalScoresOfClass";
            this.Text = "BẢNG ĐIỂM TỔNG KẾT";
            this.Load += new System.EventHandler(this.RpfFinalScoresOfClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelChonKhoa)).EndInit();
            this.panelChonKhoa.ResumeLayout(false);
            this.panelChonKhoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkLOP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLDSV_TCDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelChonKhoa;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.LabelControl lblMain;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnPreview;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LookUpEdit lkLOP;
        private QLDSV_TCDataSet QLDSV_TCDataSet;
        private System.Windows.Forms.BindingSource bdsLOP;
        private QLDSV_TCDataSetTableAdapters.LOPTableAdapter LOPTableAdapter;
    }
}
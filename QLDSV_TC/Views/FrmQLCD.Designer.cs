﻿namespace QLDSV_TC.Views
{
    partial class FrmQLCD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQLCD));
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            this.panelChonKhoa = new DevExpress.XtraEditors.PanelControl();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.txtHOTENGV = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtMAGV = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtMALTC = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbNHOM = new System.Windows.Forms.ComboBox();
            this.cbHOCKY = new System.Windows.Forms.ComboBox();
            this.cbMONHOC = new System.Windows.Forms.ComboBox();
            this.btnExitSubForm = new DevExpress.XtraEditors.SimpleButton();
            this.cbNIENKHOA = new System.Windows.Forms.ComboBox();
            this.btnWriteScore = new DevExpress.XtraEditors.SimpleButton();
            this.btnStart = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.gridControlScore = new DevExpress.XtraGrid.GridControl();
            this.gridViewScore = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTENSV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM_CC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colDIEM_GK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colDIEM_CK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSpinEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colDIEM_TK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bdsDANGKY = new System.Windows.Forms.BindingSource(this.components);
            this.QLDSV_TCDataSet = new QLDSV_TC.QLDSV_TCDataSet();
            this.lblMain = new DevExpress.XtraEditors.LabelControl();
            this.DANGKYTableAdapter = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.DANGKYTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.panelChonKhoa)).BeginInit();
            this.panelChonKhoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHOTENGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMALTC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDANGKY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLDSV_TCDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChonKhoa
            // 
            this.panelChonKhoa.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelChonKhoa.Controls.Add(this.cbKhoa);
            this.panelChonKhoa.Controls.Add(this.label1);
            this.panelChonKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChonKhoa.Location = new System.Drawing.Point(0, 67);
            this.panelChonKhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelChonKhoa.Name = "panelChonKhoa";
            this.panelChonKhoa.Size = new System.Drawing.Size(1698, 53);
            this.panelChonKhoa.TabIndex = 28;
            // 
            // cbKhoa
            // 
            this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa.Enabled = false;
            this.cbKhoa.Font = new System.Drawing.Font("SF Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.ItemHeight = 21;
            this.cbKhoa.Location = new System.Drawing.Point(258, 12);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(328, 29);
            this.cbKhoa.TabIndex = 1;
            this.cbKhoa.SelectedIndexChanged += new System.EventHandler(this.cbKhoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHOA:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.panelControl1);
            this.dataLayoutControl1.Controls.Add(this.gridControlScore);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 120);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1698, 540);
            this.dataLayoutControl1.TabIndex = 29;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1674, 116);
            this.panelControl1.TabIndex = 5;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Controls.Add(this.cbNHOM);
            this.panelControl2.Controls.Add(this.cbHOCKY);
            this.panelControl2.Controls.Add(this.cbMONHOC);
            this.panelControl2.Controls.Add(this.btnExitSubForm);
            this.panelControl2.Controls.Add(this.cbNIENKHOA);
            this.panelControl2.Controls.Add(this.btnWriteScore);
            this.panelControl2.Controls.Add(this.btnStart);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.labelControl2);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.labelControl7);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1670, 114);
            this.panelControl2.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.txtHOTENGV);
            this.panelControl3.Controls.Add(this.labelControl6);
            this.panelControl3.Controls.Add(this.txtMAGV);
            this.panelControl3.Controls.Add(this.labelControl5);
            this.panelControl3.Controls.Add(this.txtMALTC);
            this.panelControl3.Controls.Add(this.labelControl4);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl3.Location = new System.Drawing.Point(1186, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(482, 110);
            this.panelControl3.TabIndex = 54;
            // 
            // txtHOTENGV
            // 
            this.txtHOTENGV.Location = new System.Drawing.Point(131, 71);
            this.txtHOTENGV.Name = "txtHOTENGV";
            this.txtHOTENGV.Properties.Appearance.Font = new System.Drawing.Font("SF Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHOTENGV.Properties.Appearance.Options.UseFont = true;
            this.txtHOTENGV.Properties.ReadOnly = true;
            this.txtHOTENGV.Size = new System.Drawing.Size(332, 26);
            this.txtHOTENGV.TabIndex = 5;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("SF Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(15, 74);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(110, 20);
            this.labelControl6.TabIndex = 4;
            this.labelControl6.Text = "Họ tên GV:";
            // 
            // txtMAGV
            // 
            this.txtMAGV.Location = new System.Drawing.Point(131, 44);
            this.txtMAGV.Name = "txtMAGV";
            this.txtMAGV.Properties.Appearance.Font = new System.Drawing.Font("SF Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMAGV.Properties.Appearance.Options.UseFont = true;
            this.txtMAGV.Properties.ReadOnly = true;
            this.txtMAGV.Size = new System.Drawing.Size(332, 26);
            this.txtMAGV.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("SF Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(15, 47);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(66, 20);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "Mã GV:";
            // 
            // txtMALTC
            // 
            this.txtMALTC.Location = new System.Drawing.Point(131, 17);
            this.txtMALTC.Name = "txtMALTC";
            this.txtMALTC.Properties.Appearance.Font = new System.Drawing.Font("SF Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMALTC.Properties.Appearance.Options.UseFont = true;
            this.txtMALTC.Properties.ReadOnly = true;
            this.txtMALTC.Size = new System.Drawing.Size(332, 26);
            this.txtMALTC.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("SF Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(15, 20);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(77, 20);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Mã LTC:";
            // 
            // cbNHOM
            // 
            this.cbNHOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNHOM.Enabled = false;
            this.cbNHOM.Font = new System.Drawing.Font("SF Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNHOM.FormattingEnabled = true;
            this.cbNHOM.ItemHeight = 21;
            this.cbNHOM.Location = new System.Drawing.Point(641, 67);
            this.cbNHOM.Name = "cbNHOM";
            this.cbNHOM.Size = new System.Drawing.Size(181, 29);
            this.cbNHOM.TabIndex = 53;
            this.cbNHOM.SelectedIndexChanged += new System.EventHandler(this.cbNHOM_SelectedIndexChanged);
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
            this.cbHOCKY.Location = new System.Drawing.Point(641, 19);
            this.cbHOCKY.Name = "cbHOCKY";
            this.cbHOCKY.Size = new System.Drawing.Size(181, 29);
            this.cbHOCKY.TabIndex = 52;
            this.cbHOCKY.SelectedIndexChanged += new System.EventHandler(this.cbHOCKY_SelectedIndexChanged);
            // 
            // cbMONHOC
            // 
            this.cbMONHOC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMONHOC.Enabled = false;
            this.cbMONHOC.Font = new System.Drawing.Font("SF Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMONHOC.FormattingEnabled = true;
            this.cbMONHOC.ItemHeight = 21;
            this.cbMONHOC.Location = new System.Drawing.Point(147, 68);
            this.cbMONHOC.Name = "cbMONHOC";
            this.cbMONHOC.Size = new System.Drawing.Size(376, 29);
            this.cbMONHOC.TabIndex = 51;
            this.cbMONHOC.SelectedIndexChanged += new System.EventHandler(this.cbMONHOC_SelectedIndexChanged);
            // 
            // btnExitSubForm
            // 
            this.btnExitSubForm.Appearance.Font = new System.Drawing.Font("SF Mono", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitSubForm.Appearance.Options.UseFont = true;
            this.btnExitSubForm.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExitSubForm.ImageOptions.Image")));
            this.btnExitSubForm.Location = new System.Drawing.Point(942, 62);
            this.btnExitSubForm.Name = "btnExitSubForm";
            this.btnExitSubForm.Size = new System.Drawing.Size(156, 48);
            this.btnExitSubForm.TabIndex = 50;
            this.btnExitSubForm.Text = "THOÁT";
            this.btnExitSubForm.Click += new System.EventHandler(this.btnExitSubForm_Click);
            // 
            // cbNIENKHOA
            // 
            this.cbNIENKHOA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNIENKHOA.Font = new System.Drawing.Font("SF Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNIENKHOA.FormattingEnabled = true;
            this.cbNIENKHOA.ItemHeight = 21;
            this.cbNIENKHOA.Location = new System.Drawing.Point(147, 19);
            this.cbNIENKHOA.Name = "cbNIENKHOA";
            this.cbNIENKHOA.Size = new System.Drawing.Size(202, 29);
            this.cbNIENKHOA.TabIndex = 2;
            this.cbNIENKHOA.SelectedIndexChanged += new System.EventHandler(this.cbNIENKHOA_SelectedIndexChanged);
            // 
            // btnWriteScore
            // 
            this.btnWriteScore.Appearance.Font = new System.Drawing.Font("SF Mono", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWriteScore.Appearance.Options.UseFont = true;
            this.btnWriteScore.Enabled = false;
            this.btnWriteScore.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnWriteScore.ImageOptions.Image")));
            this.btnWriteScore.Location = new System.Drawing.Point(1021, 8);
            this.btnWriteScore.Name = "btnWriteScore";
            this.btnWriteScore.Size = new System.Drawing.Size(159, 48);
            this.btnWriteScore.TabIndex = 49;
            this.btnWriteScore.Text = "GHI ĐIỂM";
            this.btnWriteScore.Click += new System.EventHandler(this.btnWriteScore_Click);
            // 
            // btnStart
            // 
            this.btnStart.Appearance.Font = new System.Drawing.Font("SF Mono", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Appearance.Options.UseFont = true;
            this.btnStart.Enabled = false;
            this.btnStart.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.ImageOptions.Image")));
            this.btnStart.Location = new System.Drawing.Point(856, 8);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(159, 48);
            this.btnStart.TabIndex = 48;
            this.btnStart.Text = "BẮT ĐẦU";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("SF Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(548, 75);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 21);
            this.labelControl3.TabIndex = 46;
            this.labelControl3.Text = "NHÓM:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("SF Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(548, 22);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(77, 21);
            this.labelControl2.TabIndex = 44;
            this.labelControl2.Text = "HỌC KỲ:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("SF Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(17, 71);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(88, 21);
            this.labelControl1.TabIndex = 42;
            this.labelControl1.Text = "MÔN HỌC:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("SF Mono", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(17, 23);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(110, 21);
            this.labelControl7.TabIndex = 40;
            this.labelControl7.Text = "NIÊN KHÓA:";
            // 
            // gridControlScore
            // 
            this.gridControlScore.Location = new System.Drawing.Point(12, 132);
            this.gridControlScore.MainView = this.gridViewScore;
            this.gridControlScore.Name = "gridControlScore";
            this.gridControlScore.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1,
            this.repositoryItemSpinEdit2,
            this.repositoryItemSpinEdit3});
            this.gridControlScore.Size = new System.Drawing.Size(1674, 396);
            this.gridControlScore.TabIndex = 4;
            this.gridControlScore.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewScore});
            // 
            // gridViewScore
            // 
            this.gridViewScore.Appearance.GroupPanel.Font = new System.Drawing.Font("SF Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewScore.Appearance.GroupPanel.Options.UseFont = true;
            this.gridViewScore.Appearance.Row.Font = new System.Drawing.Font("SF Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewScore.Appearance.Row.Options.UseFont = true;
            this.gridViewScore.ColumnPanelRowHeight = 40;
            this.gridViewScore.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHOTENSV,
            this.colDIEM_CC,
            this.colDIEM_GK,
            this.colDIEM_CK,
            this.colDIEM_TK});
            this.gridViewScore.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridViewScore.GridControl = this.gridControlScore;
            this.gridViewScore.GroupPanelText = "BẢNG ĐIỂM LỚP TÍN CHỈ";
            this.gridViewScore.Name = "gridViewScore";
            this.gridViewScore.RowHeight = 30;
            this.gridViewScore.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gridViewScore_ShowingEditor);
            // 
            // colMASV
            // 
            this.colMASV.AppearanceCell.Options.UseTextOptions = true;
            this.colMASV.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMASV.AppearanceHeader.BackColor = System.Drawing.Color.Cyan;
            this.colMASV.AppearanceHeader.BorderColor = System.Drawing.Color.Black;
            this.colMASV.AppearanceHeader.Font = new System.Drawing.Font("SF Mono", 11F, System.Drawing.FontStyle.Bold);
            this.colMASV.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colMASV.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colMASV.AppearanceHeader.Options.UseBackColor = true;
            this.colMASV.AppearanceHeader.Options.UseBorderColor = true;
            this.colMASV.AppearanceHeader.Options.UseFont = true;
            this.colMASV.AppearanceHeader.Options.UseForeColor = true;
            this.colMASV.AppearanceHeader.Options.UseTextOptions = true;
            this.colMASV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMASV.Caption = "Mã SV";
            this.colMASV.FieldName = "MASV";
            this.colMASV.MinWidth = 25;
            this.colMASV.Name = "colMASV";
            this.colMASV.OptionsColumn.AllowEdit = false;
            this.colMASV.OptionsColumn.ReadOnly = true;
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            this.colMASV.Width = 94;
            // 
            // colHOTENSV
            // 
            this.colHOTENSV.AppearanceCell.Options.UseTextOptions = true;
            this.colHOTENSV.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHOTENSV.AppearanceHeader.BackColor = System.Drawing.Color.Cyan;
            this.colHOTENSV.AppearanceHeader.BorderColor = System.Drawing.Color.Black;
            this.colHOTENSV.AppearanceHeader.Font = new System.Drawing.Font("SF Mono", 11F, System.Drawing.FontStyle.Bold);
            this.colHOTENSV.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colHOTENSV.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colHOTENSV.AppearanceHeader.Options.UseBackColor = true;
            this.colHOTENSV.AppearanceHeader.Options.UseBorderColor = true;
            this.colHOTENSV.AppearanceHeader.Options.UseFont = true;
            this.colHOTENSV.AppearanceHeader.Options.UseForeColor = true;
            this.colHOTENSV.AppearanceHeader.Options.UseTextOptions = true;
            this.colHOTENSV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colHOTENSV.Caption = "Họ tên SV";
            this.colHOTENSV.FieldName = "HOTENSV";
            this.colHOTENSV.MinWidth = 25;
            this.colHOTENSV.Name = "colHOTENSV";
            this.colHOTENSV.OptionsColumn.AllowEdit = false;
            this.colHOTENSV.OptionsColumn.ReadOnly = true;
            this.colHOTENSV.Visible = true;
            this.colHOTENSV.VisibleIndex = 1;
            this.colHOTENSV.Width = 94;
            // 
            // colDIEM_CC
            // 
            this.colDIEM_CC.AppearanceCell.Options.UseTextOptions = true;
            this.colDIEM_CC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDIEM_CC.AppearanceHeader.BackColor = System.Drawing.Color.Cyan;
            this.colDIEM_CC.AppearanceHeader.BorderColor = System.Drawing.Color.Black;
            this.colDIEM_CC.AppearanceHeader.Font = new System.Drawing.Font("SF Mono", 11F, System.Drawing.FontStyle.Bold);
            this.colDIEM_CC.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colDIEM_CC.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colDIEM_CC.AppearanceHeader.Options.UseBackColor = true;
            this.colDIEM_CC.AppearanceHeader.Options.UseBorderColor = true;
            this.colDIEM_CC.AppearanceHeader.Options.UseFont = true;
            this.colDIEM_CC.AppearanceHeader.Options.UseForeColor = true;
            this.colDIEM_CC.AppearanceHeader.Options.UseTextOptions = true;
            this.colDIEM_CC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDIEM_CC.Caption = "Điểm chuyên cần";
            this.colDIEM_CC.ColumnEdit = this.repositoryItemSpinEdit1;
            this.colDIEM_CC.FieldName = "DIEM_CC";
            this.colDIEM_CC.MinWidth = 25;
            this.colDIEM_CC.Name = "colDIEM_CC";
            this.colDIEM_CC.Visible = true;
            this.colDIEM_CC.VisibleIndex = 2;
            this.colDIEM_CC.Width = 94;
            // 
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.IsFloatValue = false;
            this.repositoryItemSpinEdit1.MaskSettings.Set("mask", "n2");
            this.repositoryItemSpinEdit1.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // colDIEM_GK
            // 
            this.colDIEM_GK.AppearanceCell.Options.UseTextOptions = true;
            this.colDIEM_GK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDIEM_GK.AppearanceHeader.BackColor = System.Drawing.Color.Cyan;
            this.colDIEM_GK.AppearanceHeader.BorderColor = System.Drawing.Color.Black;
            this.colDIEM_GK.AppearanceHeader.Font = new System.Drawing.Font("SF Mono", 11F, System.Drawing.FontStyle.Bold);
            this.colDIEM_GK.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colDIEM_GK.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colDIEM_GK.AppearanceHeader.Options.UseBackColor = true;
            this.colDIEM_GK.AppearanceHeader.Options.UseBorderColor = true;
            this.colDIEM_GK.AppearanceHeader.Options.UseFont = true;
            this.colDIEM_GK.AppearanceHeader.Options.UseForeColor = true;
            this.colDIEM_GK.AppearanceHeader.Options.UseTextOptions = true;
            this.colDIEM_GK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDIEM_GK.Caption = "Điểm giữa kỳ";
            this.colDIEM_GK.ColumnEdit = this.repositoryItemSpinEdit2;
            this.colDIEM_GK.FieldName = "DIEM_GK";
            this.colDIEM_GK.MinWidth = 25;
            this.colDIEM_GK.Name = "colDIEM_GK";
            this.colDIEM_GK.Visible = true;
            this.colDIEM_GK.VisibleIndex = 3;
            this.colDIEM_GK.Width = 94;
            // 
            // repositoryItemSpinEdit2
            // 
            this.repositoryItemSpinEdit2.AutoHeight = false;
            this.repositoryItemSpinEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.repositoryItemSpinEdit2.MaskSettings.Set("mask", "n2");
            this.repositoryItemSpinEdit2.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2";
            // 
            // colDIEM_CK
            // 
            this.colDIEM_CK.AppearanceCell.Options.UseTextOptions = true;
            this.colDIEM_CK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDIEM_CK.AppearanceHeader.BackColor = System.Drawing.Color.Cyan;
            this.colDIEM_CK.AppearanceHeader.BorderColor = System.Drawing.Color.Black;
            this.colDIEM_CK.AppearanceHeader.Font = new System.Drawing.Font("SF Mono", 11F, System.Drawing.FontStyle.Bold);
            this.colDIEM_CK.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colDIEM_CK.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colDIEM_CK.AppearanceHeader.Options.UseBackColor = true;
            this.colDIEM_CK.AppearanceHeader.Options.UseBorderColor = true;
            this.colDIEM_CK.AppearanceHeader.Options.UseFont = true;
            this.colDIEM_CK.AppearanceHeader.Options.UseForeColor = true;
            this.colDIEM_CK.AppearanceHeader.Options.UseTextOptions = true;
            this.colDIEM_CK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDIEM_CK.Caption = "Điểm cuối kỳ";
            this.colDIEM_CK.ColumnEdit = this.repositoryItemSpinEdit3;
            this.colDIEM_CK.FieldName = "DIEM_CK";
            this.colDIEM_CK.MinWidth = 25;
            this.colDIEM_CK.Name = "colDIEM_CK";
            this.colDIEM_CK.Visible = true;
            this.colDIEM_CK.VisibleIndex = 4;
            this.colDIEM_CK.Width = 94;
            // 
            // repositoryItemSpinEdit3
            // 
            this.repositoryItemSpinEdit3.AutoHeight = false;
            this.repositoryItemSpinEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.repositoryItemSpinEdit3.MaskSettings.Set("mask", "n2");
            this.repositoryItemSpinEdit3.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.repositoryItemSpinEdit3.Name = "repositoryItemSpinEdit3";
            // 
            // colDIEM_TK
            // 
            this.colDIEM_TK.AppearanceCell.Font = new System.Drawing.Font("SF Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDIEM_TK.AppearanceCell.Options.UseFont = true;
            this.colDIEM_TK.AppearanceCell.Options.UseTextOptions = true;
            this.colDIEM_TK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDIEM_TK.AppearanceHeader.BackColor = System.Drawing.Color.Cyan;
            this.colDIEM_TK.AppearanceHeader.BorderColor = System.Drawing.Color.Black;
            this.colDIEM_TK.AppearanceHeader.Font = new System.Drawing.Font("SF Mono", 11F, System.Drawing.FontStyle.Bold);
            this.colDIEM_TK.AppearanceHeader.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.colDIEM_TK.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.colDIEM_TK.AppearanceHeader.Options.UseBackColor = true;
            this.colDIEM_TK.AppearanceHeader.Options.UseBorderColor = true;
            this.colDIEM_TK.AppearanceHeader.Options.UseFont = true;
            this.colDIEM_TK.AppearanceHeader.Options.UseForeColor = true;
            this.colDIEM_TK.AppearanceHeader.Options.UseTextOptions = true;
            this.colDIEM_TK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDIEM_TK.Caption = "Điểm hết môn";
            this.colDIEM_TK.FieldName = "colDIEM_TK";
            this.colDIEM_TK.MinWidth = 25;
            this.colDIEM_TK.Name = "colDIEM_TK";
            this.colDIEM_TK.OptionsColumn.AllowEdit = false;
            this.colDIEM_TK.OptionsColumn.ReadOnly = true;
            this.colDIEM_TK.UnboundDataType = typeof(string);
            this.colDIEM_TK.UnboundExpression = "Round(Iif(IsNullOrEmpty([DIEM_CC]), 0, [DIEM_CC]) * 0.1 + Iif(IsNullOrEmpty([DIEM" +
    "_GK]), 0, [DIEM_GK]) * 0.3 + Iif(IsNullOrEmpty([DIEM_CK]), 0, [DIEM_CK]) * 0.6, " +
    "1)";
            this.colDIEM_TK.Visible = true;
            this.colDIEM_TK.VisibleIndex = 5;
            this.colDIEM_TK.Width = 94;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.Root.Name = "Root";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition1.Width = 100D;
            this.Root.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1});
            rowDefinition1.Height = 30D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            rowDefinition2.Height = 100D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            this.Root.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2});
            this.Root.Size = new System.Drawing.Size(1698, 540);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControlScore;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem1.Size = new System.Drawing.Size(1678, 400);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.panelControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1678, 120);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // bdsDANGKY
            // 
            this.bdsDANGKY.DataMember = "DANGKY";
            this.bdsDANGKY.DataSource = this.QLDSV_TCDataSet;
            // 
            // QLDSV_TCDataSet
            // 
            this.QLDSV_TCDataSet.DataSetName = "QLDSV_TCDataSet";
            this.QLDSV_TCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.lblMain.TabIndex = 7;
            this.lblMain.Text = "QUẢN LÝ ĐIỂM SINH VIÊN LỚP TÍN CHỈ";
            // 
            // DANGKYTableAdapter
            // 
            this.DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // FrmQLCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1698, 660);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.panelChonKhoa);
            this.Controls.Add(this.lblMain);
            this.Name = "FrmQLCD";
            this.Text = "QUẢN LÝ ĐIỂM SV";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmQLCD_FormClosed);
            this.Load += new System.EventHandler(this.FrmQLCD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelChonKhoa)).EndInit();
            this.panelChonKhoa.ResumeLayout(false);
            this.panelChonKhoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHOTENGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMALTC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDANGKY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLDSV_TCDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelChonKhoa;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.GridControl gridControlScore;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewScore;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.LabelControl lblMain;
        private DevExpress.XtraEditors.SimpleButton btnExitSubForm;
        private DevExpress.XtraEditors.SimpleButton btnWriteScore;
        private DevExpress.XtraEditors.SimpleButton btnStart;
        private System.Windows.Forms.ComboBox cbNHOM;
        private System.Windows.Forms.ComboBox cbHOCKY;
        private System.Windows.Forms.ComboBox cbMONHOC;
        private System.Windows.Forms.ComboBox cbNIENKHOA;
        private QLDSV_TCDataSet QLDSV_TCDataSet;
        private System.Windows.Forms.BindingSource bdsDANGKY;
        private QLDSV_TCDataSetTableAdapters.DANGKYTableAdapter DANGKYTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTENSV;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM_CC;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM_GK;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM_CK;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit3;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM_TK;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.TextEdit txtHOTENGV;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtMAGV;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtMALTC;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}
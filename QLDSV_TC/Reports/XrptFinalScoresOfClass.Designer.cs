namespace QLDSV_TC.Reports
{
    partial class XrptFinalScoresOfClass
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition crossTabColumnDefinition1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(114.1667F);
            DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition crossTabColumnDefinition2 = new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(162.5F);
            DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition crossTabColumnDefinition3 = new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(100.635F);
            DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition crossTabColumnDefinition4 = new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(103.5316F);
            DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField crossTabColumnField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabDataField crossTabDataField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabDataField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition crossTabRowDefinition1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(30F);
            DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition crossTabRowDefinition2 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(30F);
            DevExpress.XtraReports.UI.CrossTab.CrossTabRowField crossTabRowField1 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowField();
            DevExpress.XtraReports.UI.CrossTab.CrossTabRowField crossTabRowField2 = new DevExpress.XtraReports.UI.CrossTab.CrossTabRowField();
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XrptFinalScoresOfClass));
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrlblCourseYear = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlblClassName = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrlblFaculty = new DevExpress.XtraReports.UI.XRLabel();
            this.label1 = new DevExpress.XtraReports.UI.XRLabel();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrCrossTab1 = new DevExpress.XtraReports.UI.XRCrossTab();
            this.crossTabDataCell1 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell2 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell3 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell4 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabTotalCell1 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell5 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell6 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell7 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabTotalCell2 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell8 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabHeaderCell1 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabTotalCell3 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabTotalCell4 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.crossTabTotalCell5 = new DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.pageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.TitleStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            this.barAndDockingController1 = new DevExpress.XtraBars.BarAndDockingController(this.components);
            this.crossTabGeneralStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabHeaderStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabDataStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.crossTabTotalStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.calOrdinalNumber = new DevExpress.XtraReports.UI.CalculatedField();
            ((System.ComponentModel.ISupportInitialize)(this.xrCrossTab1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrlblCourseYear,
            this.xrLabel2,
            this.xrLabel4,
            this.xrlblClassName,
            this.xrLabel1,
            this.xrlblFaculty,
            this.label1});
            this.ReportHeader.HeightF = 139.1797F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrlblCourseYear
            // 
            this.xrlblCourseYear.Font = new DevExpress.Drawing.DXFont("Times New Roman", 12F);
            this.xrlblCourseYear.LocationFloat = new DevExpress.Utils.PointFloat(580.635F, 83.67971F);
            this.xrlblCourseYear.Multiline = true;
            this.xrlblCourseYear.Name = "xrlblCourseYear";
            this.xrlblCourseYear.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlblCourseYear.SizeF = new System.Drawing.SizeF(111.8651F, 23F);
            this.xrlblCourseYear.StylePriority.UseFont = false;
            this.xrlblCourseYear.StylePriority.UseTextAlignment = false;
            this.xrlblCourseYear.Text = "2021-2022";
            this.xrlblCourseYear.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new DevExpress.Drawing.DXFont("Times New Roman", 12F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel2.ForeColor = System.Drawing.Color.Black;
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(497.3017F, 83.67971F);
            this.xrLabel2.Multiline = true;
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(83.33333F, 23F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseForeColor = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Khóa học:";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new DevExpress.Drawing.DXFont("Times New Roman", 12F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(318.2496F, 42F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(59.0521F, 23F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "Lớp:";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrlblClassName
            // 
            this.xrlblClassName.Font = new DevExpress.Drawing.DXFont("Times New Roman", 12F);
            this.xrlblClassName.LocationFloat = new DevExpress.Utils.PointFloat(377.3017F, 42F);
            this.xrlblClassName.Multiline = true;
            this.xrlblClassName.Name = "xrlblClassName";
            this.xrlblClassName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlblClassName.SizeF = new System.Drawing.SizeF(367.6146F, 23F);
            this.xrlblClassName.StylePriority.UseFont = false;
            this.xrlblClassName.StylePriority.UseTextAlignment = false;
            this.xrlblClassName.Text = "Công nghệ thông tin 2020";
            this.xrlblClassName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Times New Roman", 12F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(248.3333F, 83.67971F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(57.49998F, 23F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Khoa:";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrlblFaculty
            // 
            this.xrlblFaculty.Font = new DevExpress.Drawing.DXFont("Times New Roman", 12F);
            this.xrlblFaculty.LocationFloat = new DevExpress.Utils.PointFloat(305.8333F, 83.67971F);
            this.xrlblFaculty.Multiline = true;
            this.xrlblFaculty.Name = "xrlblFaculty";
            this.xrlblFaculty.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrlblFaculty.SizeF = new System.Drawing.SizeF(161.6667F, 23F);
            this.xrlblFaculty.StylePriority.UseFont = false;
            this.xrlblFaculty.StylePriority.UseTextAlignment = false;
            this.xrlblFaculty.Text = "Công nghệ thông tin";
            this.xrlblFaculty.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new DevExpress.Drawing.DXFont("Times New Roman", 20F, DevExpress.Drawing.DXFontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.label1.Name = "label1";
            this.label1.SizeF = new System.Drawing.SizeF(900F, 30.01301F);
            this.label1.StyleName = "TitleStyle";
            this.label1.StylePriority.UseFont = false;
            this.label1.StylePriority.UseForeColor = false;
            this.label1.StylePriority.UseTextAlignment = false;
            this.label1.Text = "BẢNG ĐIỂM TỔNG KẾT CUỐI KHÓA";
            this.label1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrCrossTab1});
            this.Detail.HeightF = 151.6536F;
            this.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnCount;
            this.Detail.Name = "Detail";
            // 
            // xrCrossTab1
            // 
            this.xrCrossTab1.Cells.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.crossTabDataCell1,
            this.crossTabHeaderCell2,
            this.crossTabHeaderCell3,
            this.crossTabHeaderCell4,
            this.crossTabTotalCell1,
            this.crossTabHeaderCell5,
            this.crossTabHeaderCell6,
            this.crossTabHeaderCell7,
            this.crossTabTotalCell2,
            this.crossTabHeaderCell8,
            this.crossTabHeaderCell1,
            this.crossTabTotalCell3,
            this.crossTabTotalCell4,
            this.crossTabTotalCell5});
            crossTabColumnDefinition1.AutoWidthMode = DevExpress.XtraReports.UI.AutoSizeMode.ShrinkAndGrow;
            crossTabColumnDefinition2.AutoWidthMode = DevExpress.XtraReports.UI.AutoSizeMode.ShrinkAndGrow;
            crossTabColumnDefinition3.AutoWidthMode = DevExpress.XtraReports.UI.AutoSizeMode.ShrinkAndGrow;
            crossTabColumnDefinition4.Visible = false;
            this.xrCrossTab1.ColumnDefinitions.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition[] {
            crossTabColumnDefinition1,
            crossTabColumnDefinition2,
            crossTabColumnDefinition3,
            crossTabColumnDefinition4});
            crossTabColumnField1.FieldName = "TENMH";
            this.xrCrossTab1.ColumnFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField[] {
            crossTabColumnField1});
            this.xrCrossTab1.DataAreaStyleName = "crossTabDataStyle1";
            crossTabDataField1.FieldName = "DIEM";
            this.xrCrossTab1.DataFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabDataField[] {
            crossTabDataField1});
            this.xrCrossTab1.DataMember = "SP_REPORT_GETFINALSCORESOFCLASS";
            this.xrCrossTab1.DataSource = this.sqlDataSource1;
            this.xrCrossTab1.GeneralStyleName = "crossTabGeneralStyle1";
            this.xrCrossTab1.HeaderAreaStyleName = "crossTabHeaderStyle1";
            this.xrCrossTab1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrCrossTab1.Name = "xrCrossTab1";
            crossTabRowDefinition1.Visible = false;
            crossTabRowDefinition2.Visible = false;
            this.xrCrossTab1.RowDefinitions.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition[] {
            new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(30F),
            new DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(30F),
            crossTabRowDefinition1,
            crossTabRowDefinition2});
            crossTabRowField1.FieldName = "MASV";
            crossTabRowField2.FieldName = "HOTEN";
            this.xrCrossTab1.RowFields.AddRange(new DevExpress.XtraReports.UI.CrossTab.CrossTabRowField[] {
            crossTabRowField1,
            crossTabRowField2});
            this.xrCrossTab1.SizeF = new System.Drawing.SizeF(480.8333F, 120F);
            this.xrCrossTab1.TotalAreaStyleName = "crossTabTotalStyle1";
            // 
            // crossTabDataCell1
            // 
            this.crossTabDataCell1.BorderColor = System.Drawing.Color.DimGray;
            this.crossTabDataCell1.ColumnIndex = 2;
            this.crossTabDataCell1.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F);
            this.crossTabDataCell1.Name = "crossTabDataCell1";
            this.crossTabDataCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.crossTabDataCell1.RowIndex = 1;
            // 
            // crossTabHeaderCell2
            // 
            this.crossTabHeaderCell2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.crossTabHeaderCell2.BorderColor = System.Drawing.Color.DimGray;
            this.crossTabHeaderCell2.ColumnIndex = 2;
            this.crossTabHeaderCell2.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.crossTabHeaderCell2.ForeColor = System.Drawing.Color.White;
            this.crossTabHeaderCell2.Name = "crossTabHeaderCell2";
            this.crossTabHeaderCell2.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.crossTabHeaderCell2.RowIndex = 0;
            this.crossTabHeaderCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // crossTabHeaderCell3
            // 
            this.crossTabHeaderCell3.BorderColor = System.Drawing.Color.DimGray;
            this.crossTabHeaderCell3.ColumnIndex = 0;
            this.crossTabHeaderCell3.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F);
            this.crossTabHeaderCell3.Name = "crossTabHeaderCell3";
            this.crossTabHeaderCell3.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.crossTabHeaderCell3.RowIndex = 1;
            // 
            // crossTabHeaderCell4
            // 
            this.crossTabHeaderCell4.ColumnIndex = 0;
            this.crossTabHeaderCell4.ColumnSpan = 2;
            this.crossTabHeaderCell4.Name = "crossTabHeaderCell4";
            this.crossTabHeaderCell4.RowIndex = 3;
            this.crossTabHeaderCell4.Text = "Grand Total";
            // 
            // crossTabTotalCell1
            // 
            this.crossTabTotalCell1.ColumnIndex = 2;
            this.crossTabTotalCell1.Name = "crossTabTotalCell1";
            this.crossTabTotalCell1.RowIndex = 3;
            // 
            // crossTabHeaderCell5
            // 
            this.crossTabHeaderCell5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.crossTabHeaderCell5.BorderColor = System.Drawing.Color.DimGray;
            this.crossTabHeaderCell5.ColumnIndex = 1;
            this.crossTabHeaderCell5.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.crossTabHeaderCell5.ForeColor = System.Drawing.Color.White;
            this.crossTabHeaderCell5.Name = "crossTabHeaderCell5";
            this.crossTabHeaderCell5.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.crossTabHeaderCell5.RowIndex = 0;
            this.crossTabHeaderCell5.Text = "Họ và tên";
            this.crossTabHeaderCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // crossTabHeaderCell6
            // 
            this.crossTabHeaderCell6.BorderColor = System.Drawing.Color.DimGray;
            this.crossTabHeaderCell6.ColumnIndex = 1;
            this.crossTabHeaderCell6.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F);
            this.crossTabHeaderCell6.Name = "crossTabHeaderCell6";
            this.crossTabHeaderCell6.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.crossTabHeaderCell6.RowIndex = 1;
            // 
            // crossTabHeaderCell7
            // 
            this.crossTabHeaderCell7.ColumnIndex = 0;
            this.crossTabHeaderCell7.ColumnSpan = 2;
            this.crossTabHeaderCell7.Name = "crossTabHeaderCell7";
            this.crossTabHeaderCell7.RowIndex = 2;
            this.crossTabHeaderCell7.TextFormatString = "Total {0}";
            // 
            // crossTabTotalCell2
            // 
            this.crossTabTotalCell2.ColumnIndex = 2;
            this.crossTabTotalCell2.Name = "crossTabTotalCell2";
            this.crossTabTotalCell2.RowIndex = 2;
            // 
            // crossTabHeaderCell8
            // 
            this.crossTabHeaderCell8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.crossTabHeaderCell8.BorderColor = System.Drawing.Color.DimGray;
            this.crossTabHeaderCell8.ColumnIndex = 0;
            this.crossTabHeaderCell8.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.crossTabHeaderCell8.ForeColor = System.Drawing.Color.White;
            this.crossTabHeaderCell8.Name = "crossTabHeaderCell8";
            this.crossTabHeaderCell8.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.crossTabHeaderCell8.RowIndex = 0;
            this.crossTabHeaderCell8.Text = "Mã SV";
            this.crossTabHeaderCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // crossTabHeaderCell1
            // 
            this.crossTabHeaderCell1.ColumnIndex = 3;
            this.crossTabHeaderCell1.Name = "crossTabHeaderCell1";
            this.crossTabHeaderCell1.RowIndex = 0;
            this.crossTabHeaderCell1.Text = "Grand Total";
            this.crossTabHeaderCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // crossTabTotalCell3
            // 
            this.crossTabTotalCell3.ColumnIndex = 3;
            this.crossTabTotalCell3.Name = "crossTabTotalCell3";
            this.crossTabTotalCell3.RowIndex = 1;
            // 
            // crossTabTotalCell4
            // 
            this.crossTabTotalCell4.ColumnIndex = 3;
            this.crossTabTotalCell4.Name = "crossTabTotalCell4";
            this.crossTabTotalCell4.RowIndex = 2;
            // 
            // crossTabTotalCell5
            // 
            this.crossTabTotalCell5.ColumnIndex = 3;
            this.crossTabTotalCell5.Name = "crossTabTotalCell5";
            this.crossTabTotalCell5.RowIndex = 3;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "QLDSV_TC.Properties.Settings.QLDSV_TCConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "SP_REPORT_GETFINALSCORESOFCLASS";
            queryParameter1.Name = "@MALOP";
            queryParameter1.Type = typeof(string);
            queryParameter1.ValueInfo = "D15CQCP01";
            storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1});
            storedProcQuery1.StoredProcName = "SP_REPORT_GETFINALSCORESOFCLASS";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pageInfo1,
            this.pageInfo2});
            this.BottomMargin.Name = "BottomMargin";
            // 
            // pageInfo1
            // 
            this.pageInfo1.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.pageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.pageInfo1.Name = "pageInfo1";
            this.pageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.pageInfo1.SizeF = new System.Drawing.SizeF(452.5F, 23F);
            this.pageInfo1.StylePriority.UseFont = false;
            this.pageInfo1.StylePriority.UsePadding = false;
            this.pageInfo1.StylePriority.UseTextAlignment = false;
            this.pageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.pageInfo1.TextFormatString = "{0:\'Ngày\' dd \'Tháng\' MM \'Năm\' yyyy}";
            // 
            // pageInfo2
            // 
            this.pageInfo2.Font = new DevExpress.Drawing.DXFont("Times New Roman", 10F, DevExpress.Drawing.DXFontStyle.Bold);
            this.pageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(452.5F, 0F);
            this.pageInfo2.Name = "pageInfo2";
            this.pageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.pageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.Number;
            this.pageInfo2.SizeF = new System.Drawing.SizeF(447.5F, 23F);
            this.pageInfo2.StylePriority.UseFont = false;
            this.pageInfo2.StylePriority.UsePadding = false;
            this.pageInfo2.StylePriority.UseTextAlignment = false;
            this.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.pageInfo2.TextFormatString = "Trang {0}";
            // 
            // TitleStyle
            // 
            this.TitleStyle.Font = new DevExpress.Drawing.DXFont("Arial", 18F);
            this.TitleStyle.Name = "TitleStyle";
            this.TitleStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // barAndDockingController1
            // 
            this.barAndDockingController1.PropertiesBar.AllowLinkLighting = false;
            // 
            // crossTabGeneralStyle1
            // 
            this.crossTabGeneralStyle1.BackColor = System.Drawing.Color.White;
            this.crossTabGeneralStyle1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.crossTabGeneralStyle1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.crossTabGeneralStyle1.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.crossTabGeneralStyle1.ForeColor = System.Drawing.Color.Black;
            this.crossTabGeneralStyle1.Name = "crossTabGeneralStyle1";
            this.crossTabGeneralStyle1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            // 
            // crossTabHeaderStyle1
            // 
            this.crossTabHeaderStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.crossTabHeaderStyle1.Name = "crossTabHeaderStyle1";
            this.crossTabHeaderStyle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // crossTabDataStyle1
            // 
            this.crossTabDataStyle1.Name = "crossTabDataStyle1";
            this.crossTabDataStyle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // crossTabTotalStyle1
            // 
            this.crossTabTotalStyle1.Name = "crossTabTotalStyle1";
            this.crossTabTotalStyle1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // calOrdinalNumber
            // 
            this.calOrdinalNumber.DataMember = "SP_REPORT_GETFINALSCORESOFCLASS";
            this.calOrdinalNumber.DataSource = this.sqlDataSource1;
            this.calOrdinalNumber.Expression = "[DataSource.CurrentRowIndex] + 1";
            this.calOrdinalNumber.Name = "calOrdinalNumber";
            // 
            // XrptFinalScoresOfClass
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.ReportHeader,
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.calOrdinalNumber});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.HorizontalContentSplitting = DevExpress.XtraPrinting.HorizontalContentSplitting.Smart;
            this.Landscape = true;
            this.PageHeight = 850;
            this.PageWidth = 1100;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.TitleStyle,
            this.crossTabGeneralStyle1,
            this.crossTabHeaderStyle1,
            this.crossTabDataStyle1,
            this.crossTabTotalStyle1});
            this.Version = "22.2";
            this.VerticalContentSplitting = DevExpress.XtraPrinting.VerticalContentSplitting.Smart;
            ((System.ComponentModel.ISupportInitialize)(this.xrCrossTab1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel label1;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRCrossTab xrCrossTab1;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabDataCell1;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell2;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell3;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell4;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell1;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell5;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell6;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell7;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell2;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell8;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabHeaderCell1;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell3;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell4;
        private DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell crossTabTotalCell5;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRControlStyle TitleStyle;
        private DevExpress.XtraBars.BarAndDockingController barAndDockingController1;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabGeneralStyle1;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabHeaderStyle1;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabDataStyle1;
        private DevExpress.XtraReports.UI.XRControlStyle crossTabTotalStyle1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        public DevExpress.XtraReports.UI.XRLabel xrlblFaculty;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        public DevExpress.XtraReports.UI.XRLabel xrlblClassName;
        public DevExpress.XtraReports.UI.XRLabel xrlblCourseYear;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo1;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo2;
        private DevExpress.XtraReports.UI.CalculatedField calOrdinalNumber;
    }
}

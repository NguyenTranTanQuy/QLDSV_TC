using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_TC.Reports
{
    public partial class XrptScoresCreditClass : DevExpress.XtraReports.UI.XtraReport
    {
        public XrptScoresCreditClass()
        {
            InitializeComponent();
        }

        public XrptScoresCreditClass(String schoolYear, int semester, String subjectCode, int group)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connectString;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = schoolYear;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = semester;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = subjectCode;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = group;
            this.sqlDataSource1.Fill();
        }
    }
}

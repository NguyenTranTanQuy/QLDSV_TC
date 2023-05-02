using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_TC.Reports
{
    public partial class XrptFinalScoresOfClass : DevExpress.XtraReports.UI.XtraReport
    {
        public XrptFinalScoresOfClass()
        {
            InitializeComponent();
        }

        public XrptFinalScoresOfClass(String classCode)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connectString;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = classCode;
            this.sqlDataSource1.Fill();
        }
    }
}

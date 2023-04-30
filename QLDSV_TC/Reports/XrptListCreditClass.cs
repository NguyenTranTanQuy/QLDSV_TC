using DevExpress.XtraReports.UI;
using System;

namespace QLDSV_TC.Reports
{
    public partial class XrptListCreditClass : XtraReport
    {
        public XrptListCreditClass()
        {
            InitializeComponent();
        }

        public XrptListCreditClass(String schoolYear, int semester)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connectString;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = schoolYear;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = semester;
            this.sqlDataSource1.Fill();
        }
    }
}

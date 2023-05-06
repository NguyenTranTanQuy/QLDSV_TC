using DevExpress.XtraReports.UI;

namespace QLDSV_TC.Reports
{
    public partial class XrptStudentsListCreditClass : XtraReport
    {
        public XrptStudentsListCreditClass()
        {
            InitializeComponent();
        }

        public XrptStudentsListCreditClass(string schoolYear, int semester, string subjectCode, int group)
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

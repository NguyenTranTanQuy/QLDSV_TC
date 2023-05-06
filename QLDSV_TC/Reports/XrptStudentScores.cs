using DevExpress.XtraReports.UI;

namespace QLDSV_TC.Reports
{
    public partial class XrptStudentScores : XtraReport
    {
        public XrptStudentScores()
        {
            InitializeComponent();
        }

        public XrptStudentScores(string studentNumber)
        {
            InitializeComponent();
            
            this.sqlDataSource1.Connection.ConnectionString = Program.connectString;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = studentNumber;
            this.sqlDataSource1.Fill();
        }
    }
}

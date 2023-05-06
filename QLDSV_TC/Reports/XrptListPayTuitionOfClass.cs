using DevExpress.XtraReports.UI;
using System.ComponentModel;

namespace QLDSV_TC.Reports
{
    public partial class XrptListPayTuitionOfClass : XtraReport
    {
        public XrptListPayTuitionOfClass()
        {
            InitializeComponent();
        }

        public XrptListPayTuitionOfClass(string classNumber, string schoolYear, int semester)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connectString;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = classNumber;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = schoolYear;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = semester;
            this.sqlDataSource1.Fill();
        }

        private void xrlblCurrencyToWords_BeforePrint(object sender, CancelEventArgs e)
        {
            string currencyToWords = Services.ConvertCurrencyToWords.ConvertMoneyToString(xrlblCurrency.Text.Replace(",", ""));
            
            xrlblCurrencyToWords.Text = Services.HandleString.UpperFirstCharInString(currencyToWords);
        }
    }
}

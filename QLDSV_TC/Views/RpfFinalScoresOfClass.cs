using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Windows.Forms;

namespace QLDSV_TC.Views
{
    public partial class RpfFinalScoresOfClass : XtraForm
    {
        private bool checkData()
        {
            if (lkLOP.EditValue == null)
            {
                MessageBox.Show("Lớp không được bỏ trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public RpfFinalScoresOfClass()
        {
            InitializeComponent();
        }

        private void RpfFinalScoresOfClass_Load(object sender, EventArgs e)
        {
            this.QLDSV_TCDataSet.EnforceConstraints = false;
            this.LOPTableAdapter.Fill(this.QLDSV_TCDataSet.LOP);
            
            cbKhoa.DataSource = Program.bdsDSPM;
            cbKhoa.DisplayMember = "TENKHOA";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedValue = Program.servername;

            if (Program.mGroup == "PGV")
                cbKhoa.Enabled = true;
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cbKhoa.SelectedValue.ToString();

            if (cbKhoa.SelectedIndex != Program.mPhongBan)
            {
                Program.mLogin = Program.remoteLogin;
                Program.mPassword = Program.remotePassword;
            }
            else
            {
                Program.mLogin = Program.mLoginDN;
                Program.mPassword = Program.mPasswordDN;
            }

            if (!Program.KetNoi())
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
                return;
            }
            else
            {
                this.LOPTableAdapter.Connection.ConnectionString = Program.connectString;
                this.LOPTableAdapter.Fill(this.QLDSV_TCDataSet.LOP);
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                String classCode = lkLOP.EditValue.ToString();
                String className = lkLOP.GetColumnValue("TENLOP").ToString();
                String courseYear = lkLOP.GetColumnValue("KHOAHOC").ToString();
                String facultyName = cbKhoa.Text;

                Reports.XrptFinalScoresOfClass xrpt = new Reports.XrptFinalScoresOfClass(classCode);

                xrpt.xrlblFaculty.Text = facultyName;
                xrpt.xrlblClassName.Text = className;
                xrpt.xrlblCourseYear.Text = courseYear;

                ReportPrintTool printTool = new ReportPrintTool(xrpt);
                printTool.ShowPreviewDialog();
            }
        }
    }
}
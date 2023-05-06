using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC.Views
{
    public partial class RpfListCreditClass : XtraForm
    {
        private void fillComboboxNienKhoa()
        {
            int currentYear = DateTime.Now.Year;

            for (int i = 2015; i <= currentYear - 1; i++)
                cbNIENKHOA.Items.Add((i.ToString() + "-" + (i + 1).ToString()));
        }

        private bool checkData()
        {
            if (cbNIENKHOA.Text == "")
            {
                MessageBox.Show("Niên khóa không được bỏ trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cbHOCKY.Text == "")
            {
                MessageBox.Show("Học kỳ không được bỏ trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public RpfListCreditClass()
        {
            InitializeComponent();
        }

        private void RpfListCreditClass_Load(object sender, EventArgs e)
        {
            fillComboboxNienKhoa();

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
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                string schoolYear = cbNIENKHOA.Text;
                int semester = Convert.ToInt32(this.cbHOCKY.Text);

                Reports.XrptListCreditClass xrpt = new Reports.XrptListCreditClass(schoolYear, semester);

                xrpt.xrlblFaculty.Text = cbKhoa.Text;
                xrpt.xrlblSchoolYear.Text = schoolYear;
                xrpt.xrlblSemester.Text = semester.ToString();

                ReportPrintTool printTool = new ReportPrintTool(xrpt);
                printTool.ShowPreviewDialog();
            }
        }
    }
}
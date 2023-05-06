using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Windows.Forms;

namespace QLDSV_TC.Views
{
    public partial class RpfStudentsListCreditClass : XtraForm
    {
        private void fillComboboxNienKhoa()
        {
            int currentYear = DateTime.Now.Year;

            for (int i = 2015; i <= currentYear - 1; i++)
                cbNIENKHOA.Items.Add((i.ToString() + "-" + (i + 1).ToString()));
        }

        private bool checkData()
        {
            if(cbNIENKHOA.Text == "")
            {
                MessageBox.Show("Niên khóa không được bỏ trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }

            if(cbHOCKY.Text == "")
            {
                MessageBox.Show("Học kỳ không được bỏ trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (lkMONHOC.EditValue == null)
            {
                MessageBox.Show("Môn học không được bỏ trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public RpfStudentsListCreditClass()
        {
            InitializeComponent();
        }

        private void RpfStudentsListCreditClass_Load(object sender, EventArgs e)
        {
            this.QLDSV_TCDataSet.EnforceConstraints = false;

            this.MONHOCTableAdapter.Fill(this.QLDSV_TCDataSet.MONHOC);

            fillComboboxNienKhoa();

            cbKhoa.DataSource = Program.bdsDSPM;
            cbKhoa.DisplayMember = "TENKHOA";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedValue = Program.servername;

            if (Program.mGroup == "PGV")
                cbKhoa.Enabled = true;

            lkMONHOC.Properties.Columns["SOTIET_LT"].Visible = false;
            lkMONHOC.Properties.Columns["SOTIET_TH"].Visible = false;
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
                string subjectName = lkMONHOC.Text;
                string subjectCode = lkMONHOC.EditValue.ToString();
                int group = Convert.ToInt32(nmNHOM.Value);

                Reports.XrptStudentsListCreditClass xrpt = new Reports.XrptStudentsListCreditClass(schoolYear, semester, subjectCode, group);


                xrpt.xrlblFaculty.Text = cbKhoa.Text;
                xrpt.xrlblSchoolYear.Text = schoolYear;
                xrpt.xrlblSemester.Text = semester.ToString();
                xrpt.xrlblSubject.Text = subjectName;
                xrpt.xrlblGroup.Text = group.ToString();

                ReportPrintTool printTool = new ReportPrintTool(xrpt);
                printTool.ShowPreviewDialog();
            }
        }
    }
}
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC.Views
{
    public partial class RpfListPayTuitionOfClass : XtraForm
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

            if (lkLOP.EditValue == null)
            {
                MessageBox.Show("Lớp không được bỏ trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private String getFacultyName(String facultyCode)
        {
            String facultyName = "";
            string query = "SELECT TENKHOA FROM KHOA WHERE MAKHOA = '" + facultyCode + "'";
            SqlDataReader result = Program.ExecSqlDataReader(query);

            if (result == null)
            {
                MessageBox.Show("Đã có lỗi xảy ra", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                result.Close();
                return null;
            }
            result.Read();
            facultyName = result.GetString(0);
            result.Close();
            return facultyName;
        }

        public RpfListPayTuitionOfClass()
        {
            InitializeComponent();
        }

        private void RpfListPayTuitionOfClass_Load(object sender, EventArgs e)
        {
            this.QLDSV_TCDataSet.EnforceConstraints = false;
            this.LOPTableAdapter.Fill(this.QLDSV_TCDataSet.LOP);

            fillComboboxNienKhoa();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                String classCode = lkLOP.EditValue.ToString();
                String schoolYear = cbNIENKHOA.Text;
                String facultyCode = lkLOP.GetColumnValue("MAKHOA").ToString();
                int semester = Convert.ToInt32(this.cbHOCKY.Text);

                String facultyName = getFacultyName(facultyCode);
                if (facultyName == null) return;

                Reports.XrptListPayTuitionOfClass xrpt = new Reports.XrptListPayTuitionOfClass(classCode, schoolYear, semester);

                xrpt.xrlblFaculty.Text = facultyName;
                xrpt.xrlblClassNumber.Text = classCode;
                xrpt.xrlblSchoolYear.Text = schoolYear;
                xrpt.xrlblSemester.Text = semester.ToString();

                ReportPrintTool printTool = new ReportPrintTool(xrpt);
                printTool.ShowPreviewDialog();
            }
        }
    }
}
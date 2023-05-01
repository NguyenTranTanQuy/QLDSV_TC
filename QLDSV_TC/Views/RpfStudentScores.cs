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
    public partial class RpfStudentScores : XtraForm
    {

        private bool checkData()
        {
            if (lkSINHVIEN.EditValue == null)
            {
                MessageBox.Show("Bạn chưa chọn Sinh viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        public RpfStudentScores()
        {
            InitializeComponent();
        }

        private void RpfStudentScores_Load(object sender, EventArgs e)
        {
            this.QLDSV_TCDataSet.EnforceConstraints = false;
            bdsSINHVIEN.Filter = "DANGHIHOC = 0";
            this.SINHVIENTableAdapter.Fill(this.QLDSV_TCDataSet.SINHVIEN);

            Program.bdsDSPM.Filter = "TENKHOA not LIKE 'Phòng kế toán%'";
            cbKhoa.DataSource = Program.bdsDSPM;
            cbKhoa.DisplayMember = "TENKHOA";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedValue = Program.servername;

            if (Program.mGroup == "PGV")
                cbKhoa.Enabled = true;

            if(Program.mGroup == "SV")
            {
                lkSINHVIEN.EditValue = Program.mLoginSV.ToUpper();
                lkSINHVIEN.Enabled = false;
            }    

            lkSINHVIEN.Properties.Columns["PHAI"].Visible = false;
            lkSINHVIEN.Properties.Columns["DIACHI"].Visible = false;
            lkSINHVIEN.Properties.Columns["NGAYSINH"].Visible = false;
            lkSINHVIEN.Properties.Columns["DANGHIHOC"].Visible = false;
            lkSINHVIEN.Properties.Columns["PASSWORD"].Visible = false;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                String studentScore = lkSINHVIEN.EditValue.ToString();
                String studentName = lkSINHVIEN.GetColumnValue("HO").ToString() + ' ' + lkSINHVIEN.GetColumnValue("TEN").ToString();
                String classNumber = lkSINHVIEN.GetColumnValue("MALOP").ToString();
                String faculty = cbKhoa.Text;

                Reports.XrptStudentScores xrpt = new Reports.XrptStudentScores(studentScore);

                xrpt.xrlblStudentNumber.Text = studentScore;
                xrpt.xrlblStudentName.Text = studentName;
                xrpt.xrlblClassNumber.Text = classNumber;
                xrpt.xrlblFaculty.Text = faculty;

                ReportPrintTool printTool = new ReportPrintTool(xrpt);
                printTool.ShowPreviewDialog();
            }
        }
    }
}
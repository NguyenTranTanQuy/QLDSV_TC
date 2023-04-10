using DevExpress.XtraEditors;
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
    public partial class FrmQLCD : DevExpress.XtraEditors.XtraForm
    {
        private int selectedIndexNIENKHOA = -1;
        private DataTable filteredData;
        private int CreditClassNumber = -1;
        private void fillDataTableScore()
        {
            this.DANGKYTableAdapter.Connection.ConnectionString = Program.connectString;
            this.DANGKYTableAdapter.Fill(this.QLDSV_TCDataSet.DANGKY);
        }

        private void fillComboboxNienKhoa()
        {
            String command = "SELECT DISTINCT(NIENKHOA) FROM LOPTINCHI WHERE HUYLOP = 0";
            DataTable data = Program.ExecSqlDataTable(command);
            cbNIENKHOA.DataSource = data;
            cbNIENKHOA.DisplayMember = "NIENKHOA";
            cbNIENKHOA.ValueMember = "NIENKHOA";
        }

        private void fillComboboxMonHoc()
        {
            String command = "EXEC SP_GETMONHOC_NK_HK '" + cbNIENKHOA.Text + "', " + cbHOCKY.Text;
            DataTable data = Program.ExecSqlDataTable(command);
            cbMONHOC.DataSource = data;
            cbMONHOC.DisplayMember = "TENMH";
            cbMONHOC.ValueMember = "MAMH";

            cbMONHOC.SelectedIndex = -1;
        }

        private void fillComboboxNhom()
        {
            String command = "EXEC SP_GETNHOM_NK_HK_MH '" + cbNIENKHOA.Text + "', " + cbHOCKY.Text + ", '" + cbMONHOC.SelectedValue + "'";
            filteredData = Program.ExecSqlDataTable(command);
            cbNHOM.DataSource = filteredData;
            cbNHOM.DisplayMember = "NHOM";
            cbNHOM.ValueMember = "NHOM";
        }

        private void refreshCombobox()
        {
            cbHOCKY.SelectedIndex = -1;
            cbMONHOC.SelectedIndex = -1;
            cbNHOM.SelectedIndex = -1;
        }

        public FrmQLCD()
        {
            InitializeComponent();
        }

        private void FrmQLCD_Load(object sender, EventArgs e)
        {
            this.QLDSV_TCDataSet.EnforceConstraints = false;

            fillComboboxNienKhoa();

            Program.bdsDSPM.Filter = "TENKHOA not LIKE 'Phòng kế toán%'";
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

            if (!Program.KetNoi())
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
                return;
            }
            else
            {
                fillComboboxNienKhoa();
                refreshCombobox();
            }
        }

        private void FrmQLCD_FormClosed(object sender, FormClosedEventArgs e)
        {
            cbKhoa.SelectedIndexChanged -= cbKhoa_SelectedIndexChanged;
        }

        private void gridViewScore_ShowingEditor(object sender, CancelEventArgs e)
        {
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            fillDataTableScore();
        }

        private void btnWriteScore_Click(object sender, EventArgs e)
        {

        }

        private void btnExitSubForm_Click(object sender, EventArgs e)
        {

        }

        private void cbHOCKY_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbHOCKY.SelectedIndex != -1)
            {
                fillComboboxMonHoc();

                if(cbMONHOC.Items.Count > 0)
                {
                    cbMONHOC.Enabled = true;
                }
                else
                {
                    cbMONHOC.DataSource = null;
                    cbMONHOC.Enabled = false;

                    cbNHOM.DataSource = null;
                    cbNHOM.Enabled = false;
                }
            }
            else
            {
                cbMONHOC.DataSource = null;
                cbMONHOC.Enabled = false;
            }
        }

        private void cbMONHOC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbMONHOC.SelectedIndex != -1)
            {
                fillComboboxNhom();

                cbNHOM.SelectedIndex = -1;    

                cbNHOM.Enabled = true;
            }
            else
            { 
                cbNHOM.DataSource = null;
                cbNHOM.Enabled = false;
            }
        }

        private void cbNIENKHOA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(selectedIndexNIENKHOA != cbNIENKHOA.SelectedIndex)
            {
                selectedIndexNIENKHOA = cbNIENKHOA.SelectedIndex;
                refreshCombobox();
            }
        }

        private void cbNHOM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbNHOM.SelectedIndex != -1)
            {
                DataView dv = new DataView(filteredData);
                dv.RowFilter = "NHOM = " + cbNHOM.SelectedValue;
                CreditClassNumber = Convert.ToInt32(dv.ToTable().Rows[0]["MALTC"]);

                btnStart.Enabled = true;
            }
            else
            {
                btnStart.Enabled=false;
            }
        }
    }
}
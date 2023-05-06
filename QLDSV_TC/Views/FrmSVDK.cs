using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLDSV_TC.Views
{
    public partial class FrmSVDK : XtraForm
    {
        private void fillStudentInformation()
        {
            string command = "EXEC SP_GETTHONGTINSV " + "'" + Program.mUserName + "'";
            Program.myReader = Program.ExecSqlDataReader(command);

            if (Program.myReader == null) return;

            Program.myReader.Read();
            txtHOTEN.Text = Program.myReader.GetString(0);
            txtMALOP.Text = Program.myReader.GetString(1);

            Program.myReader.Close();
        }

        private void fillComboboxNienKhoa()
        {
            string command = "EXEC SP_GETKHOAHOC_SV " + "'" + Program.mUserName + "'";
            Program.myReader = Program.ExecSqlDataReader(command);

            if (Program.myReader == null) return;

            Program.myReader.Read();

            string nienKhoa = Program.myReader.GetString(0);
            Program.myReader.Close();

            int fromYear;
            if (int.TryParse(nienKhoa.Split('-')[0], out fromYear))
            {
                int currentYear = DateTime.Now.Year;

                for (int i = fromYear; i <= currentYear - 1; i++)
                    cbNIENKHOA.Items.Add((i.ToString() + "-" + (i + 1).ToString()));
            }
        }
        
        private void fillTableCreditClass()
        {
            try
            {
                this.QLDSV_TCDataSet.EnforceConstraints = false;
                this.SP_GETDSLTC_NK_HKTableAdapter.Connection.ConnectionString = Program.connectString;
                this.SP_GETDSLTC_NK_HKTableAdapter.Fill(this.QLDSV_TCDataSet.SP_GETDSLTC_NK_HK, cbNIENKHOA.Text, Convert.ToInt32(cbHOCKY.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if(this.gridViewCreditClass.RowCount == 0)
                btnRegister.Enabled = false;
            btnRemoveRegister.Enabled = false;
        }

        private void fillTableRegisterStudent()
        {
            try
            {
                this.QLDSV_TCDataSet.EnforceConstraints = false;
                this.SP_DSDK_SVTableAdapter.Connection.ConnectionString = Program.connectString;
                this.SP_DSDK_SVTableAdapter.Fill(this.QLDSV_TCDataSet.SP_DSDK_SV,  Program.mUserName, cbNIENKHOA.Text, Convert.ToInt32(cbHOCKY.Text), Program.hocPhi);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btnRemoveRegister.Enabled = false;
        }

        public FrmSVDK()
        {
            InitializeComponent();
        }

        private void FrmSVDK_Load(object sender, EventArgs e)
        {
            fillStudentInformation();
            fillComboboxNienKhoa();
        }

        private void btnExitSubForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbNIENKHOA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNIENKHOA.SelectedIndex == -1 || cbHOCKY.SelectedIndex == -1) return;

            fillTableCreditClass();
            fillTableRegisterStudent();
        }

        private void cbHOCKY_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNIENKHOA.SelectedIndex == -1 || cbHOCKY.SelectedIndex == -1) return;

            fillTableCreditClass();
            fillTableRegisterStudent();
        }

        private void gridViewCreditClass_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            btnRegister.Enabled = true;
        }

        private void gridViewRegister_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            btnRemoveRegister.Enabled = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (Program.connect.State == ConnectionState.Closed) Program.connect.Open();

            String maLTC = gridViewCreditClass.GetRowCellValue(gridViewCreditClass.FocusedRowHandle, "MALTC").ToString();
            String maMH = gridViewCreditClass.GetRowCellValue(gridViewCreditClass.FocusedRowHandle, "MAMH").ToString();

            String spString = "SP_DKY_LOPTINCHI";
            SqlCommand command = Program.connect.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = spString;
            command.Parameters.Add("@MALTC", SqlDbType.Int).Value = maLTC;
            command.Parameters.Add("@NIENKHOA", SqlDbType.NChar).Value = cbNIENKHOA.Text;
            command.Parameters.Add("@HOCKY", SqlDbType.Int).Value = Convert.ToInt32(cbHOCKY.Text);
            command.Parameters.Add("@MAMH", SqlDbType.NChar).Value = maMH;
            command.Parameters.Add("@MASV", SqlDbType.NChar).Value = Program.mUserName;
            command.Parameters.Add("@CHIPHI", SqlDbType.Int).Value = Program.hocPhi;

            try
            {
                command.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Program.connect.Close();
            }

            fillTableRegisterStudent();
        }

        private void btnRemoveRegister_Click(object sender, EventArgs e)
        {
            if (Program.connect.State == ConnectionState.Closed) Program.connect.Open();

            String maLTC = gridViewRegister.GetRowCellValue(gridViewRegister.FocusedRowHandle, "MALTC").ToString();
            String maMH = gridViewRegister.GetRowCellValue(gridViewRegister.FocusedRowHandle, "MAMH").ToString();

            String spString = "SP_DELETE_DKY_SV";
            SqlCommand command = Program.connect.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = spString;
            command.Parameters.Add("@MALTC", SqlDbType.Int).Value = maLTC;
            command.Parameters.Add("@NIENKHOA", SqlDbType.NChar).Value = cbNIENKHOA.Text;
            command.Parameters.Add("@HOCKY", SqlDbType.Int).Value = Convert.ToInt32(cbHOCKY.Text);
            command.Parameters.Add("@MASV", SqlDbType.NChar).Value = Program.mUserName;
            command.Parameters.Add("@CHIPHI", SqlDbType.Int).Value = Program.hocPhi;

            try
            {
                command.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi hủy đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Program.connect.Close();
            }

            fillTableRegisterStudent();
        }
    }
}
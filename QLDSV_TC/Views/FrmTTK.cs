using DevExpress.XtraEditors;
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
    public partial class FrmTTK : DevExpress.XtraEditors.XtraForm
    {
        private bool checkFormData()
        {
            if (txtUsername.Text.Trim() == "")
            {
                MessageBox.Show("Mã tài khoản không được để trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (txtUsername.Text.Trim().Contains(" "))
            {
                MessageBox.Show("Mã tài khoản không được chứa khoảng trắng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được để trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (txtPassword.Text.Contains(" "))
            {
                MessageBox.Show("Mật khẩu không được chứa khoảng trắng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtConfirmPassword.Text.Trim() == "")
            {
                MessageBox.Show("Xác thực mật khẩu không được để trống.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Xác thực mật khẩu không trùng khớp.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cbGV.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn giảng viên.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void getTeacher()
        {
            string command = "SELECT MAGV, HOTEN = RTRIM(MAGV) + ' - ' + HO + ' ' + TEN FROM GIANGVIEN";
            DataTable data = Program.ExecSqlDataTable(command);
            BindingSource bdsGV = new BindingSource();
            bdsGV.DataSource = data;

            cbGV.DataSource = bdsGV;
            cbGV.DisplayMember = "HOTEN";
            cbGV.ValueMember = "MAGV";
        }

        public FrmTTK()
        {
            InitializeComponent();
        }

        private void FrmTTK_Load(object sender, EventArgs e)
        {
            Program.bdsDSPM.Filter = "TENKHOA not LIKE 'Phòng kế toán%'  ";
            cbKhoa.DataSource = Program.bdsDSPM;
            cbKhoa.DisplayMember = "TENKHOA";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedValue = Program.servername;

            getTeacher();

            if (Program.mGroup == "PGV")
            {
                cbKhoa.Enabled = true;
                rdgGroup.Properties.Items[0].Enabled = true;
                rdgGroup.Properties.Items[1].Enabled = true;
                rdgGroup.SelectedIndex = 0;
            }
            else if (Program.mGroup == "KHOA")
            {
                rdgGroup.Properties.Items[1].Enabled = true;
                rdgGroup.SelectedIndex = 1;
            }
            else
            {
                rdgGroup.Properties.Items[2].Enabled = true;
                rdgGroup.SelectedIndex = 2;
            }
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim().Length > 0 || txtPassword.Text.Trim().Length > 0 || txtConfirmPassword.Text.Trim().Length > 0 || cbGV.SelectedIndex == -1)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if(checkFormData())
            {
                String login = txtUsername.Text.Trim();
                String password = txtPassword.Text.Trim();
                String user = cbGV.SelectedValue.ToString();
                String role = rdgGroup.EditValue.ToString();

                String query = " DECLARE @return_value INT" +

                               " EXEC @return_value = [dbo].[SP_TAOLOGIN]" +

                               " N'" + login + "', " +

                               " N'" + password + "', " +

                               " N'" + user + "', " +

                               " N'" + role + "'" +

                               " SELECT @return_value";

                int resultMa = Program.CheckPrimaryKey(query);
                if (resultMa == -1)
                {
                    MessageBox.Show("Lỗi kết nối với database. Vui long thử lại sau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (resultMa == 1)
                {
                    MessageBox.Show("Mã tài khoản đã tồn tại. Mời bạn nhập mã khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (resultMa == 2)
                {
                    MessageBox.Show("Giảng viên này đã có tài khoản. Vui lòng chọn lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if(resultMa == 0)
                {
                    MessageBox.Show("Tạo tài khoản thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
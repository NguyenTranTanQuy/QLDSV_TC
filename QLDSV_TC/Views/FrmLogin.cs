using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class FrmLogin : XtraForm
    {
        private SqlConnection conn_publisher = new SqlConnection();

        private bool connectCSDlGoc()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
                conn_publisher.Close();

            try { 
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                return true;
            } 
            catch (Exception e) {
                MessageBox.Show("Lỗi kết nối\n" + e.Message);
                return false;
            }
        }

        private void getDSPM()
        {
                DataTable dt = new DataTable();

                if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();

                String cmd = "SELECT * FROM V_DS_PHANMANH";
                SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
                da.Fill(dt);

                conn_publisher.Close();
                Program.bdsDSPM.DataSource = dt;
                cbKhoa.DataSource = Program.bdsDSPM;
                cbKhoa.DisplayMember = "TENKHOA";
                cbKhoa.ValueMember = "TENSERVER";
        }

        private bool checkData()
        {
            if(txtUsername.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tài khoản không được để trống", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return false;
            }

            if(txtPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mật khẩu không được để trống", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return false;
            }

            return true;
        }
        
        public void loadData()
        {
            cbKhoa.SelectedItem = Program.mGroup;
            
            Program.mLogin = "";
            Program.mPassword = "";
            Program.mLoginSV = "";
            Program.mPasswordSV = "";
            Program.myReader = null;

            txtUsername.Text = null;
            txtPassword.Text = null;
            txtUsername.Focus();
        }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            if (connectCSDlGoc() == false) return;
            getDSPM();

            cbKhoa.SelectedIndex = 1;cbKhoa.SelectedIndex = 0;

            txtUsername.Text = "LNKT";
            txtPassword.Text = "123456";
            cbKhoa.SelectedIndex = 0;
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cbKhoa.SelectedValue.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                String username = txtUsername.Text;
                String password = txtPassword.Text;

                if (chkIsStudent.Checked && !cbKhoa.Text.ToString().Equals("Phòng kế toán"))
                {
                    Program.mLogin = "SINHVIEN";
                    Program.mPassword = "123456";

                    Program.mLoginSV = username;
                    Program.mPasswordSV = password;

                    if (Program.KetNoi() == false) return;

                    String sql = "EXEC SP_SV_DANGNHAP '" + Program.mLoginSV + "','" + Program.mPasswordSV + "'";
                    Program.myReader = Program.ExecSqlDataReader(sql);
                }
                else if (!chkIsStudent.Checked)
                {
                    Program.mLogin = username;
                    Program.mPassword = password;


                    if (Program.KetNoi() == false) return;

                    String sql = "EXEC SP_DANGNHAP '" + Program.mLogin + "'";
                    Program.myReader = Program.ExecSqlDataReader(sql);
                }
                else
                {
                    MessageBox.Show("Tài khoản của Sinh viên không được đăng nhập vào phòng kế toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Program.mPhongBan = cbKhoa.SelectedIndex;
                Program.mLoginDN = Program.mLogin;
                Program.mPasswordDN = Program.mPassword;

                if (Program.myReader == null) return;

                Program.myReader.Read();
                try
                {
                    Program.mUserName = Program.myReader.GetString(0);
                    if (Convert.IsDBNull(Program.mUserName))
                    {
                        MessageBox.Show("Login không có quyền truy cập dữ liệu", "", MessageBoxButtons.OK);
                        return;
                    }
                    Program.mName = Program.myReader.GetString(1);
                    Program.mGroup = Program.myReader.GetString(2);
                    Program.myReader.Close();

                    Program.frmMain = new FrmMain();
                    Program.frmMain.statuslblMa.Text = "MÃ: " + Program.mUserName.ToUpper();
                    Program.frmMain.statuslblHoten.Text = "HỌ VÀ TÊN: " + Program.mName;
                    Program.frmMain.statuslblNhom.Text = "NHÓM QUYỀN: " + Program.mGroup;

                    this.Visible = false;
                    Program.frmMain.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ \n Vui lòng kiểm tra lại!\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {       
            Application.Exit();
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            DialogResult dialogResult = MessageBox.Show("Bạn chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                e.Cancel = false;
            }
        }

        private void chkIsStudent_CheckStateChanged(object sender, EventArgs e)
        {
            if (lblUsername.Text == "Tài khoản:")
                lblUsername.Text = "Mã SV:";
            else
            {
                lblUsername.Text = "Tài khoản:";
            }
        }
    }
}

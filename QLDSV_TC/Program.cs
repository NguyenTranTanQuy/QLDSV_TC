using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLDSV_TC
{
    internal static class Program
    {
        public static SqlConnection connect = new SqlConnection();
        public static String connectString;
        
        public static String connstr_publisher = "Data Source=LAPTOP-GDMEGRIH\\OWNER;Initial Catalog=QLDSV_TC;Integrated Security=True";
        public static String servername = "";
        public static BindingSource bdsDSPM = new BindingSource();

        public static String database = "QLDSV_TC";
        public static String mLogin;
        public static String mPassword;

        public static String mLoginDN;
        public static String mPasswordDN;

        public static String mLoginSV = "";
        public static String mPasswordSV = "";

        public static String mUserName;
        public static String mName;
        public static String mGroup;

        public static String remotelogin = "HTKN";
        public static String remotepassword = "123456";

        public static String defaultPasswordSV = "123456";

        public static SqlDataReader myReader;

        public static FrmLogin frmLogin;
        public static FrmMain frmMain;
        public static Views.FrmQLSV frmQLSV;

        public static bool KetNoi()
        {
            if (Program.connect.State == ConnectionState.Open) Program.connect.Close();
            try
            {
                Program.connectString = "Data Source=" + Program.servername + ";Initial Catalog=" + Program.database + ";User ID=" +
                      Program.mLogin + ";password=" + Program.mPassword;
                Program.connect.ConnectionString = Program.connectString;
                Program.connect.Open();
                return true;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static DataTable ExecSqlDataTable(string cmd)
        {
            DataTable dt = new DataTable();
            if (Program.connect.State == ConnectionState.Closed) Program.connect.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, Program.connect);
            da.Fill(dt);
            Program.connect.Close();
            return dt;
        }

        public static SqlDataReader ExecSqlDataReader(String cmd)
        {
            SqlDataReader myReader;
            SqlCommand sqlcmd = new SqlCommand(cmd, Program.connect);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.connect.State == ConnectionState.Closed) Program.connect.Open();
            try
            {
                myReader = sqlcmd.ExecuteReader();
                return myReader;
            }
            catch (SqlException ex)
            {
                Program.connect.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable ExecSqlQuery(String cmd, String connectionstring)
        {
            DataTable dt = new DataTable();
            if (Program.connect.State == ConnectionState.Closed) Program.connect.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, connect);
            da.Fill(dt);
            Program.connect.Close();
            return dt;
        }


        public static void ExecSqlNonQuery(String cmd)
        {
            SqlCommand sqlcmd = new SqlCommand(cmd, Program.connect);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 600;
            if (Program.connect.State == ConnectionState.Closed) Program.connect.Open();
            try
            {
                sqlcmd.ExecuteNonQuery(); //conn.Close()
                MessageBox.Show("Thao tác thành công!!", "", MessageBoxButtons.OK);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                Program.connect.Close();
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            frmLogin = new FrmLogin();
            Application.Run(frmLogin);
        }
    }
}

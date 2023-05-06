using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLDSV_TC
{
    internal static class Program
    {
        public static SqlConnection connect = new SqlConnection();
        public static string connectString;
        
        public static string connstr_publisher = "Data Source=LAPTOP-GDMEGRIH\\OWNER;Initial Catalog=QLDSV_TC;Integrated Security=True";
        public static string servername = "";

        public static BindingSource bdsDSPM = new BindingSource();

        public static string database = "QLDSV_TC";
        public static string mLogin;
        public static string mPassword;

        public static string mLoginDN;
        public static string mPasswordDN;

        public static string mLoginSV = "";
        public static string mPasswordSV = "";

        public static string mUserName;
        public static string mName;
        public static string mGroup;
        public static int mPhongBan;

        public static string remoteLogin = "HTKN";
        public static string remotePassword = "123456";

        public static string defaultPasswordSV = "123456";

        public static SqlDataReader myReader;

        public static FrmLogin frmLogin;
        public static FrmMain frmMain;

        public static Views.FrmQLSV frmQLSV;
        public static Views.FrmQLLH frmQLLH;
        public static Views.FrmQLMH frmQLMH;
        public static Views.FrmQLLTC frmQLLTC;
        public static Views.FrmQLCD frmQLCD;
        public static Views.FrmSVDK frmSVDK;
        public static Views.FrmQLHP frmQLHP;
        public static Views.FrmTTK frmTTK;

        public static Views.RpfStudentsListCreditClass rpfStudentsListCreditClass;
        public static Views.RpfListCreditClass rpfListCreditClass;
        public static Views.RpfScoresCreditClass rpfScoresCreditClass;
        public static Views.RpfStudentScores rpfStudentScores;
        public static Views.RpfListPayTuitionOfClass rpfListPayTuitionOfClass;
        public static Views.RpfFinalScoresOfClass rpfFinalScoresOfClass;

        public static int hocPhi = 550000;

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

        public static SqlDataReader ExecSqlDataReader(string cmd)
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

        public static DataTable ExecSqlQuery(string cmd)
        {
            DataTable dt = new DataTable();
            if (Program.connect.State == ConnectionState.Closed) Program.connect.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, connect);
            da.Fill(dt);
            Program.connect.Close();
            return dt;
        }

        public static void ExecSqlNonQuery(string cmd)
        {
            SqlCommand sqlcmd = new SqlCommand(cmd, Program.connect);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 600;
            if (Program.connect.State == ConnectionState.Closed) Program.connect.Open();
            try
            {
                sqlcmd.ExecuteNonQuery();
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

        public static int CheckPrimaryKey(string query)
        {
            SqlDataReader dataReader = Program.ExecSqlDataReader(query);
            if (dataReader == null)
                return -1;

            dataReader.Read();
            int result = dataReader.GetInt32(0);
            dataReader.Close();
            return result;
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

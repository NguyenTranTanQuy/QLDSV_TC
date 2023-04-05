using DevExpress.ChartRangeControlClient.Core;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask.Design;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLDSV_TC.Views
{
    public partial class FrmQLLH : DevExpress.XtraEditors.XtraForm
    {
        private Stack<Services.ProcessStore> processStoreStack = new Stack<Services.ProcessStore>();
        private String flagMode = "";
        private int positionSelectedClass = -1;

        private void pushDataToProcessStack(DataRow data)
        {
            Lop lop = new Lop(data["MALOP"].ToString(), data["TENLOP"].ToString()
                , data["KHOAHOC"].ToString(), data["MAKHOA"].ToString());

            processStoreStack.Push(new Services.ProcessStore(flagMode, data["MALOP"].ToString(), lop));
        }

        private bool checkDataClass()
        {
            DataRowView dataClass = (DataRowView)bdsLOP[positionSelectedClass];
            if (dataClass["MALOP"].ToString().Trim() == "")
            {
                MessageBox.Show("Mã lớp không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dataClass["TENLOP"].ToString().Trim() == "")
            {
                MessageBox.Show("Tên lớp không được thiếu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            if (dataClass["KHOAHOC"].ToString().Trim() == "")
            {
                MessageBox.Show("Khóa học không được thiếu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dataClass["MAKHOA"].ToString() == "")
            {
                MessageBox.Show("Mã khoa không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (flagMode == "ADDCLASS")
            {
                string query = " DECLARE @return_value INT" +

                               " EXEC @return_value = [dbo].[SP_CHECKMALOP]" +

                               " N'" + dataClass["MALOP"].ToString().Trim() + "' " +

                               " SELECT @return_value";

                int resultMa = Program.CheckPrimaryKey(query);
                if (resultMa == -1)
                {
                    MessageBox.Show("Lỗi kết nối với database.\n Vui long thử lại sau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (resultMa == 1)
                {
                    MessageBox.Show("Mã lớp đã tồn tại.\n Mời bạn nhập mã khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (resultMa == 2)
                {
                    MessageBox.Show("Mã lớp đã tồn tại ở khoa khác.\n Mời bạn nhập lại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }   
            }

            if (flagMode == "ADDCLASS" || flagMode == "EDITCLASS")
            {
                string query = " DECLARE @return_value INT" +

                               " EXEC @return_value = [dbo].[SP_CHECKTENLOP]" +

                               " N'" + dataClass["TENLOP"].ToString().Trim() + "' " +

                               " SELECT @return_value";

                int resultMa = Program.CheckPrimaryKey(query);
                if (resultMa == -1)
                {
                    MessageBox.Show("Lỗi kết nối với database.\n Vui long thử lại sau!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (resultMa == 1)
                {
                    MessageBox.Show("Tên lớp đã tồn tại.\n Mời bạn nhập mã khác !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                if (resultMa == 2)
                {
                    MessageBox.Show("Tên lớp đã tồn tại ở khoa khác.\n Mời bạn nhập lại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        public static string GetMaKhoa()
        {
            DataTable dt = Program.ExecSqlDataTable("SELECT MAKHOA FROM KHOA");
            String facultyCode = dt.Rows[0][0].ToString();

            return facultyCode;
        }

        public FrmQLLH()
        {
            InitializeComponent();
        }

        private void FrmQLLH_Load(object sender, EventArgs e)
        {
            this.qLDSV_TCDataSet.EnforceConstraints = false;

            this.LOPTableAdapter.Connection.ConnectionString = Program.connectString;
            this.LOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);

            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connectString;
            this.SINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN);

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
                this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connectString;
                this.SINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN);

                this.LOPTableAdapter.Connection.ConnectionString = Program.connectString;
                this.LOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);

                processStoreStack.Clear();
                btnRecover.Enabled = false;
            }
        }

        private void FrmQLLH_FormClosed(object sender, FormClosedEventArgs e)
        {
            cbKhoa.SelectedIndexChanged -= cbKhoa_SelectedIndexChanged;
        }

        private void gridViewLOP_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if ((flagMode == "EDITSTUDENT" || flagMode == "ADDSTUDENT") && gridViewClass.FocusedRowHandle != positionSelectedClass)
            {
                DialogResult dialog = MessageBox.Show("Bạn đang trong quá trình chỉnh sửa thông tin bạn thật sự muốn làm mới không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.No)
                {
                    gridViewClass.FocusedRowHandle = positionSelectedClass;
                    return;
                }
                else
                {
                    flagMode = "";
                    positionSelectedClass = -1;
                }
            }
            btnAdd.Enabled = cbKhoa.Enabled = true;
            btnDelete.Enabled = btnEdit.Enabled = btnWrite.Enabled = false;
        }

        private void gridViewClass_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (bdsLOP.Position != positionSelectedClass
                || (gridViewClass.FocusedColumn.FieldName == "MALOP" && flagMode.Equals("EDITCLASS"))
                || (gridViewClass.FocusedColumn.FieldName == "MAKHOA" && flagMode.Equals("ADDCLASS")))
                e.Cancel = true;
        }

        private void gridViewClass_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (gridViewClass.FocusedColumn.FieldName == "MALOP")
            {
                bool match = Regex.IsMatch(e.Value.ToString().ToUpper(), "[D][0-9][0-9][A-Z][A-Z][A-Z][A-Z][0-9][0-9]");
                if (!match || e.Value.ToString().Trim().Length != 9)
                {
                    e.ErrorText = "Mã lớp bạn nhập không hợp lệ hoặc độ dài không đủ 9 kí tự\n Ví dụ: D20CQCN02";
                    e.Valid = false;
                }
                else
                {
                    e.Value = e.Value.ToString().ToUpper();
                }
            }

            if (gridViewClass.FocusedColumn.FieldName == "KHOAHOC")
            {
                bool match = Regex.IsMatch(e.Value.ToString().ToUpper(), "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]");
                if (!match || e.Value.ToString().Trim().Length < 9)
                {
                    e.ErrorText = "Khóa học bạn nhập không hợp lệ \n Ví dụ: 2020-2025";
                    e.Valid = false;
                }
                else
                {
                    e.Value = e.Value.ToString().ToUpper();
                }
            }

            if (gridViewClass.FocusedColumn.FieldName == "TENLOP" || gridViewClass.FocusedColumn.FieldName == "KHOAHOC")
            {
                if (e.Value.ToString().Trim().Length == 0)
                {
                    e.ErrorText = "Không được để trống ô này";
                    e.Valid = false;
                }
            }

            if (gridViewClass.FocusedColumn.FieldName == "TENLOP")
            {
                TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
                e.Value = textInfo.ToTitleCase(e.Value.ToString().ToLower());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bdsLOP.AddNew();
            
            gridViewClass.SetFocusedRowCellValue("MAKHOA", GetMaKhoa());

            positionSelectedClass = bdsLOP.Count - 1;

            btnAdd.Enabled = btnRecover.Enabled = cbKhoa.Enabled = false;
            btnWrite.Enabled = true;

            flagMode = "ADDCLASS";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            positionSelectedClass = gridViewClass.FocusedRowHandle;

            flagMode = "EDITCLASS";

            DataRow data = gridViewClass.GetFocusedDataRow();
            pushDataToProcessStack(data);

            btnWrite.Enabled = true;
            btnDelete.Enabled = btnEdit.Enabled = btnRecover.Enabled = cbKhoa.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String MALOP = "";
            if (bdsSINHVIEN.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp này vì đã có sinh viên trong lớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Bạn có thật sự muốn xóa lớp học này ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                try
                {
                    DataRow data = gridViewClass.GetFocusedDataRow();
                    MALOP = data["MALOP"].ToString();

                    flagMode = "DELETECLASS";
                    pushDataToProcessStack(data);

                    data.Delete();

                    this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connectString;
                    this.SINHVIENTableAdapter.Update(this.qLDSV_TCDataSet.SINHVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp: " + ex.Message, "", MessageBoxButtons.OK);
                    this.SINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN);
                    bdsSINHVIEN.Position = bdsSINHVIEN.Find("MALOP", MALOP);
                    processStoreStack.Pop();
                    flagMode = "";
                    return;
                }
            }

            btnAdd.Enabled = btnRecover.Enabled = true;
            btnDelete.Enabled = btnEdit.Enabled = false;
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (checkDataClass())
            {
                try
                {
                    bdsLOP.EndEdit();
                    bdsLOP.ResetCurrentItem();

                    this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connectString;

                    DataRow row = ((DataRowView)bdsLOP[bdsLOP.Position]).Row;
                    this.LOPTableAdapter.Update(row);

                    if (flagMode == "ADDCLASS")
                        processStoreStack.Push(new Services.ProcessStore(flagMode, row["MALOP"].ToString()));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi lớp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                flagMode = "";
                positionSelectedClass = -1;

                btnAdd.Enabled = btnRecover.Enabled = cbKhoa.Enabled = true;
                btnWrite.Enabled = false;
            }
        }
    }
}
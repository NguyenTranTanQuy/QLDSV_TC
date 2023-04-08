using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using QLDSV_TC.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QLDSV_TC.Views
{
    public partial class FrmQLLH : XtraForm
    {
        private Stack<ProcessStore> processStoreStack = new Stack<ProcessStore>();
        private String flagMode = "";
        private int positionSelectedClass = -1;

        private void pushDataToProcessStack(DataRow data)
        {
            Lop lop = new Lop(data["MALOP"].ToString(), data["TENLOP"].ToString()
                , data["KHOAHOC"].ToString(), data["MAKHOA"].ToString());

            processStoreStack.Push(new Services.ProcessStore(flagMode, data["MALOP"].ToString(), lop));
        }

        private void fillDataTableClass()
        {
            this.LOPTableAdapter.Connection.ConnectionString = Program.connectString;
            this.LOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);

            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connectString;
            this.SINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN);
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

                               " N'" + dataClass["MALOP"].ToString() + "', " +

                               " N'" + dataClass["TENLOP"].ToString() + "' " +

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

        private static string GetMaKhoa()
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

            fillDataTableClass();

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
                fillDataTableClass();

                processStoreStack.Clear();
                btnRecover.Enabled = false;
            }
        }

        private void gridViewLOP_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if ((flagMode == "EDITCLASS" || flagMode == "ADDCLASS") && bdsLOP.Position != positionSelectedClass)
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

            btnDelete.Enabled = btnEdit.Enabled = true;

            if (Program.mGroup == "PGV")
                cbKhoa.Enabled = true;
        }

        private void gridViewClass_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (bdsLOP.Position != positionSelectedClass
                || ((gridViewClass.FocusedColumn.FieldName == "MALOP" || gridViewClass.FocusedColumn.FieldName == "MAKHOA") && flagMode.Equals("EDITCLASS"))
                || (gridViewClass.FocusedColumn.FieldName == "MAKHOA" && flagMode.Equals("ADDCLASS")))
                e.Cancel = true;
        }

        private void gridViewClass_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (gridViewClass.FocusedColumn.FieldName == "MALOP")
            {
                e.Value = HandleString.RemoveAllSpaces(e.Value.ToString());

                bool match = Regex.IsMatch(e.Value.ToString().ToUpper(), "[D][0-9][0-9][A-Z][A-Z][A-Z][A-Z][0-9][0-9]");
                if (!match || e.Value.ToString().Length != 9)
                {
                    e.ErrorText = "Mã lớp bạn nhập không hợp lệ hoặc độ dài không đủ 9 kí tự\n Ví dụ: D20CQCN02";
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

            if (gridViewClass.FocusedColumn.FieldName == "KHOAHOC")
            {
                e.Value = HandleString.RemoveAllSpaces(e.Value.ToString());

                bool match = Regex.IsMatch(e.Value.ToString().ToUpper(), "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]");
                if (!match || e.Value.ToString().Length < 9)
                {
                    e.ErrorText = "Khóa học bạn nhập không hợp lệ \n Ví dụ: 2020-2025";
                    e.Valid = false;
                }
                else
                {
                    String [] years = e.Value.ToString().Split('-');
                    int startYear = int.Parse(years[0]);
                    int endYear = int.Parse(years[1]);

                    if(startYear > endYear)
                    {
                        e.ErrorText = "Khóa học bạn phải có năm bắt đầu nhỏ hơn năm kết thúc";
                        e.Valid = false;
                    }

                    e.Value = e.Value.ToString().ToUpper();
                }
            }

            if (gridViewClass.FocusedColumn.FieldName == "TENLOP")
            {
                e.Value = HandleString.RemoveExtraSpaces(e.Value.ToString());
                e.Value = HandleString.UpperFirstCharInString(e.Value.ToString().ToLower());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bdsLOP.AddNew();

            gridViewClass.SetFocusedRowCellValue("MAKHOA", GetMaKhoa());

            positionSelectedClass = bdsLOP.Count - 1;

            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnRecover.Enabled = cbKhoa.Enabled = false;
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
            btnAdd.Enabled = btnDelete.Enabled = btnEdit.Enabled = btnRecover.Enabled = cbKhoa.Enabled = false;
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

                    this.LOPTableAdapter.Connection.ConnectionString = Program.connectString;
                    this.LOPTableAdapter.Update(this.qLDSV_TCDataSet.LOP);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp: " + ex.Message, "", MessageBoxButtons.OK);
                    this.LOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);
                    bdsSINHVIEN.Position = bdsSINHVIEN.Find("MALOP", MALOP);
                    processStoreStack.Pop();
                    flagMode = "";
                    return;
                }

                btnAdd.Enabled = btnRecover.Enabled = true;
                btnDelete.Enabled = btnEdit.Enabled = false;
            }
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

        private void btnRecover_Click(object sender, EventArgs e)
        {
            if (processStoreStack.Count > 0)
            {
                Services.ProcessStore command = processStoreStack.Pop();
                String MALOP = command.primaryKey;
                Lop lop = new Lop();

                switch (command.flagMode)
                {
                    case "ADDCLASS":
                        int rowIndex = gridViewClass.LocateByValue("MALOP", MALOP);

                        try
                        {
                            gridViewClass.DeleteRow(rowIndex);
                            this.LOPTableAdapter.Update(this.qLDSV_TCDataSet.LOP);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi xóa lớp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.LOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);
                            return;
                        }
                        break;

                    case "DELETECLASS":
                        lop = (Lop)command.dataRow;

                        try
                        {
                            bdsLOP.AddNew();

                            gridViewClass.SetFocusedRowCellValue("MALOP", lop.MaLop);
                            gridViewClass.SetFocusedRowCellValue("TENLOP", lop.TenLop);
                            gridViewClass.SetFocusedRowCellValue("KHOAHOC", lop.KhoaHoc);
                            gridViewClass.SetFocusedRowCellValue("MAKHOA", lop.MaKhoa);

                            bdsLOP.EndEdit();
                            this.LOPTableAdapter.Update(this.qLDSV_TCDataSet.LOP);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khôi phục lớp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.LOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);
                            return;
                        }
                        break;

                    default:
                        lop = (Lop)command.dataRow;

                        positionSelectedClass = gridViewClass.LocateByValue("MALOP", lop.MaLop);
                        gridViewClass.FocusedRowHandle = positionSelectedClass;

                        try
                        {
                            gridViewClass.BeginUpdate();
                            gridViewClass.SetRowCellValue(positionSelectedClass, "TENLOP", lop.TenLop);
                            gridViewClass.SetRowCellValue(positionSelectedClass, "KHOAHOC", lop.KhoaHoc);
                            gridViewClass.EndUpdate();

                            DataRow row = ((DataRowView)bdsLOP[positionSelectedClass]).Row;
                            this.LOPTableAdapter.Update(row);

                            positionSelectedClass = -1;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khôi phục lớp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.LOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);
                            return;
                        }
                        break;
                }

                if (processStoreStack.Count == 0)
                    btnRecover.Enabled = false;
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            if (flagMode == "EDITCLASS" || flagMode == "ADDCLASS")
            {
                DialogResult dialog = MessageBox.Show("Bạn đang trong quá trình chỉnh sửa thông tin bạn thật sự muốn làm mới không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.No)
                {
                    return;
                }
                else
                {
                    flagMode = "";
                    positionSelectedClass = -1;
                }
            }

            fillDataTableClass();

            btnAdd.Enabled = cbKhoa.Enabled = true;
            btnWrite.Enabled = btnDelete.Enabled = btnEdit.Enabled = false;
        }

        private void btnExitSubForm_Click(object sender, EventArgs e)
        {
            if (flagMode != "EDITCLASS" && flagMode != "ADDCLASS")
            {
                this.Close();
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Bạn đang trong quá trình chỉnh sửa thông tin bạn thật sự muốn thoát không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void FrmQLLH_FormClosed(object sender, FormClosedEventArgs e)
        {
            cbKhoa.SelectedIndexChanged -= cbKhoa_SelectedIndexChanged;
        }
    }
}
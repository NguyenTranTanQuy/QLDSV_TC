using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask.Design;
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

namespace QLDSV_TC.Views
{
    public partial class FrmQLSV : DevExpress.XtraEditors.XtraForm
    {
        private Stack<Services.ProcessStore> processStoreStack = new Stack<Services.ProcessStore>();
        private String flagMode = "";
        private String classNumberSelected = "";
        private int positionSelectedSV = -1;
        private int positionSelectedClass = -1;

        private void pushDataToProcessStack(DataRow data)
        {
            SinhVien SV = new SinhVien(data["MASV"].ToString(),
                data["HO"].ToString(), data["TEN"].ToString(), (bool)data["PHAI"], data["DIACHI"].ToString(), data["NGAYSINH"].ToString(),
                data["MALOP"].ToString(), (bool)data["DANGHIHOC"], data["PASSWORD"].ToString());

            processStoreStack.Push(new Services.ProcessStore(flagMode, data["MASV"].ToString(), SV));
        }
        private void fillDataTableSinhVien()
        {
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connectString;
            this.SINHVIENTableAdapter.Fill(this.qldsV_TCDataSet.SINHVIEN);

            this.DANGKYTableAdapter.Connection.ConnectionString = Program.connectString;
            this.DANGKYTableAdapter.Fill(this.qldsV_TCDataSet.DANGKY);
        }

        private void getDataFromRowSelected()
        {
            DataRow row = gridViewStudents.GetDataRow(gridViewStudents.FocusedRowHandle);

            if (row != null)
            {
                txtMSSV.Text = row["MASV"].ToString();
                txtHo.Text = row["HO"].ToString();
                txtTen.Text = row["TEN"].ToString();
                txtNgaySinh.Text = row["NGAYSINH"].ToString();
                txtDiaChi.Text = row["DIACHI"].ToString();
                txtMaLop.Text = classNumberSelected;

                if (row["PHAI"].ToString() == "True")
                {
                    rdgGT.SelectedIndex = 1;
                }
                else
                {
                    rdgGT.SelectedIndex = 0;
                }

                if (row["DANGHIHOC"].ToString() == "True")
                {
                    chkStatus.Checked = true;
                }
            }
        }

        private void reloadDataForm()
        {
            txtMSSV.Text = "";
            txtHo.Text = "";
            txtTen.Text = "";
            txtNgaySinh.Text = "";
            txtDiaChi.Text = "";
            txtMaLop.Text = "";
            
            rdgGT.SelectedIndex = 0;
            
            chkStatus.Checked = false;
        }

        private void defaultValueInputSV()
        {
            qldsV_TCDataSet.SINHVIEN.DANGHIHOCColumn.DefaultValue = false;
            qldsV_TCDataSet.SINHVIEN.PHAIColumn.DefaultValue = false;
            qldsV_TCDataSet.SINHVIEN.PASSWORDColumn.DefaultValue = Program.defaultPasswordSV;
            qldsV_TCDataSet.SINHVIEN.MALOPColumn.DefaultValue = classNumberSelected;

            DevExpress.XtraEditors.Repository.RepositoryItemDateEdit dateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            dateEdit.MaxValue = DateTime.Now.AddYears(-18);
            colNGAYSINH.ColumnEdit = dateEdit;
        }

        private bool checkDataSV()
        {
            DataRowView dataSV = (DataRowView)bdsSINHVIEN[positionSelectedSV];
            if (dataSV["MASV"].ToString().Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được để trống", "", MessageBoxButtons.OK);
                return false;
            }
            if (dataSV["HO"].ToString().Trim() == "")
            {
                MessageBox.Show("Họ không được thiếu!", "", MessageBoxButtons.OK);

                return false;
            }
            if (dataSV["TEN"].ToString().Trim() == "")
            {
                MessageBox.Show("Tên không được thiếu!", "", MessageBoxButtons.OK);
                return false;
            }

            if (dataSV["PHAI"].ToString() == "")
            {
                MessageBox.Show("Vui Lòng Chọn Phái!", "", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        public FrmQLSV()
        {
            InitializeComponent();
        }

        private void FrmQLSV_Load(object sender, EventArgs e)
        {
            this.qldsV_TCDataSet.EnforceConstraints = false;

            this.LOPTableAdapter.Connection.ConnectionString = Program.connectString;
            this.LOPTableAdapter.Fill(this.qldsV_TCDataSet.LOP);

            Program.bdsDSPM.Filter = "TENKHOA not LIKE 'Phòng kế toán%'  ";
            cbKhoa.DataSource = Program.bdsDSPM;
            cbKhoa.DisplayMember = "TENKHOA";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedValue = Program.servername;
            
            if (Program.mGroup == "PGV") cbKhoa.Enabled = true;
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
                this.LOPTableAdapter.Connection.ConnectionString = Program.connectString;
                this.LOPTableAdapter.Fill(this.qldsV_TCDataSet.LOP);
            }
        }

        private void gridViewClass_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (flagMode == "EDITSTUDENT" || flagMode == "ADDSTUDENT")
            {
                DialogResult dialog = MessageBox.Show("Bạn đang trong quá trình chỉnh sửa thông tin bạn thật sự muốn làm mới không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.No)
                {
                    gridViewClass.FocusedRowHandle = positionSelectedClass;
                    gridViewStudents.FocusedRowHandle = positionSelectedSV;
                    return;
                }
                else
                {
                    flagMode = "";
                    positionSelectedSV = -1;
                    positionSelectedClass = -1;
                }
            }

            fillDataTableSinhVien();

            classNumberSelected = gridViewClass.GetDataRow(gridViewClass.FocusedRowHandle)["MALOP"].ToString();

            btnAddSV.Enabled = cbKhoa.Enabled = true;
            btnDeleteSV.Enabled = btnEditSV.Enabled = btnWriteSV.Enabled = false;
        }

        private void gridViewClass_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            reloadDataForm();
        }

        private void gridViewStudents_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if ((flagMode == "EDITSTUDENT" || flagMode == "ADDSTUDENT") && bdsSINHVIEN.Position != positionSelectedSV)
            {
                DialogResult dialog = MessageBox.Show("Bạn đang trong quá trình chỉnh sửa thông tin bạn thật sự muốn làm mới không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.No)
                {
                    gridViewStudents.FocusedRowHandle = positionSelectedSV;
                    return;
                }
                else
                {
                    fillDataTableSinhVien();

                    flagMode = "";
                    positionSelectedSV = -1;
                }
            }

            if (bdsSINHVIEN.Position != positionSelectedSV)
            {
                getDataFromRowSelected();

                btnAddSV.Enabled = false;
                btnDeleteSV.Enabled = btnEditSV.Enabled = cbKhoa.Enabled = true;
            }
        }

        private void gridViewStudents_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (bdsSINHVIEN.Position != positionSelectedSV
                || (gridViewStudents.FocusedColumn.FieldName == "MASV" && flagMode.Equals("EDITSTUDENT"))
                || (gridViewStudents.FocusedColumn.FieldName == "DANGHIHOC" && flagMode.Equals("ADDSTUDENT")))
                e.Cancel = true;
        }

        private void gridViewStudents_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (gridViewStudents.FocusedColumn.FieldName == "MASV")
            {
                bool match = Regex.IsMatch(e.Value.ToString().ToUpper(), "[NB][0-9][0-9][A-Z][A-Z][A-Z][A-Z][0-9][0-9][0-9]");
                if (!match || e.Value.ToString().Trim().Length != 10)
                {
                    e.ErrorText = "Mã sinh viên bạn nhập không đúng định dạng \n Ví dụ: N20DCCN001";
                    e.Valid = false;
                }
                else
                {
                    e.Value = e.Value.ToString().ToUpper();
                }
            }

            if (gridViewStudents.FocusedColumn.FieldName == "MASV" || gridViewStudents.FocusedColumn.FieldName == "HO" || gridViewStudents.FocusedColumn.FieldName == "TEN")
            {
                if (e.Value.ToString().Trim().Length == 0)
                {
                    e.ErrorText = "Không được để trống ô này";
                    e.Valid = false;
                }
            }
        }

        private void btnAddSV_Click(object sender, EventArgs e)
        {
            defaultValueInputSV();

            bdsSINHVIEN.AddNew();
            positionSelectedSV = bdsSINHVIEN.Count - 1;
            positionSelectedClass = gridViewClass.FocusedRowHandle;

            btnAddSV.Enabled = cbKhoa.Enabled = false;
            btnWriteSV.Enabled = true;

            flagMode = "ADDSTUDENT";
        }

        private void btnDeleteSV_Click(object sender, EventArgs e)
        {
            string MASV = "";

            if (bdsDANGKY.Count > 0)
            {
                MessageBox.Show("Không thể xóa sinh viên này vì sinh viên đã đăng kí lớp tín chỉ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Bạn có thật sự muốn xóa sinh viên khỏi lớp học này ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                try
                {
                    DataRow data = gridViewStudents.GetFocusedDataRow();
                    MASV = data["MASV"].ToString();

                    flagMode = "DELETESTUDENT";
                    pushDataToProcessStack(data);

                    data.Delete();

                    this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connectString;
                    this.SINHVIENTableAdapter.Update(this.qldsV_TCDataSet.SINHVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên: " + ex.Message, "", MessageBoxButtons.OK);
                    this.SINHVIENTableAdapter.Fill(this.qldsV_TCDataSet.SINHVIEN);
                    bdsSINHVIEN.Position = bdsSINHVIEN.Find("MASV", MASV);
                    processStoreStack.Pop();
                    flagMode = "";
                    return;
                }
            }

            btnAddSV.Enabled = btnRecover.Enabled = true;
            btnDeleteSV.Enabled = btnEditSV.Enabled = false;
        }

        private void btnEditSV_Click(object sender, EventArgs e)
        {
            positionSelectedSV = bdsSINHVIEN.Position;
            positionSelectedClass = gridViewClass.FocusedRowHandle;

            DataRow data = gridViewStudents.GetFocusedDataRow();

            flagMode = "EDITSTUDENT";
            pushDataToProcessStack(data);

            btnWriteSV.Enabled = true;
            btnDeleteSV.Enabled = btnEditSV.Enabled = cbKhoa.Enabled = false;
        }

        private void btnWriteSV_Click(object sender, EventArgs e)
        {
            if (checkDataSV())
            {
                try
                {
                    bdsSINHVIEN.EndEdit();
                    bdsSINHVIEN.ResetCurrentItem();

                    this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connectString;

                    DataRow row = ((DataRowView)bdsSINHVIEN[bdsSINHVIEN.Position]).Row;
                    this.SINHVIENTableAdapter.Update(row);
                    if(flagMode == "ADDSTUDENT")
                        processStoreStack.Push(new Services.ProcessStore(flagMode, row["MASV"].ToString()));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                flagMode = "";
                positionSelectedSV = -1;

                btnAddSV.Enabled = btnRecover.Enabled = cbKhoa.Enabled = true;
                btnWriteSV.Enabled = false;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (flagMode == "EDITSTUDENT" || flagMode == "ADDSTUDENT")
            {
                DialogResult dialog = MessageBox.Show("Bạn đang trong quá trình chỉnh sửa thông tin bạn thật sự muốn làm mới không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.No)
                {
                    return;
                }
                else
                {
                    fillDataTableSinhVien();

                    flagMode = "";
                    positionSelectedSV = -1;
                }
            }

            reloadDataForm();

            btnAddSV.Enabled = true;
            btnWriteSV.Enabled = btnDeleteSV.Enabled = btnEditSV.Enabled = false;
        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            if (processStoreStack.Count > 0)
            {
                Services.ProcessStore command = processStoreStack.Pop();
                String MASV = command.primaryKey;
                if (command.flagMode == "ADDSTUDENT")
                {
                    int rowIndex = gridViewStudents.LocateByValue("MASV", MASV);
                    try
                    {
                        
                        gridViewStudents.DeleteRow(rowIndex);
                        this.SINHVIENTableAdapter.Update(this.qldsV_TCDataSet.SINHVIEN);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.SINHVIENTableAdapter.Fill(this.qldsV_TCDataSet.SINHVIEN);
                        return;
                    }
                }
                else if(command.flagMode == "DELETESTUDENT")
                {
                    try
                    {
                        SinhVien SV = (SinhVien)command.dataRow;
                        bdsSINHVIEN.AddNew();
                        
                        gridViewStudents.SetFocusedRowCellValue("MASV", SV.MaSV);
                        gridViewStudents.SetFocusedRowCellValue("HO", SV.Ho);
                        gridViewStudents.SetFocusedRowCellValue("TEN", SV.Ten);
                        gridViewStudents.SetFocusedRowCellValue("PHAI", SV.Phai);
                        gridViewStudents.SetFocusedRowCellValue("NGAYSINH", SV.NgaySinh);
                        gridViewStudents.SetFocusedRowCellValue("DIACHI", SV.DiaChi);
                        gridViewStudents.SetFocusedRowCellValue("MALOP", SV.MaLop);
                        gridViewStudents.SetFocusedRowCellValue("DANGHIHOC", SV.DangNghiHoc);
                        gridViewStudents.SetFocusedRowCellValue("PASSWORD", SV.PassWord);
                        
                        bdsSINHVIEN.EndEdit();
                        this.SINHVIENTableAdapter.Update(this.qldsV_TCDataSet.SINHVIEN);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khôi phục sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.SINHVIENTableAdapter.Fill(this.qldsV_TCDataSet.SINHVIEN);
                        return;
                    }
                }
                else
                {
                    positionSelectedSV = gridViewStudents.LocateByValue("MASV", MASV);
                    SinhVien SV = (SinhVien)command.dataRow;
                    try
                    {
                        gridViewStudents.BeginUpdate();
                        gridViewStudents.SetRowCellValue(positionSelectedSV,"HO", SV.Ho);
                        gridViewStudents.SetRowCellValue(positionSelectedSV, "TEN", SV.Ten);
                        gridViewStudents.SetRowCellValue(positionSelectedSV, "PHAI", SV.Phai);
                        gridViewStudents.SetRowCellValue(positionSelectedSV, "NGAYSINH", SV.NgaySinh);
                        gridViewStudents.SetRowCellValue(positionSelectedSV, "DIACHI", SV.DiaChi);
                        gridViewStudents.SetRowCellValue(positionSelectedSV, "MALOP", SV.MaLop);
                        gridViewStudents.SetRowCellValue(positionSelectedSV, "DANGHIHOC", SV.DangNghiHoc);
                        gridViewStudents.SetRowCellValue(positionSelectedSV, "PASSWORD", SV.PassWord);
                        gridViewStudents.EndUpdate();

                        DataRow row = ((DataRowView)bdsSINHVIEN[positionSelectedSV]).Row;
                        this.SINHVIENTableAdapter.Update(row);
                        positionSelectedSV = -1;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khôi phục sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.SINHVIENTableAdapter.Fill(this.qldsV_TCDataSet.SINHVIEN);
                        return;
                    }
                }

                if(processStoreStack.Count == 0)
                {
                    btnRecover.Enabled = false;
                }
            }
        }

        private void btnExitSubForm_Click(object sender, EventArgs e)
        {
            if (flagMode != "EDITSTUDENT" && flagMode != "ADDSTUDENT")
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

        private void FrmQLSV_FormClosed(object sender, FormClosedEventArgs e)
        {
            cbKhoa.SelectedIndexChanged -= cbKhoa_SelectedIndexChanged;
        }
    }
}
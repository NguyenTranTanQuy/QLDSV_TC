using DevExpress.XtraEditors;
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
        private Stack<Program.processStore> processStoreStack = new Stack<Program.processStore>();
        private String flagMode = "";
        private String classNumberSelected = "";
        private int positionSelectedSV = -1;
        

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

        private void gridViewStudents_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (flagMode == "EDITSTUDENT")
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

                    positionSelectedSV = -1;
                    flagMode = "";
                }
            }

            

            getDataFromRowSelected();

            btnAddSV.Enabled = false;
            btnDeleteSV.Enabled = btnEditSV.Enabled = true;
        }

        private void gridViewClass_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (flagMode == "EDITSTUDENT")
            {
                DialogResult dialog = MessageBox.Show("Bạn đang trong quá trình chỉnh sửa thông tin bạn thật sự muốn làm mới không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.No)
                {
                    return;
                }
            }

            fillDataTableSinhVien();

            classNumberSelected = gridViewClass.GetDataRow(gridViewClass.FocusedRowHandle)["MALOP"].ToString();

            btnAddSV.Enabled = true;
            btnDeleteSV.Enabled = btnEditSV.Enabled = btnWriteSV.Enabled = false;
        }

        private void gridViewClass_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            reloadDataForm();
        }

        private void btnAddSV_Click(object sender, EventArgs e)
        {
            defaultValueInputSV();

            bdsSINHVIEN.AddNew();
            positionSelectedSV = bdsSINHVIEN.Count - 1;

            btnAddSV.Enabled = gridControlClass.Enabled = cbKhoa.Enabled = false;
            btnRecover.Enabled = btnWriteSV.Enabled = true;

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
                    MASV = ((DataRowView)bdsSINHVIEN[bdsSINHVIEN.Position])["MASV"].ToString();
                    bdsSINHVIEN.RemoveCurrent();
                    this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connectString;
                    this.SINHVIENTableAdapter.Update(this.qldsV_TCDataSet.SINHVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên: " + ex.Message, "", MessageBoxButtons.OK);
                    this.SINHVIENTableAdapter.Fill(this.qldsV_TCDataSet.SINHVIEN);
                //    bdsSINHVIEN.Position = bdsSINHVIEN.Find("MASV", MASV);
                    return;
                }
            }

            btnAddSV.Enabled = true;
            btnDeleteSV.Enabled = btnEditSV.Enabled = false;

            flagMode = "DELETESTUDENT";
            processStoreStack.Push(new Program.processStore(flagMode, MASV));
            btnRecover.Enabled = true;
        }

        private void btnEditSV_Click(object sender, EventArgs e)
        {
            positionSelectedSV = bdsSINHVIEN.Position;

            btnWriteSV.Enabled = true;
            btnDeleteSV.Enabled = btnEditSV.Enabled = false;

            txtMSSV.Enabled = false;

            flagMode = "EDITSTUDENT";
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

                    processStoreStack.Push(new Program.processStore(flagMode, row["MASV"].ToString()));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                flagMode = "";
                positionSelectedSV = -1;

                btnAddSV.Enabled = btnRecover.Enabled = gridControlClass.Enabled = cbKhoa.Enabled = true;
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
                }
            }

            reloadDataForm();

            btnAddSV.Enabled = true;
            btnWriteSV.Enabled = btnDeleteSV.Enabled = btnEditSV.Enabled = false;

            txtMSSV.Enabled = true;

            flagMode = "RELOADSTUDENT";
        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            if (processStoreStack.Count > 0)
            {
                Program.processStore command = processStoreStack.Pop();
                String MASV = command.primaryKey;
                int rowIndex = gridViewStudents.LocateByValue("MASV", MASV);
                if (command.flagMode == "ADDSTUDENT")
                {
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

        private void gridViewStudents_ShowingEditor(object sender, CancelEventArgs e)
        {
            if (bdsSINHVIEN.Position != positionSelectedSV
                ||flagMode.Equals("ADDSV") ||flagMode.Equals("EDITSV"))
                //if(flagMode.Equals("EDITSV"))
                //{
                //    gridViewStudents.Columns["MASV"].OptionsColumn.ReadOnly = true;
                //}
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

            if(gridViewStudents.FocusedColumn.FieldName == "MASV" || gridViewStudents.FocusedColumn.FieldName == "HO" || gridViewStudents.FocusedColumn.FieldName == "TEN")
            {
                if (e.Value.ToString().Trim().Length == 0)
                {
                    e.ErrorText = "Không được để trống ô này";
                    e.Valid = false;
                }
            }
        }

        private void FrmQLSV_FormClosed(object sender, FormClosedEventArgs e)
        {
            cbKhoa.SelectedIndexChanged -= cbKhoa_SelectedIndexChanged;
        }
    }
}
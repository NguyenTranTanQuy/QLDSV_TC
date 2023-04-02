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
        private String flagMode = "";
        private String classNumberSelected = "";
        private int positionSelectedSV = -1;

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

        private bool checkDataSV()
        {
            if (txtMSSV.ToString().Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được để trống", "", MessageBoxButtons.OK);
                return false;
            }
            
            if (txtHo.ToString().Trim() == "")
            {
                MessageBox.Show("Họ không được thiếu!", "", MessageBoxButtons.OK);

                return false;
            }
            
            if (txtTen.ToString().Trim() == "")
            {
                MessageBox.Show("Tên không được thiếu!", "", MessageBoxButtons.OK);
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

            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connectString;
            this.SINHVIENTableAdapter.Fill(this.qldsV_TCDataSet.SINHVIEN);

            this.DANGKYTableAdapter.Connection.ConnectionString = Program.connectString;
            this.DANGKYTableAdapter.Fill(this.qldsV_TCDataSet.DANGKY);

            if(bdsLOP.Count > 0)
            {
                gridViewClass.SelectRow(0);
            }

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

                this.SINHVIENTableAdapter.Connection.ConnectionString = Program.connectString;
                this.SINHVIENTableAdapter.Fill(this.qldsV_TCDataSet.SINHVIEN);

                this.DANGKYTableAdapter.Connection.ConnectionString = Program.connectString;
                this.DANGKYTableAdapter.Fill(this.qldsV_TCDataSet.DANGKY);

                if (bdsLOP.Count > 0)
                {
                    gridViewClass.SelectRow(0);
                }
            }
        }

        private void gridViewStudents_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            getDataFromRowSelected();

            btnAddSV.Enabled = false;
            btnDeleteSV.Enabled = btnEditSV.Enabled = true;
        }

        private void gridViewClass_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            classNumberSelected = gridViewClass.GetDataRow(gridViewClass.FocusedRowHandle)["MALOP"].ToString();
        }

        private void gridViewClass_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            reloadDataForm();
            btnRefresh_Click(sender, e);
        }

        private void btnAddSV_Click(object sender, EventArgs e)
        {
            bdsSINHVIEN.AddNew();
            positionSelectedSV = bdsSINHVIEN.Count - 1;

            btnAddSV.Enabled = false;
            btnRecover.Enabled = btnWriteSV.Enabled = true;

            // Chọn nhanh lớp cần thêm sinh viên
            //cbLop.SelectedItem = gridViewClass.GetDataRow(gridViewClass.FocusedRowHandle)["MALOP"].ToString();

            // Kiểm duyệt ngày sinh
            //DateTime enough18YearsOld = DateTime.Now.AddYears(-18);
            //txtNgaySinh.Properties.MaxValue = enough18YearsOld;

            flagMode = "ADDSTUDENT";
        }

        private void btnDeleteSV_Click(object sender, EventArgs e)
        {
            btnDeleteSV.Enabled = btnEditSV.Enabled = false;

            flagMode = "DELETESTUDENT";
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
                    DataRow row = qldsV_TCDataSet.SINHVIEN.NewRow();
                    row["MASV"] = txtMSSV.Text;
                    row["HO"] = txtHo.Text;
                    row["TEN"] = txtTen.Text;
                    if (rdgGT.SelectedIndex == 0)
                    {
                        row["PHAI"] = false;
                    }
                    else
                    {
                        row["PHAI"] = true;
                    }

                    row["DIACHI"] = txtDiaChi.Text;

                    DateTime date = DateTime.ParseExact(txtNgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    string formattedDate = date.ToString("yyyy-MM-dd");
                    row["NGAYSINH"] = formattedDate;

                    row["MALOP"] = classNumberSelected;
                    row["DANGHIHOC"] = chkStatus.Checked;
                    row["PASSWORD"] = Program.defaultPasswordSV;

                    qldsV_TCDataSet.SINHVIEN.Rows.Add(row);
                    SINHVIENTableAdapter.Update(qldsV_TCDataSet.SINHVIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            flagMode = "WRITESTUDENT";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (flagMode == "EDITSTUDENT")
            {
                DialogResult dialog = MessageBox.Show("Bạn đang trong quá trình chỉnh sửa thông tin bạn thật sự muốn làm mới không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.No)
                {
                    return;
                }
            }

            reloadDataForm();

            btnAddSV.Enabled = true;
            btnWriteSV.Enabled = false;
            btnDeleteSV.Enabled = btnEditSV.Enabled = false;

            txtMSSV.Enabled = true;

            flagMode = "RELOADSTUDENT";
        }

        private void btnRecover_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExitSubForm_Click(object sender, EventArgs e)
        {
            if (flagMode != "EDITSTUDENT")
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
            if (bdsSINHVIEN.Position != positionSelectedSV || gridViewClass.FocusedColumn.FieldName == "MALOP"
                || (gridViewClass.FocusedColumn.FieldName == "DANGHIHOC" && flagMode.Equals("ADDSV"))
                || (gridViewClass.FocusedColumn.FieldName == "MASV" && flagMode.Equals("EDITSV"))
                )
                e.Cancel = true;
        }

        private void FrmQLSV_FormClosed(object sender, FormClosedEventArgs e)
        {
            cbKhoa.SelectedIndexChanged -= cbKhoa_SelectedIndexChanged;
        }

        private void gridViewStudents_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (gridViewStudents.FocusedColumn.FieldName == "MASV")
            {
                bool match = Regex.IsMatch(e.Value.ToString().ToUpper(), "[NB][0-9][0-9][A-Z][A-Z][A-Z][A-Z][0-9][0-9][0-9]");
                if (!match || e.Value.ToString().Length != 10)
                {
                    e.ErrorText = "Mã sinh viên bạn nhập không đúng định dạng \n Ví dụ: N20DCCN001";
                    e.Valid = false;
                }
                else
                {
                    e.Value = e.Value.ToString().ToUpper();
                }
            }
        }
    }
}
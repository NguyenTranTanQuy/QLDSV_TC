using DevExpress.XtraBars.Ribbon;
using QLDSV_TC.Views;
using System;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class FrmMain : RibbonForm
    {
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }

        private void PhanQuyen()
        {
            String role = Program.mGroup;
            if(role == "PGV" || role == "KHOA")
            {
                btnQLSV.Enabled = btnQLLH.Enabled = btnQLMH.Enabled = 
                QLLTC.Enabled = btnQLDIEM.Enabled = btnDK.Enabled = true;
            } else if (role == "PKT")
            {
                btnQLHP.Enabled = btnDK.Enabled = true;
            } else
            {
                btnQLDKLOP.Enabled = true;
            }
        }

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            PhanQuyen();
        }

        private void btnQLSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(Views.FrmQLSV));
            if (form != null) form.Activate();
            else
            {
                Program.frmQLSV = new FrmQLSV();
                Program.frmQLSV.MdiParent = this;
                Program.frmQLSV.Show();
            }
        }

        private void btnQLLH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(Views.FrmQLLH));
            if (form != null) form.Activate();
            else
            {
                Program.frmQLLH = new FrmQLLH();
                Program.frmQLLH.MdiParent = this;
                Program.frmQLLH.Show();
            }
        }

        private void btnQLMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(Views.FrmQLMH));
            if (form != null) form.Activate();
            else
            {
                Program.frmQLMH = new FrmQLMH();
                Program.frmQLMH.MdiParent = this;
                Program.frmQLMH.Show();
            }
        }

        private void QLLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(Views.FrmQLLTC));
            if (form != null) form.Activate();
            else
            {
                Program.frmQLLTC = new FrmQLLTC();
                Program.frmQLLTC.MdiParent = this;
                Program.frmQLLTC.Show();
            }
        }

        private void btnQLDIEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(Views.FrmQLCD));
            if (form != null) form.Activate();
            else
            {
                Program.frmQLCD = new FrmQLCD();
                Program.frmQLCD.MdiParent = this;
                Program.frmQLCD.Show();
            }
        }

        private void btnQLDKLOP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(Views.FrmSVDK));
            if (form != null) form.Activate();
            else
            {
                Program.frmSVDK = new FrmSVDK();
                Program.frmSVDK.MdiParent = this;
                Program.frmSVDK.Show();
            }
        }

        private void btnQLHP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(Views.FrmQLHP));
            if (form != null) form.Activate();
            else
            {
                Program.frmQLHP = new FrmQLHP();
                Program.frmQLHP.MdiParent = this;
                Program.frmQLHP.Show();
            }
        }

        private void btnDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(Views.FrmTTK));
            if (form != null) form.Activate();
            else
            {
                Program.frmTTK = new FrmTTK();
                Program.frmTTK.MdiParent = this;
                Program.frmTTK.Show();
            }
        }

        private void btnINDSLTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = CheckExists(typeof(Views.RpfStudentsListCreditClass));
            if (form != null) form.Activate();
            else
            {
                Program.rpfStudentsListCreditClass = new RpfStudentsListCreditClass();
                Program.rpfStudentsListCreditClass.MdiParent = this;
                Program.rpfStudentsListCreditClass.Show();
            }
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            DialogResult dialog = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                foreach (Form frm in this.MdiChildren)
                {
                    frm.Close();
                }

                Program.frmMain.Dispose();
                Program.frmLogin.Visible = true;
                Program.bdsDSPM.RemoveFilter();
                Program.frmLogin.loadData();

                e.Cancel = false;
            }
        }
    }
}

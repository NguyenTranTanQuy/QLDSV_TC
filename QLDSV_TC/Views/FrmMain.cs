using DevExpress.Utils;
using DevExpress.XtraEditors;
using QLDSV_TC.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
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

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                foreach (Form frm in this.MdiChildren) {
                    frm.Close();
                }

                Program.frmMain.Dispose();
                Program.frmLogin.Visible = true;
                Program.bdsDSPM.RemoveFilter();
                Program.frmLogin.loadData();
            }
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
    }
}

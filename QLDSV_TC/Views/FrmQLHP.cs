using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC.Views
{
    public partial class FrmQLHP : DevExpress.XtraEditors.XtraForm
    {
        public FrmQLHP()
        {
            InitializeComponent();
        }

        private void FrmQLHP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN);
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);

        }
    }
}
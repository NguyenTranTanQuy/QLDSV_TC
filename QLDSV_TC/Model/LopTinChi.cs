using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSV_TC
{
    [Table("LOPTINCHI")]
    class LopTinChi
    {

        public int MaLTC { set; get; }

        public string NienKhoa { set; get; }

        public int HocKy { set; get; }

        public string MaMH { set; get; }

        public int Nhom { set; get; }

        public string MaGV { set; get; }

        public string MaKhoa { set; get; }

        public int SoSVToiThieu { set; get; }

        public bool HuyLop { set; get; }

        public LopTinChi() {}

        public LopTinChi(int maLTC, string nienKhoa, int hocKy, string maMH, int nhom, string maGV, string maKhoa, int soSVToiThieu, bool huyLop)
        {
            MaLTC = maLTC;
            NienKhoa = nienKhoa;
            HocKy = hocKy;
            MaMH = maMH;
            Nhom = nhom;
            MaGV = maGV;
            MaKhoa = maKhoa;
            SoSVToiThieu = soSVToiThieu;
            HuyLop = huyLop;
        }
    }
}

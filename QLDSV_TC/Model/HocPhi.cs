using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSV_TC
{
    class HocPhi
    {
        public string MaSV { set; get; }

        public string NienKhoa { set; get; }

        public int HocKy { set; get; }

        public int hocPhi { set; get; }

        public HocPhi() {}

        public HocPhi(string maSV, string nienKhoa, int hocKy, int hocphi)
        {
            MaSV = maSV;
            NienKhoa = nienKhoa;
            HocKy = hocKy;
            hocPhi = hocphi;
        }
    }
}

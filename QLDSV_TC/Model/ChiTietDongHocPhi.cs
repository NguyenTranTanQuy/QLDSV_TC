using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSV_TC
{
    class ChiTietDongHocPhi
    {
        public string MaSV { set; get; }

        public string NienKhoa { set; get; }

        public int HocKy { set; get; }

        public String NgayDong { set; get; }

        public int SoTienDong { set; get; }

        public ChiTietDongHocPhi() {}

        public ChiTietDongHocPhi(string maSV, string nienKhoa, int hocKy, String ngayDong, int soTienDong)
        {
            MaSV = maSV;
            NienKhoa = nienKhoa;
            HocKy = hocKy;
            NgayDong = ngayDong;
            SoTienDong = soTienDong;
        }
    }
}

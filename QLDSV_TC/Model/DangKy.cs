using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSV_TC
{
    class DangKy
    {
        public int MaLTC { set; get; }

        public string MaSV { set; get; }

        public int DiemChuyenCan { set; get; }

        public float DiemGiuaKy { set; get; }

        public float DiemCuoiKy { set; get; }

        public bool HuyDangKy { set; get; }

        public DangKy() {}

        public DangKy(int maLTC, string maSV, int diemChuyenCan, float diemGiuaKy, float diemCuoiKy, bool huyDangKy)
        {
            MaLTC = maLTC;
            MaSV = maSV;
            DiemChuyenCan = diemChuyenCan;
            DiemGiuaKy = diemGiuaKy;
            DiemCuoiKy = diemCuoiKy;
            HuyDangKy = huyDangKy;
        }
    }
}

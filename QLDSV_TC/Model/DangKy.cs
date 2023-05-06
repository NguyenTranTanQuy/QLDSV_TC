﻿
namespace QLDSV_TC
{
    public class DangKy
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
            this.MaLTC = maLTC;
            this.MaSV = maSV;
            this.DiemChuyenCan = diemChuyenCan;
            this.DiemGiuaKy = diemGiuaKy;
            this.DiemCuoiKy = diemCuoiKy;
            this.HuyDangKy = huyDangKy;
        }
    }
}


namespace QLDSV_TC
{
    public class ChiTietDongHocPhi
    {
        public string MaSV { set; get; }

        public string NienKhoa { set; get; }

        public int HocKy { set; get; }

        public string NgayDong { set; get; }

        public int SoTienDong { set; get; }

        public ChiTietDongHocPhi() {}

        public ChiTietDongHocPhi(string maSV, string nienKhoa, int hocKy, string ngayDong, int soTienDong)
        {
            this.MaSV = maSV;
            this.NienKhoa = nienKhoa;
            this.HocKy = hocKy;
            this.NgayDong = ngayDong;
            this.SoTienDong = soTienDong;
        }
    }
}

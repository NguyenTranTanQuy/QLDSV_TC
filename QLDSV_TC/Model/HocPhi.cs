
namespace QLDSV_TC
{
    public class HocPhi
    {
        public string MaSV { set; get; }

        public string NienKhoa { set; get; }

        public int HocKy { set; get; }

        public int hocPhi { set; get; }

        public HocPhi() {}

        public HocPhi(string maSV, string nienKhoa, int hocKy, int hocphi)
        {
            this.MaSV = maSV;
            this.NienKhoa = nienKhoa;
            this.HocKy = hocKy;
            this.hocPhi = hocphi;
        }
    }
}

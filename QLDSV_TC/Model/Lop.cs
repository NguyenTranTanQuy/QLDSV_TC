
namespace QLDSV_TC
{
    public class Lop
    {
        public string MaLop { set; get; }

        public string TenLop { set; get; }

        public string KhoaHoc {set; get; }

        public string MaKhoa { set; get; }

        public Lop() {}

        public Lop(string maLop, string tenLop, string khoaHoc, string maKhoa)
        {
            this.MaLop = maLop;
            this.TenLop = tenLop;
            this.KhoaHoc = khoaHoc;
            this.MaKhoa = maKhoa;
        }
    }
}

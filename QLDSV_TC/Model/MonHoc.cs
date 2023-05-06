
namespace QLDSV_TC
{
    public class MonHoc
    {
        public string MaMH { set; get; }
       
        public string TenMH { set; get; }

        public int SoTietLyThuyet { set; get; }

        public int SoTietThucHanh { set; get; }

        public MonHoc() {}

        public MonHoc(string maMH, string tenMH, int soTietLyThuyet, int soTietThucHanh)
        {
            this.MaMH = maMH;
            this.TenMH = tenMH;
            this.SoTietLyThuyet = soTietLyThuyet;
            this.SoTietThucHanh = soTietThucHanh;
        }
    }
}

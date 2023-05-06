
namespace QLDSV_TC
{
    public class Khoa
    {
        public string MaKhoa { set; get; }
      
        public string TenKhoa { set; get; }

        public Khoa() {}

        public Khoa(string maKhoa, string tenKhoa)
        {
            this.MaKhoa = maKhoa;
            this.TenKhoa = tenKhoa;
        }
    }
}

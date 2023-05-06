
namespace QLDSV_TC
{
    public class GiangVien
    {
        public string MaGV { set; get; }
       
        public string Ho { set; get; }

        public string Ten { set; get; }

        public string HocVi { set; get; }

        public string HocHam { set; get; }

        public string ChuyenMon;

        public string MaKhoa { set; get; }

        public GiangVien() {}

        public GiangVien(string maGV, string ho, string ten, string hocVi, string hocHam, string chuyenMon, string maKhoa)
        {
            this.MaGV = maGV;
            this.Ho = ho;
            this.Ten = ten;
            this.HocVi = hocVi;
            this.HocHam = hocHam;
            this.ChuyenMon = chuyenMon;
            this.MaKhoa = maKhoa;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSV_TC
{
    class GiangVien
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
            MaGV = maGV;
            Ho = ho;
            Ten = ten;
            HocVi = hocVi;
            HocHam = hocHam;
            ChuyenMon = chuyenMon;
            MaKhoa = maKhoa;
        }
    }
}

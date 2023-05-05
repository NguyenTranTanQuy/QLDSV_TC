using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSV_TC
{
    class MonHoc
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

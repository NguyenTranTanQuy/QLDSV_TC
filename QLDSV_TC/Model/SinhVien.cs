using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSV_TC
{
   
    class SinhVien
    {
        public string MaSV { set; get; }
        
        public string Ho { set; get; }

        public string Ten { set; get; }

        public bool Phai { set; get; }

        public string DiaChi { set; get; }

        public String NgaySinh { set; get; }

        public string MaLop { set; get; }

        public bool DangNghiHoc { set; get; }

        public string PassWord { set; get; }

        public SinhVien() {}

        public SinhVien(string maSV, string ho, string ten, bool phai, string diaChi, String ngaySinh, string maLop, bool dangNghiHoc, string passWord)
        {
            this.MaSV = maSV;
            this.Ho = ho;
            this.Ten = ten;
            this.Phai = phai;
            this.DiaChi = diaChi;
            this.NgaySinh = ngaySinh;
            this.MaLop = maLop;
            this.DangNghiHoc = dangNghiHoc;
            this.PassWord = passWord;
        }
    }
}

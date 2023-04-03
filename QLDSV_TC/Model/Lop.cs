﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSV_TC
{
    class Lop
    {
        public string MaLop { set; get; }

        public string TenLop { set; get; }

        public string KhoaHoc;

        public string MaKhoa { set; get; }

        public Lop() {}

        public Lop(string maLop, string tenLop, string khoaHoc, string maKhoa)
        {
            MaLop = maLop;
            TenLop = tenLop;
            KhoaHoc = khoaHoc;
            MaKhoa = maKhoa;
        }
    }
}

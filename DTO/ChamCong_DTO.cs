﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChamCong_DTO_View
    {
        public string MaNV { set; get; }
        public string HoTen { set; get; }

    }
    public class ChamCong_DTO
    {
        public DateTime Ngay { get; set; }
        public string TinhTrang { set; get; }
        public string MaNV { set; get; }

    }
}

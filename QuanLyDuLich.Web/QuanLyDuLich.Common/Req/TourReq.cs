using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyDuLich.Common.Req
{
    public class TourReq
    {
        public int Id { get; set; }
        public string TenTour { get; set; }
        public decimal? DonGia { get; set; }
        public string LoaiTour { get; set; }
        public DateTime? NgayKhoiHanh { get; set; }
        public DateTime? NgayKetThuc { get; set; }
    }
}

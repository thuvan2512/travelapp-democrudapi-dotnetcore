using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyDuLich.Common.Req
{
    public class DonDatTourReq
    {
        public int Id { get; set; }
        public decimal DonGia { get; set; }
        public int SoLuong { get; set; }
        public decimal TongTien { get; set; }
        public int TourId { get; set; }
        public int UserId { get; set; }
    }
}

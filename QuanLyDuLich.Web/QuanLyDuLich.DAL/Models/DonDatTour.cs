using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyDuLich.DAL.Models
{
    public partial class DonDatTour
    {
        public int Id { get; set; }
        public decimal DonGia { get; set; }
        public int SoLuong { get; set; }
        public decimal TongTien { get; set; }
        public int TourId { get; set; }
        public int UserId { get; set; }

        public virtual Tour Tour { get; set; }
        public virtual User User { get; set; }
    }
}

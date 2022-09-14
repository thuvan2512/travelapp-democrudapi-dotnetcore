using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyDuLich.DAL.Models
{
    public partial class Tour
    {
        public Tour()
        {
            DonDatTours = new HashSet<DonDatTour>();
            LichTrinhs = new HashSet<LichTrinh>();
        }

        public int Id { get; set; }
        public string TenTour { get; set; }
        public decimal? DonGia { get; set; }
        public string LoaiTour { get; set; }
        public DateTime? NgayKhoiHanh { get; set; }
        public DateTime? NgayKetThuc { get; set; }

        public virtual ICollection<DonDatTour> DonDatTours { get; set; }
        public virtual ICollection<LichTrinh> LichTrinhs { get; set; }
    }
}

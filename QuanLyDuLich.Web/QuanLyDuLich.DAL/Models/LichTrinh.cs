using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyDuLich.DAL.Models
{
    public partial class LichTrinh
    {
        public int Id { get; set; }
        public string TieuDe { get; set; }
        public string NoiDung { get; set; }
        public int TourId { get; set; }

        public virtual Tour Tour { get; set; }
    }
}

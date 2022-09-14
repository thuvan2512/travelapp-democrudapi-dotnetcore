using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyDuLich.DAL.Models
{
    public partial class Comment
    {
        public int Id { get; set; }
        public string NoiDung { get; set; }
        public int TinTucId { get; set; }
        public int UserId { get; set; }

        public virtual TinTuc TinTuc { get; set; }
        public virtual User User { get; set; }
    }
}

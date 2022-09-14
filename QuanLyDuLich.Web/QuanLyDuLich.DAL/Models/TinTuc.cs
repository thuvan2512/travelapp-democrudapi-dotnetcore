using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyDuLich.DAL.Models
{
    public partial class TinTuc
    {
        public TinTuc()
        {
            Comments = new HashSet<Comment>();
        }

        public int Id { get; set; }
        public string ChuDe { get; set; }
        public string NoiDung { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}

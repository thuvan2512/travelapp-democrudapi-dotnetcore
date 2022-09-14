using System;
using System.Collections.Generic;

#nullable disable

namespace QuanLyDuLich.DAL.Models
{
    public partial class User
    {
        public User()
        {
            Comments = new HashSet<Comment>();
            DonDatTours = new HashSet<DonDatTour>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Pass { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool? IsActive { get; set; }
        public string Role { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<DonDatTour> DonDatTours { get; set; }
    }
}

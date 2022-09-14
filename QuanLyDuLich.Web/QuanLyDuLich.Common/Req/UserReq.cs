using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyDuLich.Common.Req
{
    public class UserReq
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Pass { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool? IsActive { get; set; }
        public string Role { get; set; }
    }
}

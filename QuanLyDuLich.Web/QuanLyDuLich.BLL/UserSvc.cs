
using QuanLyDuLich.Common.BLL;
using QuanLyDuLich.DAL.Models;
using QuanLyDuLich.DAL;
using System;
using System.Collections.Generic;
using System.Text;
using QuanLyDuLich.Common.Rsp;
using QuanLyDuLich.Common.Req;

namespace QuanLyDuLich.BLL
{
    public class UserSvc : GenericSvc<UserRep, User>
    {
        private UserRep userRep;
        #region -- Overrides --
        public override SingleRsp Read(int id)
        {
            var res = new SingleRsp();

            var m = _rep.Read(id);
            res.Data = m;

            return res;
        }



        #endregion

        #region -- Methods --

        public UserSvc() {
            userRep = new UserRep();
        }
        public SingleRsp createUser(UserReq userReq) {
            User user = new User();
            user.FirstName = userReq.FirstName;
            user.LastName = userReq.LastName;
            user.UserName = userReq.UserName;
            user.Pass = userReq.Pass;
            user.PhoneNumber = userReq.PhoneNumber;
            user.Email = userReq.Email;
            user.Role = userReq.Role;
            user.IsActive = userReq.IsActive;
            return userRep.createUser(user);
        }
        public SingleRsp updateUser(UserReq userReq)
        {
            var res = new SingleRsp();
            var user = _rep.Read(userReq.Id);
            if (user == null)
            {
                res.SetError("EZ103", "No data.");
            }
            else
            {
                user.Id = userReq.Id;
                user.FirstName = userReq.FirstName;
                user.LastName = userReq.LastName;
                user.UserName = userReq.UserName;
                user.Pass = userReq.Pass;
                user.PhoneNumber = userReq.PhoneNumber;
                user.Email = userReq.Email;
                user.Role = userReq.Role;
                user.IsActive = userReq.IsActive;
                res = userRep.updateUser(user);
                res.Data = user;
            }

            return res;
        }
        public SingleRsp deleteUser(int id)
        {
            var res = new SingleRsp();
            var user = _rep.Read(id);
            if (user == null)
            {
                res.SetError("EZ103", "No data.");
            }
            else
            {
                res = userRep.deleteUser(user);
            }

            return res;
        }
        #endregion
    }
}



using QuanLyDuLich.Common.DAL;
using QuanLyDuLich.Common.Rsp;
using QuanLyDuLich.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyDuLich.DAL
{
    public class UserRep : GenericRep<QuanLyDuLichContext, User>
    {
        #region -- Overrides --

        //public override Category Read(int id)
        //{
        //    var res = All.FirstOrDefault(p => p.CategoryId == id);
        //    return res;
        //}
        public override User Read(int id)
        {
            var res = All.FirstOrDefault(u => u.Id == id);
            return res;
        }

        public int Remove(int id)
        {
            var m = base.All.First(u => u.Id == id);
            m = base.Delete(m);
            return m.Id;
        }

        #endregion

        #region -- Methods --
        public SingleRsp createUser(User user) {
            var res = new SingleRsp();
            using (var context = new QuanLyDuLichContext()) {
                using (var trans = context.Database.BeginTransaction()) {
                    try
                    {
                        context.Users.Add(user);
                        context.SaveChanges();
                        trans.Commit();
                    }
                    catch (Exception e)
                    {
                        trans.Rollback();
                        res.SetError(e.StackTrace);
                        
                    }
                }
            }
            return res;
        }
        public SingleRsp updateUser(User user)
        {
            var res = new SingleRsp();
            using (var context = new QuanLyDuLichContext())
            {
                using (var trans = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.Users.Update(user);
                        context.SaveChanges();
                        trans.Commit();
                    }
                    catch (Exception e)
                    {
                        trans.Rollback();
                        res.SetError(e.StackTrace);

                    }
                }
            }
            return res;
        }
        public SingleRsp deleteUser(User user)
        {
            var res = new SingleRsp();
            using (var context = new QuanLyDuLichContext())
            {
                using (var trans = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.Users.Remove(user);
                        context.SaveChanges();
                        trans.Commit();
                    }
                    catch (Exception e)
                    {
                        trans.Rollback();
                        res.SetError(e.StackTrace);

                    }
                }
            }
            return res;
        }
        #endregion
    }
}
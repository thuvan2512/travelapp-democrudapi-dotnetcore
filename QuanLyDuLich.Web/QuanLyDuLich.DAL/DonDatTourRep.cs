using QuanLyDuLich.Common.DAL;
using QuanLyDuLich.Common.Rsp;
using QuanLyDuLich.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyDuLich.DAL
{
    public class DonDatTourRep : GenericRep<QuanLyDuLichContext, DonDatTour>
    {
        #region -- Overrides --

        //public override Category Read(int id)
        //{
        //    var res = All.FirstOrDefault(p => p.CategoryId == id);
        //    return res;
        //}
        public override DonDatTour Read(int id)
        {
            var res = All.FirstOrDefault(t => t.Id == id);
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
        public SingleRsp createDonDatTour(DonDatTour dt)
        {
            var res = new SingleRsp();
            using (var context = new QuanLyDuLichContext())
            {
                using (var trans = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.DonDatTours.Add(dt);
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
        public SingleRsp updateDonDatTour(DonDatTour dt)
        {
            var res = new SingleRsp();
            using (var context = new QuanLyDuLichContext())
            {
                using (var trans = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.DonDatTours.Update(dt);
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
        public SingleRsp deleteDonDatTour(DonDatTour dt)
        {
            var res = new SingleRsp();
            using (var context = new QuanLyDuLichContext())
            {
                using (var trans = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.DonDatTours.Remove(dt);
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
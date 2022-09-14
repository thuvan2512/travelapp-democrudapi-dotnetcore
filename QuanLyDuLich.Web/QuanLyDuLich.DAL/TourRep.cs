using QuanLyDuLich.Common.DAL;
using QuanLyDuLich.Common.Rsp;
using QuanLyDuLich.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyDuLich.DAL
{
    public class TourRep : GenericRep<QuanLyDuLichContext, Tour>
    {
        #region -- Overrides --

        //public override Category Read(int id)
        //{
        //    var res = All.FirstOrDefault(p => p.CategoryId == id);
        //    return res;
        //}
        public override Tour Read(int id)
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

        public SingleRsp createTour(Tour tour)
        {
            var res = new SingleRsp();
            using (var context = new QuanLyDuLichContext())
            {
                using (var trans = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.Tours.Add(tour);
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
        public SingleRsp updateTour(Tour tour)
        {
            var res = new SingleRsp();
            using (var context = new QuanLyDuLichContext())
            {
                using (var trans = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.Tours.Update(tour);
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
        public SingleRsp deleteTour(Tour tour)
        {
            var res = new SingleRsp();
            using (var context = new QuanLyDuLichContext())
            {
                using (var trans = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.Tours.Remove(tour);
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
        public List<Tour> searchTour(string kw) {
            return All.Where(p => p.TenTour.Contains(kw)).ToList();
        }
        #endregion
    }
}
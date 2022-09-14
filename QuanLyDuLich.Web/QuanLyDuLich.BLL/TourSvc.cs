using QLBH.Common.Req;
using QuanLyDuLich.Common.BLL;
using QuanLyDuLich.Common.Req;
using QuanLyDuLich.Common.Rsp;
using QuanLyDuLich.DAL;
using QuanLyDuLich.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyDuLich.BLL
{
    public class TourSvc : GenericSvc<TourRep, Tour>
    {
        private TourRep tourRep;
        #region -- Overrides --
        public override SingleRsp Read(int id)
        {
            var res = new SingleRsp();

            var m = _rep.Read(id);
            res.Data = m;

            return res;
        }


        public override SingleRsp Update(Tour m)
        {
            var res = new SingleRsp();

            var m1 = m.Id > 0 ? _rep.Read(m.Id) : _rep.Read(m.LoaiTour);
            if (m1 == null)
            {
                res.SetError("EZ103", "No data.");
            }
            else
            {
                res = base.Update(m);
                res.Data = m;
            }

            return res;
        }
        #endregion

        #region -- Methods --

        public TourSvc() {
            tourRep = new TourRep();
        }
        public SingleRsp createTour(TourReq tourReq)
        {
            Tour tour = new Tour();
            tour.LoaiTour = tourReq.LoaiTour;
            tour.DonGia = tourReq.DonGia;
            tour.TenTour = tourReq.TenTour;
            tour.NgayKhoiHanh = tourReq.NgayKhoiHanh;
            tour.NgayKetThuc = tourReq.NgayKetThuc;
            return tourRep.createTour(tour);
        }
        public SingleRsp updateTour(TourReq tourReq)
        {
            var res = new SingleRsp();
            var tour = _rep.Read(tourReq.Id);
            if (tour == null)
            {
                res.SetError("EZ103", "No data.");
            }
            else
            {
                tour.LoaiTour = tourReq.LoaiTour;
                tour.DonGia = tourReq.DonGia;
                tour.TenTour = tourReq.TenTour;
                tour.NgayKhoiHanh = tourReq.NgayKhoiHanh;
                tour.NgayKetThuc = tourReq.NgayKetThuc;
                res = tourRep.updateTour(tour);
                res.Data = tour;
            }

            return res;
        }
        public SingleRsp deleteTour(int id)
        {
            var res = new SingleRsp();
            var tour = _rep.Read(id);
            if (tour == null)
            {
                res.SetError("EZ103", "No data.");
            }
            else
            {
                res = tourRep.deleteTour(tour);
            }
            return res;
        }
        public SingleRsp searchTour(SearchTourReq searchTourReq) {
            var res = new SingleRsp();
            var tours = tourRep.searchTour(searchTourReq.Keyword);
            int countProducts = tours.Count;
            int offset = searchTourReq.Size * (searchTourReq.Page - 1);
            int countPage = (countProducts % searchTourReq.Size) == 0 ? countProducts / searchTourReq.Size : 1 + (countProducts / searchTourReq.Size);
            var p = new {
                Data = tours.Skip(offset).Take(searchTourReq.Size).ToList(),
                Page = searchTourReq.Page,
                Size = searchTourReq.Size
            };
            res.Data = p;
            return res;
        }

        #endregion
    }
}
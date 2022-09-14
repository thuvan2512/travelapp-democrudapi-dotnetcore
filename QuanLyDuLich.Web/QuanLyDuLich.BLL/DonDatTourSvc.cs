using QuanLyDuLich.Common.BLL;
using QuanLyDuLich.Common.Req;
using QuanLyDuLich.Common.Rsp;
using QuanLyDuLich.DAL;
using QuanLyDuLich.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyDuLich.BLL
{
    public class DonDatTourSvc : GenericSvc<DonDatTourRep, DonDatTour>
    {
        private DonDatTourRep donDatTourRep;
        private UserSvc userSvc;
        private TourSvc tourSvc;
        #region -- Overrides --
        public override SingleRsp Read(int id)
        {
            var res = new SingleRsp();

            var m = _rep.Read(id);
            res.Data = m;

            return res;
        }


        public override SingleRsp Update(DonDatTour m)
        {
            var res = new SingleRsp();

            var m1 = m.Id > 0 ? _rep.Read(m.Id) : _rep.Read(m.ToString());
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

        public DonDatTourSvc() {
            donDatTourRep = new DonDatTourRep();
            userSvc = new UserSvc();
            tourSvc = new TourSvc();
        }
        public SingleRsp createDonDatTour(DonDatTourReq donDatTourReq)
        {
            var res = new SingleRsp();
            var tour = tourSvc.Read(donDatTourReq.TourId);
            var user = userSvc.Read(donDatTourReq.UserId);
            if (tour == null || user == null)
            {
                res.SetError("EZ103", "No data.");
            }
            else
            {
                DonDatTour dt = new DonDatTour();
                dt.DonGia = donDatTourReq.DonGia;
                dt.SoLuong = donDatTourReq.SoLuong;
                dt.TongTien = donDatTourReq.TongTien;
                dt.UserId = donDatTourReq.UserId;
                dt.TourId = donDatTourReq.TourId;
                res = donDatTourRep.createDonDatTour(dt);
                res.Data = dt;
            }

            return res;
        }
        public SingleRsp updateDonDatTour(DonDatTourReq donDatTourReq)
        {
            var res = new SingleRsp();
            var dt = _rep.Read(donDatTourReq.Id);
            if (dt == null)
            {
                res.SetError("EZ103", "No data.");
            }
            else
            {
                dt.DonGia = donDatTourReq.DonGia;
                dt.SoLuong = donDatTourReq.SoLuong;
                dt.TongTien = donDatTourReq.TongTien;
                res = donDatTourRep.updateDonDatTour(dt);
                res.Data = dt;
            }

            return res;
        }
        public SingleRsp deleteDonDatTour(int id)
        {
            var res = new SingleRsp();
            var dt = _rep.Read(id);
            if (dt == null)
            {
                res.SetError("EZ103", "No data.");
            }
            else
            {
                res = donDatTourRep.deleteDonDatTour(dt);
            }
            return res;
        }


        #endregion
    }
}
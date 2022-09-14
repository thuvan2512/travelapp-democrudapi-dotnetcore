using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuanLyDuLich.BLL;
using QuanLyDuLich.Common.Req;
using QuanLyDuLich.Common.Rsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyDuLich.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonDatTourController : ControllerBase
    {
        private readonly DonDatTourSvc donDatTourSvc;
        public DonDatTourController()
        {
            donDatTourSvc = new DonDatTourSvc();
        }
        [HttpPost("get-by-id")]
        public IActionResult getDonDatTourById([FromBody] SimpleReq req)
        {
            var res = new SingleRsp();
            res = donDatTourSvc.Read(req.Id);
            return Ok(res);
        }

        [HttpGet("get-all")]
        public IActionResult getAllDonDatTour()
        {
            var res = new SingleRsp();
            res.Data = donDatTourSvc.All;
            return Ok(res);
        }
        [HttpPost("create-don_dat_tour")]
        public IActionResult createDonDatTour([FromBody] DonDatTourReq donDatTourReq)
        {
            var res = new SingleRsp();
            res = donDatTourSvc.createDonDatTour(donDatTourReq);
            return Ok(res);
        }

        [HttpPut("update-don_dat_tour")]
        public IActionResult updateDonDatTour([FromBody] DonDatTourReq donDatTourReq)
        {
            var res = new SingleRsp();
            res = donDatTourSvc.updateDonDatTour(donDatTourReq);
            return Ok(res);
        }

        [HttpDelete("delete-don_dat_tour")]
        public IActionResult deleteDonDatTour([FromBody] SimpleReq req)
        {
            var res = new SingleRsp();
            res = donDatTourSvc.deleteDonDatTour(req.Id);
            return Ok(res);
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLBH.Common.Req;
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
    public class TourController : ControllerBase
    {
        private readonly TourSvc tourSvc;
        public TourController()
        {
            tourSvc = new TourSvc();
        }
        [HttpPost("get-by-id")]
        public IActionResult getTourById([FromBody] SimpleReq req)
        {
            var res = new SingleRsp();
            res = tourSvc.Read(req.Id);
            return Ok(res);
        }

        [HttpGet("get-all")]
        public IActionResult getAllTour()
        {
            var res = new SingleRsp();
            res.Data = tourSvc.All;
            return Ok(res);
        }
        [HttpPost("create-tour")]
        public IActionResult createTour([FromBody] TourReq tourReq)
        {
            var res = new SingleRsp();
            res = tourSvc.createTour(tourReq);
            return Ok(res);
        }

        [HttpPut("update-tour")]
        public IActionResult updateTour([FromBody] TourReq tourReq)
        {
            var res = new SingleRsp();
            res = tourSvc.updateTour(tourReq);
            return Ok(res);
        }

        [HttpDelete("delete-tour")]
        public IActionResult deleteTour([FromBody] SimpleReq req)
        {
            var res = new SingleRsp();
            res = tourSvc.deleteTour(req.Id);
            return Ok(res);
        }

        [HttpPost("search-tour")]
        public IActionResult searchTour([FromBody] SearchTourReq searchTourReq)
        {
            var res = new SingleRsp();
            res = tourSvc.searchTour(searchTourReq);
            return Ok(res);
        }
    }
}

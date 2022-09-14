using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuanLyDuLich.BLL;
using QuanLyDuLich.Common.Req;
using QuanLyDuLich.Common.Rsp;
using QuanLyDuLich.DAL;
using QuanLyDuLich.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyDuLich.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserSvc userSvc;
        public UserController()
        {
            userSvc = new UserSvc();
        }
        [HttpPost("get-by-id")]
        public IActionResult getUserById([FromBody] SimpleReq req)
        {
            var res = new SingleRsp();
            res = userSvc.Read(req.Id);
            return Ok(res);
        }

        [HttpGet("get-all")]
        public IActionResult getAllUser()
        {
            var res = new SingleRsp();
            res.Data = userSvc.All;
            return Ok(res);
        }
        [HttpPost("create-user")]
        public IActionResult createUser([FromBody] UserReq userReq)
        {
            var res = new SingleRsp();
            res = userSvc.createUser(userReq);
            return Ok(res);
        }

        [HttpPut("update-user")]
        public IActionResult updateUser([FromBody] UserReq userReq)
        {
            var res = new SingleRsp();
            res = userSvc.updateUser(userReq);
            return Ok(res);
        }

        [HttpDelete("delete-user")]
        public IActionResult deleteUser([FromBody] SimpleReq req)
        {
            var res = new SingleRsp();
            res = userSvc.deleteUser(req.Id);
            return Ok(res);
        }
    }
}

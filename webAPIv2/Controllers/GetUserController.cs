using Business.Abstract;
using Business.Concrete;
using Core.Entities.Concrete;
using Core.Utilities.Security.Hashing;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;

namespace webAPIv2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetUserController : ControllerBase
    {

        IUserService _userService;
        ILogService _logService;

        public GetUserController(IUserService userService, ILogService logService)
        {
            _userService = userService;
            _logService = logService;
        }

        [HttpGet]
        public IActionResult GetUserProfile()
        {
            int userID = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var user =  _userService.GetUserById(userID);
            return Ok(user);
        }

    }
}


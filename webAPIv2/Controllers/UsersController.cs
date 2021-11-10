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
    public class UsersController : ControllerBase
    {
        //Loosely coupled
        //naming convention
        //javascript angular
        //IoC Containe -- Inversion of control
        IUserService _userService;
        ILogService _logService;
        public UsersController(IUserService userService, ILogService logService)
        {
            _userService = userService;
            _logService = logService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            //Dependency chain --
            // Thread.Sleep(3000);
            var result = _userService.GetAll().Data.OrderBy(u => u.Id);
            //if (result.Success)
            //{
                return Ok(result);
            //}
            //return BadRequest(result);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _userService.GetAllByID(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[HttpGet("{id}")]
        //public IActionResult GetRol()
        //{
        //    var result = _userService.GetClaims();

        //    return BadRequest(result);
        //}


        [HttpPost("add")]
        public IActionResult Add(User user)
        {
            var result = _userService.Addd(user);
            if (result.Success)
            {
                _logService.Add(
                   new Logs
                   {
                       UserId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier)),
                       LogStatus = "Başarılı",
                       LogExp = "Kullanıcı eklendi.",
                       LogType = "Kullanıcı ekleme",
                       LogDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss "),
                       LogIp = HttpContext.Connection.RemoteIpAddress.ToString()

                   });
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update/{id}")]
        public IActionResult Update(int id, UserForUpdateDto userUpdate)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(userUpdate.password, out passwordHash, out passwordSalt);
            var user = new User
            {
                Mail = userUpdate.uMail,
                Name = userUpdate.uName,
                Surname = userUpdate.uSurname,
                Adress = userUpdate.uAdress,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Rol = userUpdate.uRol,
                Status = true,
            };

            var result = _userService.Update(id, user);
            _logService.Add(
                   new Logs
                   {
                       UserId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier)),
                       LogStatus = "Başarılı",
                       LogExp = "Kullanıcı güncellendi.",
                       LogType = "Kullanıcı güncelleme",
                       LogDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss "),
                       LogIp = HttpContext.Connection.RemoteIpAddress.ToString()

                   });
            return Ok(result);

        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _logService.Add(
                   new Logs
                   {
                       UserId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier)),
                       LogStatus = "Başarılı",
                       LogExp = "Kullanıcı silindi.",
                       LogType = "Kullanıcı silme",
                       LogDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss "),
                       LogIp = HttpContext.Connection.RemoteIpAddress.ToString()

                   });
            _userService.DeleteUser(id);
        }

    }
}


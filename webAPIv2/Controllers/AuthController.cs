using Business.Abstract;
using Entities.Concrete;
using System.Security.Claims;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webAPIv2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private IAuthService _authService;
        ILogService _logService;

        public AuthController(IAuthService authService, ILogService logService)
        {
            _authService = authService;
            _logService = logService;
        }

        [HttpPost("login")]
        public ActionResult Login(UserForLoginDto userForLoginDto)
        {
            var userToLogin = _authService.Login(userForLoginDto);
            if (!userToLogin.Success)
            {
                return BadRequest(userToLogin.Message);
            }

            var result = _authService.CreateAccessToken(userToLogin.Data);
            if (result.Success)
            {
                _logService.Add(
                   new Logs
                   {
                       UserId = userToLogin.Data.Id,
                       LogStatus = "Başarılı",
                       LogExp = "Kullanıcı giriş yaptı.",
                       LogType = "Kullanıcı giriş",
                       LogDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss "),
                       LogIp = HttpContext.Connection.RemoteIpAddress.ToString()

                   });
                return Ok(result);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("register")]
        public ActionResult Register(UserForRegisterDto userForRegisterDto)
        {
            var userExists = _authService.UserExists(userForRegisterDto.uMail);
            if (!userExists.Success)
            {
                return BadRequest(userExists.Message);
            }

            var registerResult = _authService.Register(userForRegisterDto, userForRegisterDto.password);
            var result = _authService.CreateAccessToken(registerResult.Data);
            if (result.Success)
            {
                _logService.Add(
                   new Logs
                   {
                       UserId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier)), //düzeltilmeli
                       LogStatus = "Başarılı",
                       LogExp = "Kullanıcı kayıt edildi.",
                       LogType = "Kullanıcı kayıt",
                       LogDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss "),
                       LogIp = HttpContext.Connection.RemoteIpAddress.ToString()

                   });
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
    }
}

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

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            //Dependency chain --
            // Thread.Sleep(3000);
            var result = _userService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
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


        [HttpPost("add")]
        public IActionResult Add(User user)
        {
            var result = _userService.Addd(user);
            if (result.Success)
            {
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
                uMail = userUpdate.uMail,
                uName = userUpdate.uName,
                uSurname = userUpdate.uSurname,
                uAdress = userUpdate.uAdress,
                uPasswordHash = passwordHash,
                uPasswordSalt = passwordSalt,
                Status = true
            };

            var result = _userService.Update(id, user);
            
                return Ok(result);
            
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _userService.DeleteUser(id);
        }

    }
}


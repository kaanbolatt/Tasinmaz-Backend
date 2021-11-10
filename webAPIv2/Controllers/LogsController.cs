using Business.Abstract;
using Business.Concrete;
using Core.Entities.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webAPIv2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogsController : ControllerBase
    {
        //Loosely coupled
        //naming convention
        //javascript angular
        //IoC Containe -- Inversion of control
        ILogService _logService;

        public LogsController(ILogService logService)
        {
            _logService = logService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //Dependency chain --
             var result = _logService.GetAll();
            //if (result.Success)
            //{
                return Ok(result);
            //}
            //return BadRequest(result);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _logService.GetByID(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyExp")]
        public IActionResult GetByExp(string exp)
        {
            var result = _logService.GetByExp(exp);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbystatus")]
        public IActionResult GetByStatus(string status)
        {
            var result = _logService.GetByStatus(status);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbytype")]
        public IActionResult GetByType(string type)
        {
            var result = _logService.GetByType(type);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyuserid")]
        public IActionResult GetByUserID(int uid)
        {
            var result = _logService.GetByUserID(uid);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyip")]
        public IActionResult GetByIP(string ip)
        {
            var result = _logService.GetByIP(ip);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _logService.DeleteLog(id);
        }
        [HttpPost("add")]
        public IActionResult Add(Logs logs)
        {
            var result = _logService.Add(logs);
            if (result.Success)
            {

                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
    }
}


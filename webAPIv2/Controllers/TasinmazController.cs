using Business.Abstract;
using Business.Concrete;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace webAPIv2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasinmazController : ControllerBase
    {
        //Loosely coupled
        //naming convention
        //javascript angular
        //IoC Containe -- Inversion of control
        ITasinmazService _tasinmazService;
        ILogService _logService;
        private readonly ITasinmazDal _tasinmazDalReposity;

        public TasinmazController(ITasinmazService tasinmazService, ILogService logService, ITasinmazDal tasinmazDalReposity)
        {
            _tasinmazService = tasinmazService;
            _tasinmazDalReposity = tasinmazDalReposity;

            _logService = logService;
        }
       
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            
            var result = _tasinmazDalReposity.AllTasinmaz().OrderByDescending(t => t.Id);
            //var result = _tasinmazService.AllTasinmaz().Data.OrderByDescending(t => t.Id);
            //if (result.Success)
            //{
                return Ok(result);
            //}
            //return BadRequest(result);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _tasinmazService.GetBytID(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[HttpGet("getbyuserid")]
        //public IActionResult GetByuserID(int uID)
        //{
        //    var result = _tasinmazService.GetByuserID(uID);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}

        //[HttpGet("getbyada")]
        //public IActionResult GetByAda(int ada)
        //{
        //    var result = _tasinmazService.GetByAda(ada);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}


        [HttpPut("update/{id}")]
        public IActionResult Update(int id, Tasinmaz tasinmaz)
        {


            var result = _tasinmazService.Update(id, tasinmaz);
            if (result.Success)
            {
                _logService.Add(
                   new Logs
                   {
                       UserId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier)),
                       LogStatus = "Başarılı",
                       LogExp = "Taşınmaz güncellendi.",
                       LogType = "Taşınmaz güncelleme",
                       LogDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss "),
                       LogIp = HttpContext.Connection.RemoteIpAddress.ToString()

                   });
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpGet("province/{id}")]
        public IActionResult GetByProvinceID(int id)
        {
            var result = _tasinmazService.GetByProvinceID(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[HttpGet("country/{id}")]
        //public IActionResult GetByCountryID(int id)
        //{
        //    var result = _tasinmazService.GetByCountryID(id);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _logService.Add(
                   new Logs
                   {
                      UserId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier)),
                      LogStatus = "Başarılı",
                      LogExp  = "Taşınmaz silindi.",
                      LogType = "Taşınmaz silme",
                      LogDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss "),
                      LogIp = HttpContext.Connection.RemoteIpAddress.ToString()

                   });
            _tasinmazService.DeleteTasinmaz(id);
        }

        [HttpPost("add")]
        public IActionResult Add(Tasinmaz tasinmaz)
        {
            var result = _tasinmazService.Add(tasinmaz);
            if (result.Success)
            {
                _logService.Add(
                    new Logs
                    {
                        UserId = Convert.ToInt32(User.FindFirstValue(ClaimTypes.NameIdentifier)),
                        LogStatus = "Başarılı",
                        LogExp  = "Taşınmaz eklendi.",
                        LogType = "Taşınmaz ekleme",
                        LogDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss "),
                        LogIp = HttpContext.Connection.RemoteIpAddress.ToString()

                    });
                return Ok(result);
            }

            return BadRequest(result);
        }

    }
}


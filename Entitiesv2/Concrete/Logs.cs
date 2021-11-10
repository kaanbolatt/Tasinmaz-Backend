using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Logs : IEntity
    {
        public int Id { get; set; }
        public string LogStatus { get; set; }
        public string LogType { get; set; }
        public int UserId { get; set; }
        public string LogDate { get; set; }
        public string LogExp { get; set; }
        public string LogIp { get; set; }
    }
}

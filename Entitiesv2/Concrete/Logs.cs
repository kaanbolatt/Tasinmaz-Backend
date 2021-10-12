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
        [Key]
        public int logID { get; set; }
        public string logStatus { get; set; }
        public string logType { get; set; }
        public int uID { get; set; }
        public string logDate { get; set; }
        public string logExp { get; set; }
        public int uIP { get; set; }
    }
}

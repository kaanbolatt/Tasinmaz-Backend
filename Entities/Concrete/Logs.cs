using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Logs : IEntity
    {
        public int logID { get; set; }
        public int uID { get; set; }
        public char logType { get; set; }
        public DateTime logDate { get; set; }

        public int uIP { get; set; }
        public char logExp { get; set; }
    }
}

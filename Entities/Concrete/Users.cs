using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Users : IEntity
    {
        public int uID { get; set; }

        public char uName { get; set; }

        public char uSurname{ get; set; }

        public char uMail { get; set; }
        public int uRole { get; set; }

        public int uNumber { get; set; }

        public char uAdress { get; set; }
    }
}

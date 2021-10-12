using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    
    public class User : IEntity
    {
        [Key]
        public int uID { get; set; }

        public string uName { get; set; }

        public string uSurname { get; set; }

        public string uMail { get; set; }
        public int uRole { get; set; }

        public int uNumber { get; set; }

        public string uAdress { get; set; }
        public string uPassword { get; set; }
    }

 
}

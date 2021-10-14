using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Entities.Concrete
{
    public class User : IEntity
    {
        [Key]
        public int uID { get; set; }
        public string uName { get; set; }
        public string uSurname { get; set; }
        public string uMail { get; set; }
        public int uNumber { get; set; }
        public string uAdress { get; set; }
        public byte[] uPasswordHash { get; set; }
        public byte[] uPasswordSalt { get; set; }
        public bool Status { get; set; }
    }
}

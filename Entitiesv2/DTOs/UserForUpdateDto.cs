using Core;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class UserForUpdateDto: IDto
    {
        public string uMail { get; set; }
        public string password { get; set; }
        public string uName { get; set; }
        public string uSurname { get; set; }
        public string uAdress { get; set; }

    }
}

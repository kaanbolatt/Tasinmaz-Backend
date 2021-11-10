using Core;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class UserDetailDto: IDto
    {
        public int userID { get; set; }
        public int tID { get; set; }
        public int pID { get; set; }
        public int cID { get; set; }
        public int nbID { get; set; }
        public int ada { get; set; }
        public int parsel { get; set; }
        public string nitelik { get; set; }
        public string koordinatX { get; set; }
        public string koordinatY { get; set; }

    }
}

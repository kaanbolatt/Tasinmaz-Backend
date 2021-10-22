using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Tasinmaz : IEntity
    {
        [Key]
        public int tID { get; set; }
        public int provinceID { get; set; }
        public int countryID { get; set; }
        public int nbID { get; set; }
        public int uID { get; set; }
        public int ada { get; set; }
        public int parsel { get; set; }
        public string nitelik { get; set; }
        public int koordinatX { get; set; }
        public int koordinatY { get; set; } //kaldir
    }
}

using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class Provinces : IEntity
    {
        [Key]
        public int provinceID { get; set; }
        public string provinceName { get; set; }
    }
}

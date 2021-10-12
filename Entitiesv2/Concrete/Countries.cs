using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class Countries : IEntity
    {
        [Key]
        public int countryID { get; set; }
        public string countryName { get; set; }
        public int provinceID { get; set; }
    }
}

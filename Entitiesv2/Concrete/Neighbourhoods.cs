using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class Neighbourhoods : IEntity
    {
        [Key]
        public int nbID { get; set; }
        public string nbName { get; set; }
        public int countryID { get; set; }
    }
}

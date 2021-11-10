using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Concrete
{
    public class Countries : IEntity
    {
        public int Id { get; set; }
        public int ProvinceId { get; set; }
        public virtual Provinces Province { get; set; }
        public string CountryName { get; set; }
        //public virtual Provinces provinces { get; set; }
        //public virtual List<Neighbourhoods> Nb {get; set;}
    }
}

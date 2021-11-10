using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class Provinces : IEntity
    {
        public int Id { get; set; }
        public string ProvinceName { get; set; }
        //public virtual List<Countries> Countries { get; set; }
    }
}

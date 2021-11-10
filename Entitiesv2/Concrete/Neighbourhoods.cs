using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Concrete
{
    public class Neighbourhoods : IEntity
    {
        public int Id { get; set; }
        public int CountriesId { get; set; }
        public virtual Countries Countries { get; set; }
        public string NbName { get; set; }


    }
}

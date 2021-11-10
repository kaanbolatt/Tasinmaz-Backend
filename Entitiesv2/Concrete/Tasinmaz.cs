using Core.Entities;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Tasinmaz : IEntity
    {
        public int Id { get; set; }
        public int Ada { get; set; }
        public int Parsel { get; set; }
        public string Nitelik { get; set; } = null!;
        public string KoordinatX { get; set; } = null!;
        public string KoordinatY { get; set; } = null!;
        public int NeighbourhoodsId { get; set; }
        public int UserId { get; set; }
        public int ProvinceId { get; set; }
        public int CountryId { get; set; }
        public virtual Neighbourhoods Neighbourhoods { get; set; }
        //public virtual User User { get; set; }

    }
}

using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface INeighbourhoodsService
    {
        List<Neighbourhoods> GetAll();
        List<Neighbourhoods> GetAllByID(int id);
        List<Neighbourhoods> GetAllByName(string name);
        List<Neighbourhoods> GetAllByCountryID(int id);
        
    }
}

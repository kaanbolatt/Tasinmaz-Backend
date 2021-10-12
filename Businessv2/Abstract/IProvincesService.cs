using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProvincesService
    {
        List<Provinces> GetAll();
        List<Provinces> GetlAllByID(int id);
        List<Provinces> GetAllByName(string name);
        
    }
}

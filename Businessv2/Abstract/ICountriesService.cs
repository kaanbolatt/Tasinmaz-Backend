using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICountriesService
    {
        List<Countries> GetAll();
        List<Countries> GetAllByID(int id);
        List<Countries> GetAllByName(string name);
        List<Countries> GetAllByProvinceID(int id);
        
    }
}

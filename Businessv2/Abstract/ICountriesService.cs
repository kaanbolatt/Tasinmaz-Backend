using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICountriesService
    {
        IDataResult<List<Countries>> GetAll();
        IDataResult<Countries> GetByID(int id);
        IDataResult<Countries> GetByName(string name);
        IDataResult<Countries> GetByProvinceID(int id);
        
    }
}

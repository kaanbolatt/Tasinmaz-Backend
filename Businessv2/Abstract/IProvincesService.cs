using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProvincesService
    {
        IDataResult<List<Provinces>> GetAll();
        IDataResult<Provinces> GetByID(int id);
        IDataResult<Provinces> GetByName(string name);
        
    }
}

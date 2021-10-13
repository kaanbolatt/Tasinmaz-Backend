using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface INeighbourhoodsService
    {
        IDataResult<List<Neighbourhoods>> GetAll();
        IDataResult<Neighbourhoods> GetByID(int id);
        IDataResult<Neighbourhoods> GetByName(string name);
        IDataResult<Neighbourhoods> GetByCountryID(int id);
        
    }
}

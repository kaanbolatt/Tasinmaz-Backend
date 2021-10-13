using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class NeighbourhoodsManager : INeighbourhoodsService
    {
        INeighbourhoodsDal neighbourDal;
        public NeighbourhoodsManager(INeighbourhoodsDal neighboursDal)
        {
            neighbourDal = neighboursDal;
        }
        
        public IDataResult<List<Neighbourhoods>> GetAll()
        {
            //iş kodları
            //yetkisi var mı?
            return new SuccessDataResult<List<Neighbourhoods>>(neighbourDal.GetAll());
        }

        public IDataResult<Neighbourhoods> GetByCountryID(int id)
        {
            return new SuccessDataResult<Neighbourhoods>(neighbourDal.Get(n => n.countryID == id));
        }

        public IDataResult<Neighbourhoods> GetByID(int id)
        {
            return new SuccessDataResult<Neighbourhoods>(neighbourDal.Get(n => n.nbID == id));
        }

        public IDataResult<Neighbourhoods> GetByName(string name)
        {
            return new SuccessDataResult<Neighbourhoods>(neighbourDal.Get(n => n.nbName == name));
        }
    }
}

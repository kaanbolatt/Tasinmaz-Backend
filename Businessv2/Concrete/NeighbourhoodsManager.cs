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
        INeighbourhoodsDal _neighbourDal;
        public NeighbourhoodsManager(INeighbourhoodsDal neighboursDal)
        {
            _neighbourDal = neighboursDal;
        }
        
        public IDataResult<List<Neighbourhoods>> GetAll()
        {
            //iş kodları
            //yetkisi var mı?
            return new SuccessDataResult<List<Neighbourhoods>>(_neighbourDal.GetAll());
        }

        public IDataResult<List<Neighbourhoods>> GetByCountryID(int id)
        {
            return new SuccessDataResult<List<Neighbourhoods>>(_neighbourDal.GetAll(n => n.CountriesId == id));
        }

        public IDataResult<Neighbourhoods> GetByID(int id)
        {
            return new SuccessDataResult<Neighbourhoods>(_neighbourDal.Get(n => n.Id == id));
        }

        public IDataResult<Neighbourhoods> GetByName(string name)
        {
            return new SuccessDataResult<Neighbourhoods>(_neighbourDal.Get(n => n.NbName == name));
        }
    }
}

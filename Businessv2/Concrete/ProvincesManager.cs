using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProvincesManager : IProvincesService
    {
        IProvincesDal _provinceDal;
        public ProvincesManager(IProvincesDal provincesDal)
        {
            _provinceDal = provincesDal;
        }
        
        public IDataResult<List<Provinces>> GetAll()
        {
            return new SuccessDataResult<List<Provinces>>(_provinceDal.GetAll());
        }

        public IDataResult<Provinces> GetByName(string name)
        {
            return new SuccessDataResult<Provinces>(_provinceDal.Get(p => p.ProvinceName == name));
        }


        public IDataResult<Provinces> GetByID(int id)
        {
            return new SuccessDataResult<Provinces>(_provinceDal.Get(p => p.Id == id));
        }


    }
}

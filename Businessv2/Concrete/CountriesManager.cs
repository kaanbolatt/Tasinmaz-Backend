using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CountriesManager : ICountriesService
    {
        ICountriesDal _countryDal;
        public CountriesManager(ICountriesDal countriesDal)
        {
            _countryDal = countriesDal;
        }
        
        public IDataResult<List<Countries>> GetAll()
        {
            return new SuccessDataResult<List<Countries>>(_countryDal.GetAll());
        }

        public IDataResult<Countries> GetByID(int id)
        {
            return new SuccessDataResult<Countries>(_countryDal.Get(c => c.Id == id));
        }

        public IDataResult<Countries> GetByName(string name)
        {
            return new SuccessDataResult<Countries>(_countryDal.Get(c => c.CountryName== name));
        }

        public IDataResult<List<Countries>> GetByProvinceID(int id)
        {
            return new SuccessDataResult<List<Countries>>(_countryDal.GetAll(c => c.ProvinceId== id));
        }
    }
}

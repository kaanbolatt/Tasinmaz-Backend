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
        ICountriesDal countryDal;
        public CountriesManager(ICountriesDal countriesDal)
        {
            countryDal = countriesDal;
        }
        
        public IDataResult<List<Countries>> GetAll()
        {
            //iş kodları
            //yetkisi var mı?
            return new SuccessDataResult<List<Countries>>(countryDal.GetAll());
        }

        public IDataResult<Countries> GetByID(int id)
        {
            return new SuccessDataResult<Countries>(countryDal.Get(c => c.countryID == id));
        }

        public IDataResult<Countries> GetByName(string name)
        {
            return new SuccessDataResult<Countries>(countryDal.Get(c => c.countryName == name));
        }

        public IDataResult<Countries> GetByProvinceID(int id)
        {
            return new SuccessDataResult<Countries>(countryDal.Get(c => c.provinceID == id));
        }
    }
}

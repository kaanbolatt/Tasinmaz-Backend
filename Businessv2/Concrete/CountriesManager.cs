using Business.Abstract;
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
        
        public List<Countries> GetAll()
        {
            //iş kodları
            //yetkisi var mı?
            return countryDal.GetAll();
        }

        public List<Countries> GetAllByID(int id)
        {
            return countryDal.GetAll(p => p.countryID == id);
        }

        public List<Countries> GetAllByName(string name)
        {
            return countryDal.GetAll(p => p.countryName == name);
        }

        public List<Countries> GetAllByProvinceID(int id)
        {
            return countryDal.GetAll(p => p.provinceID == id);
        }
    }
}

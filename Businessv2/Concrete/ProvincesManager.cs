using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProvincesManager : IProvincesService
    {
        IProvincesDal provinceDal;
        public ProvincesManager(IProvincesDal provincesDal)
        {
            provinceDal = provincesDal;
        }
        
        public List<Provinces> GetAll()
        {
            //iş kodları
            //yetkisi var mı?
            return provinceDal.GetAll();
        }

        public List<Provinces> GetAllByName(string name)
        {
            return provinceDal.GetAll(p => p.provinceName == name);
        }


        public List<Provinces> GetlAllByID(int id)
        {
            return provinceDal.GetAll(p => p.provinceID == id);
        }
    }
}

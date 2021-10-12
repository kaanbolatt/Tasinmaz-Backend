using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class TasinmazManager : ITasinmazService
    {
        ITasinmazDal tasinmazDal;
        public TasinmazManager(ITasinmazDal tasinmazsDal)
        {
            tasinmazDal = tasinmazsDal;
        }
        
        public List<Tasinmaz> GetAll()
        {
            //iş kodları
            //yetkisi var mı?
            return tasinmazDal.GetAll();
        }

        public List<Tasinmaz> GetAllByAda(int ada)
        {
            return tasinmazDal.GetAll(p => p.ada == ada);
        }

        public List<Tasinmaz> GetAllByCountryID(int id)
        {
            return tasinmazDal.GetAll(p => p.countryID == id);
        }

        public List<Tasinmaz> GetAllByID(int id)
        {
            return tasinmazDal.GetAll(p => p.tID == id);
        }

        public List<Tasinmaz> GetAllByKoordinatX(int x)
        {
            return tasinmazDal.GetAll(p => p.koordinatX == x);
        }

        public List<Tasinmaz> GetAllByKoordinatY(int y)
        {
           return tasinmazDal.GetAll(p => p.koordinatY == y);
        }

        public List<Tasinmaz> GetAllBynbID(int id)
        {
            return tasinmazDal.GetAll(p => p.nbID == id);
        }

        public List<Tasinmaz> GetAllByNitelik(string nitelik)
        {
            return tasinmazDal.GetAll(p => p.nitelik == nitelik);
        }

        public List<Tasinmaz> GetAllByParsel(int parsel)
        {
            return tasinmazDal.GetAll(p => p.parsel == parsel);
        }

        public List<Tasinmaz> GetAllByProvinceID(int id)
        {
            return tasinmazDal.GetAll(p => p.tID == id);
        }

        public List<Tasinmaz> GetAllByUserID(int id)
        {
            return tasinmazDal.GetAll(p => p.tID == id);
        }
    }
}

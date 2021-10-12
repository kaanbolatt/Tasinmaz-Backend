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
            return tasinmazDal.GetAll(t => t.ada == ada);
        }

        public List<Tasinmaz> GetAllByCountryID(int id)
        {
            return tasinmazDal.GetAll(t => t.countryID == id);
        }

        public List<Tasinmaz> GetAllByID(int id)
        {
            return tasinmazDal.GetAll(t => t.tID == id);
        }

        public List<Tasinmaz> GetAllByKoordinatX(int x)
        {
            return tasinmazDal.GetAll(t => t.koordinatX == x);
        }

        public List<Tasinmaz> GetAllByKoordinatY(int y)
        {
           return tasinmazDal.GetAll(t => t.koordinatY == y);
        }

        public List<Tasinmaz> GetAllBynbID(int id)
        {
            return tasinmazDal.GetAll(t => t.nbID == id);
        }

        public List<Tasinmaz> GetAllByNitelik(string nitelik)
        {
            return tasinmazDal.GetAll(t => t.nitelik == nitelik);
        }

        public List<Tasinmaz> GetAllByParsel(int parsel)
        {
            return tasinmazDal.GetAll(t => t.parsel == parsel);
        }

        public List<Tasinmaz> GetAllByProvinceID(int id)
        {
            return tasinmazDal.GetAll(t => t.tID == id);
        }

        public List<Tasinmaz> GetAllByUserID(int id)
        {
            return tasinmazDal.GetAll(t => t.tID == id);
        }
    }
}

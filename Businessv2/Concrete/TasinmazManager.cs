using Business.Abstract;
using Core.Utilities.Results;
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
        
        public IDataResult<List<Tasinmaz>> GetAll()
        {
            //iş kodları
            //yetkisi var mı?
            return new SuccessDataResult<List<Tasinmaz>>(tasinmazDal.GetAll());
        }

        public IDataResult<Tasinmaz> GetByAda(int ada)
        {
            return new SuccessDataResult<Tasinmaz>(tasinmazDal.Get(t => t.ada == ada));
        }

        public IDataResult<Tasinmaz> GetByCountryID(int id)
        {
            return new SuccessDataResult<Tasinmaz>(tasinmazDal.Get(t => t.countryID == id));
        }

        public IDataResult<Tasinmaz> GetByID(int id)
        {
            return new SuccessDataResult<Tasinmaz>(tasinmazDal.Get(t => t.tID == id));
        }

        public IDataResult<Tasinmaz> GetByKoordinatX(int x)
        {
            return new SuccessDataResult<Tasinmaz>(tasinmazDal.Get(t => t.koordinatX == x));
        }

        public IDataResult<Tasinmaz> GetByKoordinatY(int y)
        {
            return new SuccessDataResult<Tasinmaz>(tasinmazDal.Get(t => t.koordinatY == y));
        }

        public IDataResult<Tasinmaz> GetBynbID(int id)
        {
            return new SuccessDataResult<Tasinmaz>(tasinmazDal.Get(t => t.nbID == id));
        }

        public IDataResult<Tasinmaz> GetByNitelik(string nitelik)
        {
            return new SuccessDataResult<Tasinmaz>(tasinmazDal.Get(t => t.nitelik == nitelik));
        }

        public IDataResult<Tasinmaz> GetByParsel(int parsel)
        {
            return new SuccessDataResult<Tasinmaz>(tasinmazDal.Get(t => t.parsel == parsel));
        }

        public IDataResult<Tasinmaz> GetByProvinceID(int id)
        {
            return new SuccessDataResult<Tasinmaz>(tasinmazDal.Get(t => t.tID == id));
        }

        public IDataResult<Tasinmaz> GetByUserID(int id)
        {
            return new SuccessDataResult<Tasinmaz>(tasinmazDal.Get(t => t.tID == id));
        }
    }
}

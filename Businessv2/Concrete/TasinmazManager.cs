using Business.Abstract;
using Business.BusinessAspects.AutoFac;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Business.Constants;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Aspects.Autofac.Performance;

namespace Business.Concrete
{
    public class TasinmazManager : ITasinmazService
    {
        ITasinmazDal _tasinmazDal;
        public TasinmazManager(ITasinmazDal tasinmazDal)
        {
            _tasinmazDal = tasinmazDal;
        }
        //[SecuredOperation("tasinmaz.add")]
        //[ValidationAspect(typeof(TasinmazValidator))]
        // [CacheRemoveAspect("ITasinmazService.Get")]
        public IResult Add(Tasinmaz tasinmaz)
        {
            _tasinmazDal.Add(tasinmaz);
            return new SuccessResult(Messages.TasinmazAdded);
        }

        public IResult Update(int id, Tasinmaz tasinmaz)
        {
            _tasinmazDal.UpdateTasinmaz(id,tasinmaz);
            return new SuccessResult(Messages.TasinmazUpdated);
        }

        public void DeleteTasinmaz(int id)
        {
            _tasinmazDal.DeleteTasinmaz(id);
             new SuccessResult(Messages.TasinmazDeleted);
        }

        // add-delete-update //

        public IDataResult<List<Tasinmaz>> GetAll()
        {
            //iş kodları
            //yetkisi var mı?
            return new SuccessDataResult<List<Tasinmaz>>(_tasinmazDal.GetAll(), Messages.TasinmazListed);
        }

        public IDataResult<Tasinmaz> GetByAda(int ada)
        {
            return new SuccessDataResult<Tasinmaz>(_tasinmazDal.Get(t => t.ada == ada));
        }

        public IDataResult<Tasinmaz> GetByCountryID(int id)
        {
            return new SuccessDataResult<Tasinmaz>(_tasinmazDal.Get(t => t.countryID == id));
        }
        // [CacheAspect]
        [PerformanceAspect(1)]
        public IDataResult<Tasinmaz> GetBytID(int id)
        {
            return new SuccessDataResult<Tasinmaz>(_tasinmazDal.Get(t => t.tID == id));
        }

        public IDataResult<Tasinmaz> GetByKoordinatX(int x)
        {
            return new SuccessDataResult<Tasinmaz>(_tasinmazDal.Get(t => t.koordinatX == x));
        }

        public IDataResult<Tasinmaz> GetByKoordinatY(int y)
        {
            return new SuccessDataResult<Tasinmaz>(_tasinmazDal.Get(t => t.koordinatY == y));
        }

        public IDataResult<Tasinmaz> GetBynbID(int id)
        {
            return new SuccessDataResult<Tasinmaz>(_tasinmazDal.Get(t => t.nbID == id));
        }

        public IDataResult<Tasinmaz> GetByNitelik(string nitelik)
        {
            return new SuccessDataResult<Tasinmaz>(_tasinmazDal.Get(t => t.nitelik == nitelik));
        }

        public IDataResult<Tasinmaz> GetByParsel(int parsel)
        {
            return new SuccessDataResult<Tasinmaz>(_tasinmazDal.Get(t => t.parsel == parsel));
        }

        public IDataResult<Tasinmaz> GetByProvinceID(int id)
        {
            return new SuccessDataResult<Tasinmaz>(_tasinmazDal.Get(t => t.provinceID == id));
        }

        public IDataResult<Tasinmaz> GetByuserID(int uID)
        {
            return new SuccessDataResult<Tasinmaz>(_tasinmazDal.Get(t => t.uID == uID));
        }

        public Tasinmaz GetUserById(int id)
        {
            return _tasinmazDal.GetTasinmazById(id);
        }

       
    }
}

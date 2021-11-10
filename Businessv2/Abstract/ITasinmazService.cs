using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ITasinmazService
    {
        IResult Add(Tasinmaz tasinmaz);
        IResult Update(int id, Tasinmaz tasinmaz);
        void DeleteTasinmaz(int id);
        IDataResult<List<Tasinmaz>> GetAll();
        IDataResult<Tasinmaz> GetBytID(int id);
        IDataResult<Tasinmaz> GetByProvinceID(int id);
        //IDataResult<Tasinmaz> GetByCountryID(int id);
        IDataResult<Tasinmaz> GetBynbID(int id);
        IDataResult<Tasinmaz> GetByAda(int ada);
        IDataResult<Tasinmaz> GetByParsel(int parsel);
        IDataResult<Tasinmaz> GetByNitelik(string nitelik);
        IDataResult<Tasinmaz> GetByKoordinatX(string x);
        IDataResult<Tasinmaz> GetByKoordinatY(string y);
        //IDataResult<Tasinmaz> GetByuserID(int uID);
        
    }
}

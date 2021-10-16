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
        IDataResult<List<Tasinmaz>> GetAll();
        IDataResult<Tasinmaz> GetBytID(int id);
        IDataResult<Tasinmaz> GetByProvinceID(int id);
        IDataResult<Tasinmaz> GetByCountryID(int id);
        IDataResult<Tasinmaz> GetBynbID(int id);


        IDataResult<Tasinmaz> GetByAda(int ada);
        IDataResult<Tasinmaz> GetByParsel(int parsel);
        IDataResult<Tasinmaz> GetByNitelik(string nitelik);
        IDataResult<Tasinmaz> GetByKoordinatX(int x);
        IDataResult<Tasinmaz> GetByKoordinatY(int y);
        IResult Update(Tasinmaz tasinmaz);
        IDataResult<Tasinmaz> GetByuserID(int uID);
    }
}

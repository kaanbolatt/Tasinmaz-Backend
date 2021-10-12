using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ITasinmazService
    {
        List<Tasinmaz> GetAll();
        List<Tasinmaz> GetAllByID(int id);
        List<Tasinmaz> GetAllByProvinceID(int id);
        List<Tasinmaz> GetAllByCountryID(int id);
        List<Tasinmaz> GetAllBynbID(int id);
        List<Tasinmaz> GetAllByUserID(int id);
        List<Tasinmaz> GetAllByAda(int ada);
        List<Tasinmaz> GetAllByParsel(int parsel);
        List<Tasinmaz> GetAllByNitelik(string nitelik);
        List<Tasinmaz> GetAllByKoordinatX(int x);
        List<Tasinmaz> GetAllByKoordinatY(int y);
        
    }
}

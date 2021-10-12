using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class NeighbourhoodsManager : INeighbourhoodsService
    {
        INeighbourhoodsDal neighbourDal;
        public NeighbourhoodsManager(INeighbourhoodsDal neighboursDal)
        {
            neighbourDal = neighboursDal;
        }
        
        public List<Neighbourhoods> GetAll()
        {
            //iş kodları
            //yetkisi var mı?
            return neighbourDal.GetAll();
        }

        public List<Neighbourhoods> GetAllByCountryID(int id)
        {
            return neighbourDal.GetAll(n => n.countryID == id);
        }

        public List<Neighbourhoods> GetAllByID(int id)
        {
            return neighbourDal.GetAll(n => n.nbID == id);
        }

        public List<Neighbourhoods> GetAllByName(string name)
        {
            return neighbourDal.GetAll(n => n.nbName == name);
        }
    }
}

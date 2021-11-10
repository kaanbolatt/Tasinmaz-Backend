using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfTasinmazDal : EfEntityRepositoryBase<Tasinmaz, TasinmazContext>, ITasinmazDal
    {   
        
        public void DeleteTasinmaz(int id)
        {
            using (TasinmazContext context = new TasinmazContext())
            {
                var deletedTasinmaz = GetTasinmazById(id);
                context.Tasinmaz.Remove(deletedTasinmaz);
                context.SaveChanges();
            }
        }

        public Tasinmaz GetTasinmazById(int id)
        {
            using (TasinmazContext context = new TasinmazContext())
            {
                return context.Tasinmaz.Find(id);
            }
        }



        public void UpdateTasinmaz(int id, Tasinmaz tasinmaz)
        {
            using (TasinmazContext context = new TasinmazContext())
            {

                var itemToUpdate = context.Tasinmaz.Find(id);

                if (itemToUpdate == null)
                    throw new NullReferenceException();

                //itemToUpdate.provinceID = tasinmaz.provinceID;
                //itemToUpdate.countryID = tasinmaz.countryID;
                itemToUpdate.NeighbourhoodsId = tasinmaz.NeighbourhoodsId;
                itemToUpdate.Ada = tasinmaz.Ada;
                itemToUpdate.Parsel = tasinmaz.Parsel;
                itemToUpdate.Nitelik = tasinmaz.Nitelik;
                itemToUpdate.KoordinatX = tasinmaz.KoordinatX;
                itemToUpdate.KoordinatY = tasinmaz.KoordinatY;
                context.Tasinmaz.Update(itemToUpdate);
                context.SaveChanges();
            }
        }

        public void addTasinmaz(Tasinmaz tasinmaz)
        {
            using (TasinmazContext context = new TasinmazContext())
            {
                context.Tasinmaz.Add(tasinmaz);
                context.SaveChanges();
                

            }
        }

        public List<Tasinmaz> AllTasinmaz()
        {
            using (TasinmazContext context = new TasinmazContext())
            {
                return context.Tasinmaz.Include(x => x.Neighbourhoods).ThenInclude(c=> c.Countries).ThenInclude(g=> g.Province).ToList();
                //ThenInclude(c => c.Countries).ThenInclude(o => o.Provinces)

            }
        }
        //void ITasinmazDal.GetAllin(int id)
        //{
        //    using (TasinmazContext context = new TasinmazContext())
        //    {
        //        var Xtasinmaz = context.Tasinmaz.Include(q => q.Nb).ThenInclude(it => it.nbID);
        //        //return Xtasinmaz;
        //    }
        //}
    }
}

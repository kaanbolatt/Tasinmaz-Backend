using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;

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

                itemToUpdate.provinceID = tasinmaz.provinceID;
                itemToUpdate.countryID = tasinmaz.countryID;
                itemToUpdate.nbID = tasinmaz.nbID;
                itemToUpdate.ada = tasinmaz.ada;
                itemToUpdate.parsel = tasinmaz.parsel;
                itemToUpdate.nitelik = tasinmaz.nitelik;
                itemToUpdate.koordinatX = tasinmaz.koordinatX;
                itemToUpdate.koordinatY = tasinmaz.koordinatY;
                context.Tasinmaz.Update(itemToUpdate);
                context.SaveChangesAsync();
            }
        }
    }
}

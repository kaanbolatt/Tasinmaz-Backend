using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfLogsDal : EfEntityRepositoryBase<Logs, TasinmazContext>, IlogDal
    {
        public void DeleteLog(int id)
        {
            using (TasinmazContext context = new TasinmazContext())
            {
                var deletedLog = GetLogById(id);
                context.Logs.Remove(deletedLog);
                context.SaveChanges();
            }
        }
        public Logs GetLogById(int id)
        {
            using (TasinmazContext context = new TasinmazContext())
            {
                return context.Logs.Find(id);
            }
        }
        public void addLog(Logs logs)
        {
            using (TasinmazContext context = new TasinmazContext())
            {
                context.Logs.Add(logs);
                context.SaveChanges();


            }
        }
    }
}

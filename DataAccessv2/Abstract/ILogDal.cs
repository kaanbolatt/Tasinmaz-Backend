using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IlogDal : IEntityRepository<Logs>
    {
        void DeleteLog(int id);
        Logs GetLogById(int id);
    }
}

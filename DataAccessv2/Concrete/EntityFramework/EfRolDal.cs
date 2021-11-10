using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRolDal : EfEntityRepositoryBase<Rol,TasinmazContext>, IRolDal
    {
       
    }
}

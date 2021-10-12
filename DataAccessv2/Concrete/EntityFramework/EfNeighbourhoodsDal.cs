using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfNeighbourhoodsDal : EfEntityRepositoryBase<Neighbourhoods, TasinmazContext>, INeighbourhoodsDal
    {
    }
}

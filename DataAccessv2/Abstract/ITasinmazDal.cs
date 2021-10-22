using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ITasinmazDal : IEntityRepository<Tasinmaz>
    {
        void DeleteTasinmaz(int id);
        Tasinmaz GetTasinmazById(int id);
        void UpdateTasinmaz(int id, Tasinmaz tasinmaz);



    }
}

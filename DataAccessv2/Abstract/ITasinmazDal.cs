using Core.DataAccess;
using Core.Utilities.Results;
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
        //object Tasinmaz { get; }y

        void DeleteTasinmaz(int id);
        Tasinmaz GetTasinmazById(int id);
        void UpdateTasinmaz(int id, Tasinmaz tasinmaz);
        void addTasinmaz(Tasinmaz tasinmaz);

        List<Tasinmaz> AllTasinmaz();


        //void GetAllin(int id);



    }
}

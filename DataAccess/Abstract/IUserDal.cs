using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IUserDal
    {
        List<Users> GetAll();

        void Add(Users user);
        void Update(Users user);
        void Delete(Users user);

    }
}

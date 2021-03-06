using Core.DataAccess;
using Core.Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<Rol> GetClaims(User user);
        List<UserDetailDto> GetUserDetails();
        void DeleteUser(int id);
        User GetUserById(int id);
        void UpdateUser(int id, User user);

    }
}

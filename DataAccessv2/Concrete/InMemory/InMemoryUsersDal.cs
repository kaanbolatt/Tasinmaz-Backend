using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryUsersDal : IUserDal
    {
        List<User> users;
        public InMemoryUsersDal()
        {
            users = new List<User> {
                new User { uID = 1, uName = "Kaan", uSurname = "Bolat", uMail = "h2okaan@gmail.com", uAdress = "Çayyolu", uNumber = 2412, uRole = 1 }
            };
        }
        public void Add(User user)
        {
                users.Add(user);
        }

        public void Delete(User user)
        {
            //LINQ - Language Integrated Query
            User usersToDelete = users.SingleOrDefault(p=>p.uID == user.uID);
            users.Remove(usersToDelete);
        }

        public User Get(Expression<Func<User, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            return users;
        }

        public List<User> GetAll(Expression<Func<User, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(User user)
        {
            User userToUpdate = users.SingleOrDefault(p => p.uID == user.uID);
            userToUpdate.uName = user.uName;
            userToUpdate.uSurname = user.uSurname;
            userToUpdate.uMail = user.uMail;
            userToUpdate.uNumber = user.uNumber;
            userToUpdate.uRole = user.uRole;
            userToUpdate.uAdress = user.uAdress;

        }

    }
}

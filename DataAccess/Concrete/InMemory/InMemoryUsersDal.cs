using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryUsersDal : IUserDal
    {
        List<Users> users;
        public InMemoryUsersDal()
        {
            users = new List<Users> {
                new Users { uID = 1, uName = "Kaan", uSurname = "Bolat", uMail = "h2okaan@gmail.com", uAdress = "Çayyolu", uNumber = "5377146776", uRole = "1" }
            };
        }
        public void Add(Users user)
        {
                users.Add(user);
        }

        public void Delete(Users user)
        {
            //LINQ - Language Integrated Query
            Users usersToDelete = users.SingleOrDefault(p=>p.uID == user.uID);
            users.Remove(usersToDelete);
        }

        public List<Users> GetAll()
        {
            return users;
        }

        public void Update(Users user)
        {
            Users userToUpdate = users.SingleOrDefault(p => p.uID == user.uID);
            userToUpdate.uName = user.uName;
            userToUpdate.uSurname = user.uSurname;
            userToUpdate.uMail = user.uMail;
            userToUpdate.uNumber = user.uNumber;
            userToUpdate.uRole = user.uRole;
            userToUpdate.uAdress = user.uAdress;

        }

    }
}

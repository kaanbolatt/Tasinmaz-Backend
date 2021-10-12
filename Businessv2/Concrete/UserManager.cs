using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal usersDal;
        public UserManager(IUserDal userDal)
        {
            usersDal = userDal;
        }
        
        public List<User> GetAll()
        {
            //iş kodları
            //yetkisi var mı?
            return usersDal.GetAll();
        }

        public List<User> GetAllByAdress(string adress)
        {
            return usersDal.GetAll(p => p.uAdress == adress);
        }

        public List<User> GetAllByMail(string mail)
        {
            return usersDal.GetAll(p => p.uMail == mail);
        }

        public List<User> GetAllByName(string name)
        {
            return usersDal.GetAll(p => p.uName == name);
        }

        public List<User> GetAllByNumber(int number)
        {
            return usersDal.GetAll(p => p.uNumber == number);
        }

        public List<User> GetAllByRole(int role)
        {
            return usersDal.GetAll(p => p.uRole == role);
        }

        public List<User> GetAllBySurname(string surname)
        {
            return usersDal.GetAll(p => p.uSurname == surname);
        }

        public List<User> GetAllByuserID(int id)
        {
            return usersDal.GetAll(p=>p.uID==id);
        }
    }
}

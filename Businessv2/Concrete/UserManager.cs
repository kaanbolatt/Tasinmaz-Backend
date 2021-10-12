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
            return usersDal.GetAll(u => u.uAdress == adress);
        }

        public List<User> GetAllByMail(string mail)
        {
            return usersDal.GetAll(u => u.uMail == mail);
        }

        public List<User> GetAllByName(string name)
        {
            return usersDal.GetAll(u => u.uName == name);
        }

        public List<User> GetAllByNumber(int number)
        {
            return usersDal.GetAll(u => u.uNumber == number);
        }

        public List<User> GetAllByRole(int role)
        {
            return usersDal.GetAll(u => u.uRole == role);
        }

        public List<User> GetAllBySurname(string surname)
        {
            return usersDal.GetAll(u => u.uSurname == surname);
        }

        public List<User> GetAllByuserID(int id)
        {
            return usersDal.GetAll(u=>u.uID==id);
        }
    }
}

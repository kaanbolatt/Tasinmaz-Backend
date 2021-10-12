using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<User> GetAll();
        List<User> GetAllByName(string name);
        List<User> GetAllByuserID(int id);
        List<User> GetAllBySurname(string surname);
        List<User> GetAllByMail(string mail);
        List<User> GetAllByRole(int role);
        List<User> GetAllByNumber(int number);
        List<User> GetAllByAdress(string adress);

    }
}

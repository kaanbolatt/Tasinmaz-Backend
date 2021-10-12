using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        //List<User> GetAll();
        IDataResult<List<User>> GetAllByName(string name);
        IDataResult<List<User>> GetAllByuserID(int id);
        IDataResult<List<User>> GetAllBySurname(string surname);
        IDataResult<List<User>> GetAllByMail(string mail);
        IDataResult<List<User>> GetAllByRole(int role);
        IDataResult<List<User>> GetAllByNumber(int number);
        IDataResult<List<User>> GetAllByAdress(string adress);
        IDataResult<List<UserDetailDto>> GetUserDetails();

        IResult Add(User user);
        IDataResult<User> GetById(int userID);

    }
}

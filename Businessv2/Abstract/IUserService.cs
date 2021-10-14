using Core.Entities.Concrete;
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

            List<OperationClaim> GetClaims(User user);
            void Add(User user);

        IDataResult<List<User>> GetAll();
        //List<User> GetAll();
        IResult AddTransactionalTest(User user);
        IDataResult<List<User>> GetAllByName(string name);
        IDataResult<List<User>> GetAllByID(int id);
        IDataResult<List<User>> GetAllBySurname(string surname);
        IDataResult<List<User>> GetAllByMail(string mail);
        IDataResult<List<User>> GetAllByNumber(int number);
        IDataResult<List<User>> GetAllByAdress(string adress);
        IDataResult<List<UserDetailDto>> GetUserDetails();
        IResult Addd(User user);
        IResult Update(User user);
        User GetByMail(string email);
    }
}

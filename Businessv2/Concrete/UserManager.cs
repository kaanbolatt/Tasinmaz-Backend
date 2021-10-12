using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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

        public IResult Add(User user)
        {
            if (user.uName.Length < 6)
            {
                //magic string
                return new ErrorResult(Messages.UserNameInvalid);
            }
            //business codes. eklemeden önceki kurallar buraya yazılır.
            usersDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

        public IDataResult<List<User>> GetAll()
        {
            if(DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult();
            }
            return new SuccessDataResult<List<User>>(usersDal.GetAll(),true,"Üyeler listelendi.");
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

        public User GetById(int userID)
        {
            return usersDal.Get(u=>u.uID == userID);
        }

        public List<UserDetailDto> GetUserDetails()
        {
            return usersDal.GetUserDetails();
        }
    }
}

using Business.Abstract;
using Business.CCS;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _usersDal;
        IProvincesService _provinceService;

        public UserManager(IUserDal userDal, IProvincesService provinceService)
        {
            _usersDal = userDal;
            _provinceService = provinceService;

        }
        [ValidationAspect(typeof(UserValidator))]
        public IResult Add(User user)
        {
            //mail adresi varsa eklenemez.
            //10dan fazla üye eklenemez.
            IResult result = BusinessRules.Run(CheckUserCount(user.uID),
                CheckUserMail(user.uMail));


            if (result != null)
            {
                return result;
            }
            _usersDal.Add(user);
            return new SuccessResult(Messages.UserAdded);

        }


        public IDataResult<List<User>> GetAll()
        {
            //if(DateTime.Now.Hour == 22)
            //{
            //    return new ErrorDataResult<List<User>>(Messages.MaintenanceTime);
            //}
            return new SuccessDataResult<List<User>>(_usersDal.GetAll(),Messages.UserListed);
        }

        public IDataResult<List<User>> GetAllByAdress(string adress)
        {
            return new SuccessDataResult<List<User>>(_usersDal.GetAll(u => u.uAdress == adress));
        }

        public IDataResult<List<User>> GetAllByMail(string mail)
        {
            return new SuccessDataResult<List<User>>(_usersDal.GetAll(u => u.uMail == mail));
        }

        public IDataResult<List<User>> GetAllByName(string name)
        {
            return new SuccessDataResult<List<User>>(_usersDal.GetAll(u => u.uName == name));
        }

        public IDataResult<List<User>> GetAllByNumber(int number)
        {
            return new SuccessDataResult<List<User>>(_usersDal.GetAll(u => u.uNumber == number));
        }

        public IDataResult<List<User>> GetAllByRole(int role)
        {
            return new SuccessDataResult<List<User>>(_usersDal.GetAll(u => u.uRole == role));
        }

        public IDataResult<List<User>> GetAllBySurname(string surname)
        {
            return new SuccessDataResult<List<User>>(_usersDal.GetAll(u => u.uSurname == surname));
        }

        public IDataResult<List<User>> GetAllByuserID(int id)
        {
            return new SuccessDataResult<List<User>>(_usersDal.GetAll(u=>u.uID==id));
        }

        public IDataResult<User> GetById(int userID)
        {
            return new SuccessDataResult<User>(_usersDal.Get(u=>u.uID == userID));
        }

        public IDataResult<List<UserDetailDto>> GetUserDetails()
        {
            //if (DateTime.Now.Hour == 11)
            //{
            //    return new ErrorDataResult<List<UserDetailDto>>(Messages.MaintenanceTime);
            //}
            return new SuccessDataResult<List<UserDetailDto>>(_usersDal.GetUserDetails());
        }
        [ValidationAspect(typeof(UserValidator))]
        public IResult Update(User user)
        {   
            var result = _usersDal.GetAll(u => u.uID == user.uID).Count;
            if (result >= 10)
            {
                return new ErrorResult(Messages.UserCountError);
            }
            throw new NotImplementedException();
        }
        private IResult CheckUserCount(int userID)
        {
            var result = _usersDal.GetAll(u => u.uID == userID).Count;
            if (result >= 10)
            {
                return new ErrorResult(Messages.UserCountError);
            }
            return new SuccessResult();
        }
        private IResult CheckUserMail(string mail)
        {
            var result = _usersDal.GetAll(u => u.uMail == mail).Any();
            if (result)
            {
                return new ErrorResult(Messages.UserMailAlreadyExist);
            }
            return new SuccessResult();
        }
    }
}

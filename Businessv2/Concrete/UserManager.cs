using Business.Abstract;
using Business.BusinessAspects.AutoFac;
using Business.CCS;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Entities.Concrete;
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
        IUserDal _userDal;
        IProvincesService _provinceService;

        public UserManager(IUserDal userDal ,IProvincesService provinceService)
        {
            _userDal = userDal;
            _provinceService = provinceService;
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.uMail == email);
        }




        //[SecuredOperation("user.add")]
        [ValidationAspect(typeof(UserValidator))]
        [CacheRemoveAspect("IUserService.Get")]
        public IResult Addd(User user)
        {
            IResult result = BusinessRules.Run(CheckUserCount(user.uID),
                CheckUserMail(user.uMail),
                CheckIfProvinceLimitExceded());

            if (result != null)
            {
                return result;
            }
            _userDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

        [ValidationAspect(typeof(UserValidator))]
        [CacheRemoveAspect("IUserService.Get")]
        public IResult Update(User user)
        {
            IResult result = BusinessRules.Run(CheckUserCount(user.uID),
                CheckUserMail(user.uMail),
                CheckIfProvinceLimitExceded());

            if (result != null)
            {
                return result;
            }
            _userDal.Update(user);
            return new SuccessResult(Messages.UserAdded);
        }

        [CacheAspect] //key,value
        public IDataResult<List<User>> GetAll()
        {
            //if(DateTime.Now.Hour == 22)
            //{
            //    return new ErrorDataResult<List<User>>(Messages.MaintenanceTime);
            //}
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.UserListed);
        }

        public IDataResult<List<User>> GetAllByAdress(string adress)
        {
            return new SuccessDataResult<List<User>> (_userDal.GetAll(u => u.uAdress == adress));
        }

        public IDataResult<List<User>> GetAllByMail(string mail)
        {
            return new SuccessDataResult<List<User>> (_userDal.GetAll(u => u.uMail == mail));
        }

        public IDataResult<List<User>> GetAllByName(string name)
        {
            return new SuccessDataResult<List<User>> (_userDal.GetAll(u => u.uName == name));
        }

        public IDataResult<List<User>> GetAllBySurname(string surname)
        {
            return new SuccessDataResult<List<User>> (_userDal.GetAll(u => u.uSurname == surname));
        }
        [CacheAspect]   
        [PerformanceAspect(5)]
        public IDataResult<List<User>> GetAllByID(int userID)
        {
            return new SuccessDataResult<List<User>> (_userDal.GetAll(u => u.uID == userID));
        }

        public IDataResult<List<UserDetailDto>> GetUserDetails()
        {
            //if (DateTime.Now.Hour == 11)
            //{
            //    return new ErrorDataResult<List<UserDetailDto>>(Messages.MaintenanceTime);
            //}
            return new SuccessDataResult<List<UserDetailDto>>(_userDal.GetUserDetails());
        }


        private IResult CheckUserCount(int userID)
        {
            var result = _userDal.GetAll(u => u.uID == userID).Count;
            if (result >= 10)
            {
                return new ErrorResult(Messages.UserCountError);
            }
            return new SuccessResult();
        }
        private IResult CheckUserMail(string mail)
        {
            var result = _userDal.GetAll(u => u.uMail == mail).Any();
            if (result)
            {
                return new ErrorResult(Messages.UserMailAlreadyExist);
            }
            return new SuccessResult();
        }
        private IResult CheckPassword(string password)
        {
            string specialChar = "é<!>'£^#+$%½&/{([)]=}?_-|~@;,.:*";
            string capitalLetter = "QWERTYUIOPĞÜİŞLKJHGFDSAZXCVBNMÖÇ";
            string smallLetter = "qwertyuıopğüişlkjhgfdsazxcvbnmöç";
            string number = "1234567890";
            bool specialCharIsExist = false;
            bool capitalLetterIsExist = false;
            bool smallLetterIsExist = false;
            bool numberIsExist = false;
            if (password.Length < 8)
            {
                return new ErrorResult(Messages.PasswordLengthError);
            }
            else
            {
                foreach (char item in password)
                {
                    if (capitalLetter.IndexOf(item) != -1)
                    {
                        capitalLetterIsExist = true;
                    }
                    if (specialChar.IndexOf(item) != -1)
                    {
                        specialCharIsExist = true;
                    }
                    if (smallLetter.IndexOf(item) != -1)
                    {
                        smallLetterIsExist = true;
                    }
                    if (number.IndexOf(item) != -1)
                    {
                        numberIsExist = true;
                    }
                }
            }
            if (capitalLetterIsExist == true && specialCharIsExist == true && smallLetterIsExist == true && numberIsExist == true)
            {
                return new SuccessResult();
            }
            return new ErrorResult(Messages.PasswordRules);
        }
        private IResult CheckIfProvinceLimitExceded()
        {
            var result = _provinceService.GetAll();
            if (result.Data.Count > 15)
            {
                return new ErrorResult(Messages.ProvinceLimitExceded);
            }
            return new SuccessResult();
        }
    }
}

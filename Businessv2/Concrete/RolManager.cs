using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RolManager : IRolService
    {
        IRolDal _rolDal;
        public RolManager(IRolDal rolDal)
        {
            _rolDal = rolDal;
        }

        public IDataResult<List<Rol>> GetAll()
        {
            return new SuccessDataResult<List<Rol>>(_rolDal.GetAll());
        }
    }
}

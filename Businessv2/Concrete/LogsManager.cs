using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class LogsManager : ILogService
    {
        IlogDal logDal;
        public LogsManager(IlogDal logsDal)
        {
            logDal = logsDal;
        }
        
        public IDataResult<List<Logs>> GetAll()
        {
            //iş kodları
            //yetkisi var mı?
            return new SuccessDataResult<List<Logs>>(logDal.GetAll());
        }

        public IDataResult<Logs> GetByDate(string date)
        {
            return new SuccessDataResult<Logs>(logDal.Get(l => l.logDate == date));
        }

        public IDataResult<Logs> GetByExp(string exp)
        {
            return new SuccessDataResult<Logs>(logDal.Get(l => l.logExp == exp));
        }

        public IDataResult<Logs> GetByID(int id)
        {
            return new SuccessDataResult<Logs>(logDal.Get(l => l.logID == id));
        }

        public IDataResult<Logs> GetByIP(int ip)
        {
            return new SuccessDataResult<Logs>(logDal.Get(l => l.uIP == ip));
        }

        public IDataResult<Logs> GetByStatus(string status)
        {
            return new SuccessDataResult<Logs>(logDal.Get(l => l.logStatus == status));
        }

        public IDataResult<Logs> GetByType(string type)
        {
            return new SuccessDataResult<Logs>(logDal.Get(l => l.logType == type));
        }

        public IDataResult<Logs> GetByUserID(int id)
        {
            return new SuccessDataResult<Logs>(logDal.Get(l => l.uID == id));
        }
    }
}

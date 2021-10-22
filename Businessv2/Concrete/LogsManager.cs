using Business.Abstract;
using Business.Constants;
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
        IlogDal _logDal;
        public LogsManager(IlogDal logsDal)
        {
            _logDal = logsDal;
        }

        public void DeleteLog(int id)
        {
            _logDal.DeleteLog(id);
        }

        public IDataResult<List<Logs>> GetAll()
        {
            //iş kodları
            //yetkisi var mı?
            return new SuccessDataResult<List<Logs>>(_logDal.GetAll(), Messages.logListed);
        }

        public IDataResult<Logs> GetByDate(string date)
        {
            return new SuccessDataResult<Logs>(_logDal.Get(l => l.logDate == date));
        }

        public IDataResult<Logs> GetByExp(string exp)
        {
            return new SuccessDataResult<Logs>(_logDal.Get(l => l.logExp == exp));
        }

        public IDataResult<Logs> GetByID(int id)
        {
            return new SuccessDataResult<Logs>(_logDal.Get(l => l.logID == id));
        }

        public IDataResult<Logs> GetByIP(int ip)
        {
            return new SuccessDataResult<Logs>(_logDal.Get(l => l.uIP == ip));
        }

        public IDataResult<Logs> GetByStatus(string status)
        {
            return new SuccessDataResult<Logs>(_logDal.Get(l => l.logStatus == status));
        }

        public IDataResult<Logs> GetByType(string type)
        {
            return new SuccessDataResult<Logs>(_logDal.Get(l => l.logType == type));
        }

        public IDataResult<Logs> GetByUserID(int id)
        {
            return new SuccessDataResult<Logs>(_logDal.Get(l => l.uID == id));
        }
    }
}

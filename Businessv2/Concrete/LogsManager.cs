using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

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
        public IResult Add(Logs logs)
        {
            _logDal.Add(logs);
            return new SuccessResult(Messages.LogsAdded);
        }

        public IDataResult<List<Logs>> GetAll()
        {
            //iş kodları
            //yetkisi var mı?
            
                //iş kodları
                //yetkisi var mı?
            return new SuccessDataResult<List<Logs>>(_logDal.GetAll(), Messages.logListed);
        }

        public IDataResult<Logs> GetByDate(string date)
        {
            return new SuccessDataResult<Logs>(_logDal.Get(l => l.LogDate == date));
        }

        public IDataResult<Logs> GetByExp(string exp)
        {
            return new SuccessDataResult<Logs>(_logDal.Get(l => l.LogExp == exp));
        }

        public IDataResult<Logs> GetByID(int id)
        {
            return new SuccessDataResult<Logs>(_logDal.Get(l => l.Id == id));
        }

        public IDataResult<Logs> GetByIP(string ip)
        {
            return new SuccessDataResult<Logs>(_logDal.Get(l => l.LogIp == ip));
        }

        public IDataResult<Logs> GetByStatus(string status)
        {
            return new SuccessDataResult<Logs>(_logDal.Get(l => l.LogStatus == status));
        }

        public IDataResult<Logs> GetByType(string type)
        {
            return new SuccessDataResult<Logs>(_logDal.Get(l => l.LogType == type));
        }

        public IDataResult<Logs> GetByUserID(int id)
        {
            return new SuccessDataResult<Logs>(_logDal.Get(l => l.UserId == id));
        }
    }
}

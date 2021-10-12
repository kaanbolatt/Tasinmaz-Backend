using Business.Abstract;
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
        
        public List<Logs> GetAll()
        {
            //iş kodları
            //yetkisi var mı?
            return logDal.GetAll();
        }

        public List<Logs> GetAllByDate(string date)
        {
            return logDal.GetAll(p => p.logDate == date);
        }

        public List<Logs> GetAllByExp(string exp)
        {
            return logDal.GetAll(p => p.logExp == exp);
        }

        public List<Logs> GetAllByID(int id)
        {
            return logDal.GetAll(p => p.logID == id);
        }

        public List<Logs> GetAllByIP(int ip)
        {
            return logDal.GetAll(p => p.uIP == ip);
        }

        public List<Logs> GetAllByStatus(string status)
        {
            return logDal.GetAll(p => p.logStatus == status);
        }

        public List<Logs> GetAllByType(string type)
        {
            return logDal.GetAll(p => p.logType == type);
        }

        public List<Logs> GetAllByUserID(int id)
        {
            throw new NotImplementedException();
        }
    }
}

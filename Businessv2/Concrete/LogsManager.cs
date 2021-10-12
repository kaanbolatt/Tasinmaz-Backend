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
            return logDal.GetAll(l => l.logDate == date);
        }

        public List<Logs> GetAllByExp(string exp)
        {
            return logDal.GetAll(l => l.logExp == exp);
        }

        public List<Logs> GetAllByID(int id)
        {
            return logDal.GetAll(l => l.logID == id);
        }

        public List<Logs> GetAllByIP(int ip)
        {
            return logDal.GetAll(l => l.uIP == ip);
        }

        public List<Logs> GetAllByStatus(string status)
        {
            return logDal.GetAll(l => l.logStatus == status);
        }

        public List<Logs> GetAllByType(string type)
        {
            return logDal.GetAll(l => l.logType == type);
        }

        public List<Logs> GetAllByUserID(int id)
        {
            return logDal.GetAll(l => l.uID == id);
        }
    }
}

using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ILogService
    {
        List<Logs> GetAll();
        List<Logs> GetAllByID(int id);
        List<Logs> GetAllByStatus(string status);
        List<Logs> GetAllByType(string type);
        List<Logs> GetAllByUserID(int id);
        List<Logs> GetAllByDate(string date);
        List<Logs> GetAllByExp(string exp);
        List<Logs> GetAllByIP(int ip);
        
    }
}

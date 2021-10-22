using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ILogService
    {
        IDataResult<List<Logs>> GetAll();
        IDataResult<Logs> GetByID(int id);
        IDataResult<Logs> GetByStatus(string status);
        IDataResult<Logs> GetByType(string type);
        IDataResult<Logs> GetByUserID(int id);
        IDataResult<Logs> GetByDate(string date);
        IDataResult<Logs> GetByExp(string exp);
        IDataResult<Logs> GetByIP(int ip);

        void DeleteLog(int id);

    }
}

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            UserMethod();
            CountryMethod();
            LogMethod();
            ProvinceMethod();
            NeighbourMethod();
            TasinmazMethod();
        }

        private static void TasinmazMethod()
        {
            TasinmazManager tasinmazsManager = new TasinmazManager(new EfTasinmazDal());
            foreach (var tasinmaz in tasinmazsManager.GetAll())
            {
                Console.WriteLine("[TASINMAZ]\ntID:" + tasinmaz.tID + " | Province ID: " + tasinmaz.provinceID + " | Country ID: " + tasinmaz.countryID + " | Neighbourhood ID: "
                    + tasinmaz.nbID + " | User ID: " + tasinmaz.uID + " | Ada: " + tasinmaz.ada + " | Parsel: " + tasinmaz.parsel + " | Nitelik: " + tasinmaz.nitelik + " | Koordinat X: "
                    + tasinmaz.koordinatX + " | Koordinat Y: " + tasinmaz.koordinatY);
            }
        }

        private static void NeighbourMethod()
        {
            NeighbourhoodsManager neighbourhoodsManager = new NeighbourhoodsManager(new EfNeighbourhoodsDal());
            foreach (var neighbourhoods in neighbourhoodsManager.GetAll())
            {
                Console.WriteLine("[NEIGHBOURHOODS]\nNeighbourhoods ID: " + neighbourhoods.nbID + " | Neighbourhoods Name: " + neighbourhoods.nbName + " | Country ID: " + neighbourhoods.countryID);
            }
        }

        private static void ProvinceMethod()
        {
            ProvincesManager provinceManager = new ProvincesManager(new EfProvincesDal());
            foreach (var provinces in provinceManager.GetAll())
            {
                Console.WriteLine("[PROVINCES]\nProvince ID: " + provinces.provinceID + " | Province Name: " + provinces.provinceName);
            }
        }

        private static void LogMethod()
        {
            LogsManager logManager = new LogsManager(new EfLogsDal());
            foreach (var logs in logManager.GetAll())
            {
                Console.WriteLine("[LOGS]\nLog ID: " + logs.logID + " | Log Status: " + logs.logStatus + " | Log Type: " + logs.logType + " | User ID: " + logs.uID + " | Log Date: "
                    + logs.logDate + " | Log Exp: " + logs.logExp + " | Log User IP: " + logs.uIP);
            }
        }

        private static void CountryMethod()
        {
            CountriesManager countriesManager = new CountriesManager(new EfCountriesDal());
            foreach (var country in countriesManager.GetAll())
            {
                Console.WriteLine("[COUNTRIES]\nCountry ID: " + country.countryID + " | Name: " + country.countryName + " | Province ID: " + country.provinceID);
            }
        }

        private static void UserMethod()
        {
            UserManager userManager = new UserManager(new EfUsersDal());
            foreach (var user in userManager.GetAll())
            {
                Console.WriteLine("[USERS]\nID: " + user.uID + " | Name: " + user.uName + " | Surname: " + user.uSurname + " | E-Mail: " + user.uMail + " | Number: " + user.uNumber + " | Role " + user.uRole + " | Adress: " + user.uAdress);
            }
        }
    }
}


using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Core.Utilities.Security.JWT;
using Microsoft.AspNetCore.Http;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<ProvincesManager>().As<IProvincesService>().SingleInstance();
            builder.RegisterType<EfProvincesDal>().As<IProvincesDal>().SingleInstance();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<TasinmazManager>().As<ITasinmazService>();
            builder.RegisterType<EfTasinmazDal>().As<ITasinmazDal>();

            builder.RegisterType<LogsManager>().As<ILogService>();
            builder.RegisterType<EfLogsDal>().As<IlogDal>();

            builder.RegisterType<ProvincesManager>().As<IProvincesService>();
            builder.RegisterType<EfProvincesDal>().As<IProvincesDal>();

            builder.RegisterType<CountriesManager>().As<ICountriesService>();
            builder.RegisterType<EfCountriesDal>().As<ICountriesDal>();

            builder.RegisterType<NeighbourhoodsManager>().As<INeighbourhoodsService>();
            builder.RegisterType<EfNeighbourhoodsDal>().As<INeighbourhoodsDal>();

            builder.RegisterType<RolManager>().As<IRolService>();
            builder.RegisterType<EfRolDal>().As<IRolDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();


            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}

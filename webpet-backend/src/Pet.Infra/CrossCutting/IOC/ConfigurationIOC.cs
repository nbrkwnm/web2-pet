using Autofac;
using Pet.Application;
using Pet.Application.Interfaces;
using Pet.Application.Interfaces.Mappers;
using Pet.Application.Mappers;
using Pet.Domain.Core.Interfaces.Repositories;
using Pet.Domain.Core.Interfaces.Services;
using Pet.Domain.Services;
using Pet.Infrastructure.Data.Repositories;

namespace Pet.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<UserApplicationService>().As<IUserApplicationService>();
            builder.RegisterType<UserService>().As<IUserService>();
            builder.RegisterType<UserRepository>().As<IUserRepository>();
            builder.RegisterType<UserMapper>().As<IUserMapper>();
            #endregion
        }
    }
}
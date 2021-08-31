using Autofac;
using AutoMapper;
using Pet.Application;
using Pet.Application.Dtos;
using Pet.Application.Interfaces;
using Pet.Application.Mappers;
using Pet.Application.Mappers.User;
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

            builder.Register(ctx => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DtoToModelUserMapping());
                cfg.AddProfile(new ModelToDtoUserMapping());
            }));

            builder.Register(ctx => ctx.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>()
                .InstancePerLifetimeScope();

            #endregion
        }
    }
}
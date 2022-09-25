using Autofac;
using ATSRestApi.Application;
using ATSRestApi.Application.Interfaces;
using ATSRestApi.Application.Interfaces.Mappers;
using ATSRestApi.Application.Mappers;
using ATSRestApi.Domain.Core.Interfaces.Repositories;
using ATSRestApi.Domain.Core.Interfaces.Services;
using ATSRestApi.Domain.Services;
using ATSRestApi.Infrastructure.Data.Repositories;

namespace ATSRestApi.Infrastructure.CrossCuting.IOC
{
  public class ConfigurationIOC
  {
    public static void Load(ContainerBuilder builder)
    {

      #region IOC

      builder.RegisterType<ApplicationServiceCandidato>().As<IApplicationServiceCandidato>();
      builder.RegisterType<ApplicationServiceCurriculo>().As<IApplicationServiceCurriculo>();
      builder.RegisterType<ServiceCandidato>().As<IServiceCandidato>();
      builder.RegisterType<ServiceCurriculo>().As<IServiceCurriculo>();
      builder.RegisterType<RepositoryCanditato>().As<IRepositoryCandidato>();
      builder.RegisterType<RepositoryCurriculo>().As<IRepositoryCurriculo>();
      builder.RegisterType<MapperCandidato>().As<IMapperCandidato>();
      builder.RegisterType<MapperCurriculo>().As<IMapperCurriculo>();

      #endregion
    }
  }
}

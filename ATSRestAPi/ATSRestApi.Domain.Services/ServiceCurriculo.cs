using ATSRestApi.Domain.Core.Interfaces.Repositories;
using ATSRestApi.Domain.Core.Interfaces.Services;
using ATSRestApi.Domain.Entities;

namespace ATSRestApi.Domain.Services
{
  public class ServiceCurriculo: ServiceBase<Curriculo>, IServiceCurriculo
  {
    private readonly IRepositoryCurriculo repositoryCurriculo;

    public ServiceCurriculo(IRepositoryCurriculo repositoryCurriculo)
      :base(repositoryCurriculo)
    {
      this.repositoryCurriculo = repositoryCurriculo;
    }
  }
}

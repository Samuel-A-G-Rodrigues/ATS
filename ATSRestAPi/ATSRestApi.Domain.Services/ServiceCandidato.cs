using ATSRestApi.Domain.Core.Interfaces.Repositories;
using ATSRestApi.Domain.Core.Interfaces.Services;
using ATSRestApi.Domain.Entities;

namespace ATSRestApi.Domain.Services
{
  public class ServiceCandidato: ServiceBase<Candidato>, IServiceCandidato
  {
    private readonly IRepositoryCandidato repositoryCandidato;

    public ServiceCandidato(IRepositoryCandidato repositoryCandidato)
      :base(repositoryCandidato)
    {
      this.repositoryCandidato = repositoryCandidato;
    }
  }
}

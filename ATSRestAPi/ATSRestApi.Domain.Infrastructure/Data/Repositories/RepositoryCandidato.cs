using ATSRestApi.Domain.Core.Interfaces.Repositories;
using ATSRestApi.Domain.Entities;

namespace ATSRestApi.Infrastructure.Data.Repositories
{
  public class RepositoryCanditato : RepositoryBase<Candidato>, IRepositoryCandidato
  {
    private readonly SqlContext sqlContext;

    public RepositoryCanditato(SqlContext sqlContext) : base(sqlContext)
    {
      this.sqlContext = sqlContext;
    }
  }
}

using ATSRestApi.Domain.Core.Interfaces.Repositories;
using ATSRestApi.Domain.Entities;

namespace ATSRestApi.Infrastructure.Data.Repositories
{
  public class RepositoryCurriculo : RepositoryBase<Curriculo>, IRepositoryCurriculo
  {
    private readonly SqlContext sqlContext;

    public RepositoryCurriculo(SqlContext sqlContext) : base(sqlContext)
    {
      this.sqlContext = sqlContext;
    }
  }
}

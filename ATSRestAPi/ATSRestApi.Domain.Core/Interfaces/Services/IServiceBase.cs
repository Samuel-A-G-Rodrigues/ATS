using System.Collections.Generic;

namespace ATSRestApi.Domain.Core.Interfaces.Services
{
  public interface IServiceBase<TEntity> where TEntity : class
  {
    void Add(TEntity obj);

    void Update(TEntity obj);

    void Remove(int id);
    
    IEnumerable<TEntity> GetAll();

    TEntity GetById(int id);
  }
}

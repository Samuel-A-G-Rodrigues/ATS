using ATSRestApi.Domain.Core.Interfaces.Repositories;
using ATSRestApi.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace ATSRestApi.Domain.Services
{
  public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
  {
    private readonly IRepositoryBase<TEntity> repository;

    public ServiceBase(IRepositoryBase<TEntity> repository)
    {
      this.repository = repository;
    }

    public void Add(TEntity obj)
    {
      repository.Add(obj);
    }

    public IEnumerable<TEntity> GetAll()
    {
      return repository.GetAll();
    }

    public TEntity GetById(int id)
    {
      return repository.GetById(id);
    }

    public void Remove(int id)
    {
      repository.Remove(id);
    }

    public void Update(TEntity obj)
    {
      repository.Update(obj);
    }
  }
}

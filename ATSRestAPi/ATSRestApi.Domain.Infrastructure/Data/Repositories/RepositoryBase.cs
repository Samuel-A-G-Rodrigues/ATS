using ATSRestApi.Domain.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATSRestApi.Infrastructure.Data.Repositories
{
  public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
  {
    private readonly SqlContext sqlContext;

    public RepositoryBase(SqlContext sqlContext)
    {
      this.sqlContext = sqlContext;
    }

    public void Add(TEntity obj)
    {
      try
      {
        sqlContext.Set<TEntity>().Add(obj);
        sqlContext.SaveChanges();
      }
      catch (Exception ex)
      {

        throw ex;
      }
    }

    public IEnumerable<TEntity> GetAll()
    {
      return sqlContext.Set<TEntity>().ToList();
    }

    public TEntity GetById(int id)
    {
      return sqlContext.Set<TEntity>().Find(id); ;// detach
    }

    public void Remove(int id)
    {
      try
      {
        //Recupera Entidade
        var entity = GetById(id);
        sqlContext.Entry(entity).State = EntityState.Detached;
        //Remove Entidade
        sqlContext.Set<TEntity>().Remove(entity);
        sqlContext.SaveChanges();
      }
      catch (Exception ex)
      {

        throw ex;
      }
    }

    public void Update(TEntity obj)
    {
      try
      {
        sqlContext.Entry(obj).State = EntityState.Modified;
        sqlContext.SaveChanges();
      }
      catch (Exception ex)
      {

        throw ex;
      }
    }
  }
}

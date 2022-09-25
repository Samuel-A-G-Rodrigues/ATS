using ATSRestApi.Application.Dtos;
using System.Collections.Generic;

namespace ATSRestApi.Application.Interfaces
{
  public interface IApplicationServiceCurriculo
  {
    void Add(CurriculoDto curriculoDto);
    void Update(CurriculoDto curriculoDto);
    void Remove(int id);
    IEnumerable<CurriculoDto> GetAll();
    CurriculoDto GetById(int id);
  }
}

using ATSRestApi.Application.Dtos;
using System.Collections.Generic;

namespace ATSRestApi.Application.Interfaces
{
  public interface IApplicationServiceCandidato
  {
    void Add(CandidatoDto candidatoDto);
    void Update(CandidatoDto candidatoDto);
    void Remove(int id);
    IEnumerable<CandidatoDto> GetAll();
    CandidatoDto GetById(int id);
  }
}

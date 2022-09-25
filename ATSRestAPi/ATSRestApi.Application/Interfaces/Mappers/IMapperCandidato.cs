using ATSRestApi.Application.Dtos;
using ATSRestApi.Domain.Entities;
using System.Collections.Generic;

namespace ATSRestApi.Application.Interfaces.Mappers
{
  public interface IMapperCandidato
  {
    Candidato MapperDtoToEntity(CandidatoDto candidatoDto);

    IEnumerable<CandidatoDto> MapperListCandidatosDto(IEnumerable<Candidato> candidatos);

    CandidatoDto MapperEntityToDto(Candidato candidato);
  }
}

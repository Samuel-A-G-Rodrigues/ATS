using ATSRestApi.Application.Dtos;
using ATSRestApi.Domain.Entities;
using System.Collections.Generic;

namespace ATSRestApi.Application.Interfaces.Mappers
{
  public interface IMapperCurriculo
  {
    Curriculo MapperDtoToEntity(CurriculoDto curriculoDto);

    IEnumerable<CurriculoDto> MapperListCurriculosDto(IEnumerable<Curriculo> curriculos);

    CurriculoDto MapperEntityToDto(Curriculo curriculo);
  }
}

using ATSRestApi.Application.Dtos;
using ATSRestApi.Application.Interfaces.Mappers;
using ATSRestApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATSRestApi.Application.Mappers
{
  public class MapperCurriculo : IMapperCurriculo
  {

    public Curriculo MapperDtoToEntity(CurriculoDto curriculoDto)
    {
      var curriculo = new Curriculo()
      {
        Id = curriculoDto.Id,
        Arquivo = curriculoDto.Arquivo,
        IdCandidato = curriculoDto.IdCandidato
      };

      return curriculo;
    }

    public CurriculoDto MapperEntityToDto(Curriculo curriculo)
    {
      var curriculoDto = new CurriculoDto()
      {
        Id = curriculo.Id,
        Arquivo = curriculo.Arquivo,
        IdCandidato = curriculo.IdCandidato
      };

      return curriculoDto;
    }

    public IEnumerable<CurriculoDto> MapperListCurriculosDto(IEnumerable<Curriculo> curriculos)
    {
      var dto = curriculos.Select(c => new CurriculoDto
      {
        Id = c.Id,
        Arquivo = c.Arquivo,
        IdCandidato = c.IdCandidato
      });
      return dto;
    }
  }
}

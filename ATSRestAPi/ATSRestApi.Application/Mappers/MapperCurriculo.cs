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
        Arquivo = curriculoDto.Arquivo
      };

      return curriculo;
    }

    public CurriculoDto MapperEntityToDto(Curriculo curriculo)
    {
      var curriculoDto = new CurriculoDto()
      {
        Id = curriculo.Id,
        Arquivo = curriculo.Arquivo
      };

      return curriculoDto;
    }

    public IEnumerable<CurriculoDto> MapperListCurriculosDto(IEnumerable<Curriculo> curriculos)
    {
      var dto = curriculos.Select(c => new CurriculoDto
      {
        Id = c.Id,
        Arquivo = c.Arquivo
      });
      return dto;
    }
  }
}

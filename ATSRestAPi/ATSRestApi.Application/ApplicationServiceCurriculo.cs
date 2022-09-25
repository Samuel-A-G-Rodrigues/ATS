using ATSRestApi.Application.Dtos;
using ATSRestApi.Application.Interfaces;
using ATSRestApi.Application.Interfaces.Mappers;
using ATSRestApi.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace ATSRestApi.Application
{
  public class ApplicationServiceCurriculo : IApplicationServiceCurriculo
  {
    private readonly IServiceCurriculo serviceCurriculo;
    private readonly IMapperCurriculo mapperCurriculo;

    public ApplicationServiceCurriculo(IServiceCurriculo serviceCurriculo,
     IMapperCurriculo mapperCurriculo)
    {
      this.serviceCurriculo = serviceCurriculo;
      this.mapperCurriculo = mapperCurriculo;
    }

    public void Add(CurriculoDto curriculoDto)
    {
      var candidato = mapperCurriculo.MapperDtoToEntity(curriculoDto);
      serviceCurriculo.Add(candidato);
    }

    public IEnumerable<CurriculoDto> GetAll()
    {
      var candidatos = serviceCurriculo.GetAll();
      return mapperCurriculo.MapperListCurriculosDto(candidatos);
    }

    public CurriculoDto GetById(int id)
    {
      var curriculo = serviceCurriculo.GetById(id);
      return mapperCurriculo.MapperEntityToDto(curriculo);
    }

    public void Remove(int id)
    {
      serviceCurriculo.Remove(id);
    }

    public void Update(CurriculoDto curriculoDto)
    {
      var produto = mapperCurriculo.MapperDtoToEntity(curriculoDto);
      serviceCurriculo.Update(produto);
    }
  }
}

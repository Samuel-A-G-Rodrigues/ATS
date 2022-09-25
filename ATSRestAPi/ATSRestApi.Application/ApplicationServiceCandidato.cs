using ATSRestApi.Application.Dtos;
using ATSRestApi.Application.Interfaces;
using ATSRestApi.Application.Interfaces.Mappers;
using ATSRestApi.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace ATSRestApi.Application
{
  public class ApplicationServiceCandidato : IApplicationServiceCandidato
  {
    private readonly IServiceCandidato serviceCandidato;
    private readonly IMapperCandidato mapperCandidato;

    public ApplicationServiceCandidato(IServiceCandidato serviceCandidato,
     IMapperCandidato mapperCandidato)
    {
      this.serviceCandidato = serviceCandidato;
      this.mapperCandidato = mapperCandidato;
    }

    public void Add(CandidatoDto candidatoDto)
    {
      var candidato = mapperCandidato.MapperDtoToEntity(candidatoDto);
      serviceCandidato.Add(candidato);
    }

    public IEnumerable<CandidatoDto> GetAll()
    {
      var candidatos = serviceCandidato.GetAll();
      return mapperCandidato.MapperListCandidatosDto(candidatos);
    }

    public CandidatoDto GetById(int id)
    {
      var candidato = serviceCandidato.GetById(id);
      return mapperCandidato.MapperEntityToDto(candidato);
    }

    public void Remove(int id)
    {
      serviceCandidato.Remove(id);
    }

    public void Update(CandidatoDto candidatoDto)
    {
      var produto = mapperCandidato.MapperDtoToEntity(candidatoDto);
      serviceCandidato.Update(produto);
    }
  }
}

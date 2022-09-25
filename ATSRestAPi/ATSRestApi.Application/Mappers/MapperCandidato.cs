using ATSRestApi.Application.Dtos;
using ATSRestApi.Application.Interfaces.Mappers;
using ATSRestApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ATSRestApi.Application.Mappers
{
  public class MapperCandidato : IMapperCandidato
  {

    public Candidato MapperDtoToEntity(CandidatoDto candidatoDto)
    {
      var candidato = new Candidato()
      {
        Id = candidatoDto.Id,
        NomeCompleto = candidatoDto.NomeCompleto,
        Email = candidatoDto.Email,
        Senha = candidatoDto.Senha,
        Nacionalidade = candidatoDto.Nacionalidade,
        CPF = candidatoDto.CPF,
        DataNascimento = candidatoDto.DataNascimento,
        Estado = candidatoDto.Estado,
        Cidade = candidatoDto.Cidade,
        IdCurriculo = string.IsNullOrEmpty(candidatoDto.IdCurriculo.ToString()) ?0: candidatoDto.IdCurriculo
      };

      return candidato;
    }

    public CandidatoDto MapperEntityToDto(Candidato candidato)
    {
      var candidatoDto = new CandidatoDto()
      {
        Id = candidato.Id,
        NomeCompleto = candidato.NomeCompleto,
        Email = candidato.Email,
        Senha = candidato.Senha,
        Nacionalidade = candidato.Nacionalidade,
        CPF = candidato.CPF,
        DataNascimento = candidato.DataNascimento,
        Estado = candidato.Estado,
        Cidade = candidato.Cidade,
        IdCurriculo = string.IsNullOrEmpty(candidato.IdCurriculo.ToString()) ? 0 : candidato.IdCurriculo
      };

      return candidatoDto;
    }

    public IEnumerable<CandidatoDto> MapperListCandidatosDto(IEnumerable<Candidato> candidatos)
    {
      var dto = candidatos.Select(c => new CandidatoDto
      {
        Id = c.Id,
        NomeCompleto = c.NomeCompleto,
        Email = c.Email,
        Senha = c.Senha,
        Nacionalidade = c.Nacionalidade,
        CPF = c.CPF,
        DataNascimento = c.DataNascimento,
        Estado = c.Estado,
        Cidade = c.Cidade,
        IdCurriculo = string.IsNullOrEmpty(c.IdCurriculo.ToString()) ? 0 : c.IdCurriculo
      });
      return dto;
    }
  }
}

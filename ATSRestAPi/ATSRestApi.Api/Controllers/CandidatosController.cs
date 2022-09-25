using ATSRestApi.Application.Dtos;
using ATSRestApi.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATSRestApi.Api.Controllers
{
  [Route("[controller]")]
  [ApiController]
  public class CandidatosController : Controller
  {
    private readonly IApplicationServiceCandidato _applicationServicecandidato;

    public CandidatosController(IApplicationServiceCandidato ApplicationServiceCandidato)
    {
      _applicationServicecandidato = ApplicationServiceCandidato;
    }

    //GET api/values
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
      return Ok(_applicationServicecandidato.GetAll());
    }

    //GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<IEnumerable<string>> Get(int id)
    {
      return Ok(_applicationServicecandidato.GetById(id));
    }

    //POST api/values
    [HttpPost]
    public ActionResult Post([FromBody] CandidatoDto candidatoDto)
    {
      try
      {
        if (candidatoDto == null)
          return NotFound();

        _applicationServicecandidato.Add(candidatoDto);
        return Ok("Candidato Cadastrado com sucesso!");
      }
      catch (Exception ex)
      {

        throw ex;
      }
    }

    //PUT api/values/5
    [HttpPut("{id}")]
    public ActionResult Put([FromBody] CandidatoDto candidatoDto)
    {
      try
      {
        if (candidatoDto == null)
          return NotFound();

        _applicationServicecandidato.Update(candidatoDto);
        return Ok("Candidato Atualizado com sucesso!");
      }
      catch (Exception ex)
      {

        throw ex;
      }
    }

    //DELETE api/values/5
    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
      try
      {
        var candidatoDto =  _applicationServicecandidato.GetById(id);

        if (candidatoDto == null)
          return NotFound();

        _applicationServicecandidato.Remove(id);
        return Ok("Candidato Removido com sucesso!");
      }
      catch (Exception ex)
      {

        throw ex;
      }
    }
  }
}

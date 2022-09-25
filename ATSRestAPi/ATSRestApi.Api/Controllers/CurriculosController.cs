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
  public class CurriculosController : Controller
  {
    private readonly IApplicationServiceCurriculo ApplicationServiceCurriculo;

    public CurriculosController(IApplicationServiceCurriculo ApplicationServiceCurriculo)
    {
      this.ApplicationServiceCurriculo = ApplicationServiceCurriculo;
    }

    //GET api/values
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
      return Ok(ApplicationServiceCurriculo.GetAll());
    }

    //GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<IEnumerable<string>> Get(int id)
    {
      return Ok(ApplicationServiceCurriculo.GetById(id));
    }

    //POST api/values
    //[HttpPost("{id}")]
    [HttpPost]
    public ActionResult Post([FromBody] CurriculoDto curriculoDto)
    {
      try
      {
        if (curriculoDto == null)
          return NotFound();

        ApplicationServiceCurriculo.Add(curriculoDto);
        return Ok("Curriculo Cadastrado com sucesso!");
      }
      catch (Exception)
      {

        throw;
      }
    }

    //PUT api/values/5
    [HttpPut("{id}")]
    public ActionResult Put([FromBody] CurriculoDto curriculoDto)
    {
      try
      {
        if (curriculoDto == null)
          return NotFound();

        ApplicationServiceCurriculo.Update(curriculoDto);
        return Ok("Curriculo Atualizado com sucesso!");
      }
      catch (Exception)
      {

        throw;
      }
    }

    //DELETE api/values/5
    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
      try
      {
        ApplicationServiceCurriculo.Remove(id);
        return Ok("Curriculo Removido com sucesso!");
      }
      catch (Exception)
      {

        throw;
      }
    }
  }
}

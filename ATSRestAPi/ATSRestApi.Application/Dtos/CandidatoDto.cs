using System;

namespace ATSRestApi.Application.Dtos
{
  public class CandidatoDto
  {
    public int Id { get; set; }
    public string NomeCompleto { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
    public string Nacionalidade { get; set; }
    public string CPF { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Estado { get; set; }
    public string Cidade { get; set; }
    public int? IdCurriculo { get; set; }
  }
}

using System;

namespace ATSRestApi.Domain.Entities
{
  public class Candidato : Base
  {
    public string NomeCompleto { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
    public string Nacionalidade { get; set; }
    public string CPF { get; set; }
    public DateTime DataNascimento { get; set; }
    public string Estado { get; set; }
    public string Cidade { get; set; }
    public DateTime DataCadastro { get; set; }
  }
}

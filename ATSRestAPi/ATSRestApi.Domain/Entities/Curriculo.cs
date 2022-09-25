using System;

namespace ATSRestApi.Domain.Entities
{
  public class Curriculo : Base
  {
    public string Arquivo { get; set; }
    public DateTime DataCadastro { get; set; }
  }
}

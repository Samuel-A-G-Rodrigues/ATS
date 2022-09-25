using Autofac;

namespace ATSRestApi.Infrastructure.CrossCuting.IOC
{
  public class ModuleIOC : Module
  {
    //Carrega a inj~eção criada com as nossas Classes
    protected override void Load(ContainerBuilder builder)
    {
      ConfigurationIOC.Load(builder);
    }
  }
}

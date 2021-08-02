using Autofac;

namespace RestApiDDD.Infraestrutura.IOC
{
    public class ModuloIOC : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            ConfiguracaoIOC.Load(builder);
        }
    }
}

using Autofac;
using AutoMapper;
using RestApiDDD.Aplicacao;
using RestApiDDD.Aplicacao.Interfaces;
using RestApiDDD.Aplicacao.Mapper;
using RestApiDDD.Dominio.Core.Interfaces.Repositorios;
using RestApiDDD.Dominio.Core.Interfaces.Servicos;
using RestApiDDD.Dominio.Servico;
using RestApiDDD.Infraestrutura.Data.Repositorios;

namespace RestApiDDD.Infraestrutura.IOC
{
    public class ConfiguracaoIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AplicacaoServicoCliente>().As<IAplicacaoServicoCliente>();
            builder.RegisterType<AplicacaoServicoProduto>().As<IAplicacaoServicoProduto>();
            builder.RegisterType<ServicoCliente>().As<IServicoCliente>();
            builder.RegisterType<ServicoProduto>().As<IServicoProduto>();
            builder.RegisterType<RepositorioCliente>().As<IRepositorioCliente>();
            builder.RegisterType<RepositorioProduto>().As<IRepositorioProduto>();
            builder.RegisterType<ServicoCliente>().As<IServicoCliente>();

            builder.Register(context => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ClienteProfile());
                cfg.AddProfile(new ProdutoProfile());
            })).AsSelf().SingleInstance();
        }
    }
}

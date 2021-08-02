using RestApiDDD.Dominio.Core.Interfaces.Repositorios;
using RestApiDDD.Dominio.Core.Interfaces.Servicos;
using RestApiDDD.Dominio.Entidades;

namespace RestApiDDD.Dominio.Servico
{
    public class ServicoCliente : ServicoBase<Cliente>, IServicoCliente
    {
        private readonly IRepositorioCliente _repositorioCliente;

        public ServicoCliente(IRepositorioCliente repositorioCliente)
            : base(repositorioCliente)
        {
            _repositorioCliente = repositorioCliente;
        }
    }
}

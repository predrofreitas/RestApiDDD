using RestApiDDD.Dominio.Core.Interfaces.Repositorios;
using RestApiDDD.Dominio.Entidades;

namespace RestApiDDD.Infraestrutura.Data.Repositorios
{
    public class RepositorioCliente : RepositorioBase<Cliente>, IRepositorioCliente
    {
        private readonly SqlContext _sqlContext;
        public RepositorioCliente(SqlContext sqlContext)
            : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}

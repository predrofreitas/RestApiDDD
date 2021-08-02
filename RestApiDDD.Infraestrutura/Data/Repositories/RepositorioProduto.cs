using RestApiDDD.Dominio.Core.Interfaces.Repositorios;
using RestApiDDD.Dominio.Entidades;

namespace RestApiDDD.Infraestrutura.Data.Repositorios
{
    public class RepositorioProduto : RepositorioBase<Produto>, IRepositorioProduto
    {
        private readonly SqlContext _sqlContext;
        public RepositorioProduto(SqlContext sqlContext)
            : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}

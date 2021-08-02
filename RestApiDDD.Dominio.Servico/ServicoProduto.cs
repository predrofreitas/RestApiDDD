using RestApiDDD.Dominio.Core.Interfaces.Repositorios;
using RestApiDDD.Dominio.Core.Interfaces.Servicos;
using RestApiDDD.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiDDD.Dominio.Servico
{
    public class ServicoProduto : ServicoBase<Produto>, IServicoProduto
    {
        private readonly IRepositorioProduto _repositorioProduto;

        public ServicoProduto(IRepositorioProduto repositorioProduto)
            : base(repositorioProduto)
        {
            _repositorioProduto = repositorioProduto;
        }
    }
}

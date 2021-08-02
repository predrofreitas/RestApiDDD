using AutoMapper;
using RestApiDDD.Aplicacao.Dtos;
using RestApiDDD.Aplicacao.Interfaces;
using RestApiDDD.Dominio.Core.Interfaces.Servicos;
using RestApiDDD.Dominio.Entidades;
using System.Collections.Generic;

namespace RestApiDDD.Aplicacao
{
    public class AplicacaoServicoProduto : IAplicacaoServicoProduto
    {
        private readonly IServicoProduto _servicoProduto;
        private readonly IMapper _mapper;

        public AplicacaoServicoProduto(IServicoProduto servicoProduto, IMapper mapper)
        {
            _servicoProduto = servicoProduto;
            _mapper = mapper;
        }

        public void Add(ProdutoDto produtoDto)
        {
            var produto = _mapper.Map<Produto>(produtoDto);
            _servicoProduto.Add(produto);
        }

        public IEnumerable<ProdutoDto> GetAll()
        {
            var produtos = _servicoProduto.GetAll();
            var produtosDto = _mapper.Map<IEnumerable<ProdutoDto>>(produtos);

            return produtosDto;
        }

        public ProdutoDto GetById(int id)
        {
            var produto = _servicoProduto.GetById(id);
            var produtoDto = _mapper.Map<ProdutoDto>(produto);

            return produtoDto;
        }

        public void Remove(ProdutoDto produtoDto)
        {
            var produto = _mapper.Map<Produto>(produtoDto);
            _servicoProduto.Remove(produto);
        }

        public void Update(ProdutoDto produtoDto)
        {
            var produto = _mapper.Map<Produto>(produtoDto);
            _servicoProduto.Update(produto);
        }
    }
}

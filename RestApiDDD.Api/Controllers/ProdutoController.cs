using Microsoft.AspNetCore.Mvc;
using RestApiDDD.Aplicacao.Dtos;
using RestApiDDD.Aplicacao.Interfaces;
using System;
using System.Collections.Generic;

namespace RestApiDDD.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IAplicacaoServicoProduto _aplicacaoServicoProduto;

        public ProdutosController(IAplicacaoServicoProduto aplicacaoServicoProduto)
        {
            _aplicacaoServicoProduto = aplicacaoServicoProduto;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_aplicacaoServicoProduto.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_aplicacaoServicoProduto.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] ProdutoDto produtoDTO)
        {
            try
            {
                if (produtoDTO == null)
                    return NotFound();


                _aplicacaoServicoProduto.Add(produtoDTO);
                return Ok("O produto foi cadastrado com sucesso");
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] ProdutoDto produtoDTO)
        {

            try
            {
                if (produtoDTO == null)
                    return NotFound();

                _aplicacaoServicoProduto.Update(produtoDTO);
                return Ok("O produto foi atualizado com sucesso!");

            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpDelete()]
        public ActionResult Delete([FromBody] ProdutoDto produtoDTO)
        {
            try
            {
                if (produtoDTO == null)
                    return NotFound();

                _aplicacaoServicoProduto.Remove(produtoDTO);
                return Ok("O produto foi removido com sucesso!");

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
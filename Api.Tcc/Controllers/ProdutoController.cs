using Api.Tcc.Business;
using Api.Tcc.Models;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Tcc.Controllers
{
    public class ProdutoController : ApiController
    {
        // POST: api/dados/{loja}
        /// <summary>
        /// Insere o preço de um produto de uma loja
        /// </summary>
        [HttpPost]
        [Route("api/{loja}")]
        [SwaggerResponse(HttpStatusCode.Created, Description = "Boolean com o resultado", Type = typeof(bool))]
        [SwaggerResponse(HttpStatusCode.InternalServerError, Description = "Erro no processamento da operação", Type = typeof(bool))]
        public IHttpActionResult Post(string loja, [FromBody]Produto produto)
        {
            Resultado resultado = new Resultado();
            ProdutoBusiness produtoBusiness = new ProdutoBusiness();

            try
            {
                resultado.Retorno = produtoBusiness.Inserir(loja, produto);

                return Created("", resultado);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, new Resultado(false, ex.Message));
            }
        }
    }
}

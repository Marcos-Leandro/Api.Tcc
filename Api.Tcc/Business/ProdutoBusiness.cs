using Api.Tcc.DAL;
using Api.Tcc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Tcc.Business
{
    public class ProdutoBusiness
    {
        public bool Inserir(string loja, Produto produto)
        {
            ProdutoDAL produtoDAL = new ProdutoDAL();

            return produtoDAL.Inserir(loja, produto);
        }
    }
}
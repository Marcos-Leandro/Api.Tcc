using Api.Tcc.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Api.Tcc.DAL
{
    public class ProdutoDAL
    {
        public bool Inserir(string loja, Produto produto)
        {
            string cs = ConfigurationManager.ConnectionStrings["Local"].ConnectionString;

            throw new Exception("Erro ao inserir dados");
        }
    }
}
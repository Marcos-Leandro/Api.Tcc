using Api.Tcc.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Api.Tcc.DAL
{
    public class ProdutoDAL
    {
        public bool Inserir(string loja, Produto produto)
        {
            try
            {
                SqlConnection connectionString = new SqlConnection(ConfigurationManager.ConnectionStrings["Local"].ConnectionString);

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO product_everton (NomeLoja, NomeProduto, PrecoVenda) VALUES (@nomeLoja, @nomeProduto, @precoVenda)";
                cmd.Parameters.Add("@nomeLoja", SqlDbType.NVarChar).Value = loja;
                cmd.Parameters.Add("@nomeProduto", SqlDbType.NVarChar).Value = produto.Nome;
                cmd.Parameters.Add("@precoVenda", SqlDbType.Money).Value = produto.Preco;
                cmd.Connection = connectionString;

                connectionString.Open();
                int resultado = cmd.ExecuteNonQuery();
                connectionString.Close();

                if (resultado > 0)
                {
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message);
                return false;
            }            
        }
    }
}
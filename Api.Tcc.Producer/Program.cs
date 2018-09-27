using Api.Tcc.Producer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Api.Tcc.Producer
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            List<string> produtoLoja1 = new List<string> { "Produto 1", "Produto 2", "Produto 3", "Produto 4", "Produto 5" };
            List<string> produtoLoja2 = new List<string> { "Produto 3", "Produto 4", "Produto 5", "Produto 6", "Produto 7" };
            List<string> produtoLoja3 = new List<string> { "Produto 1", "Produto 2", "Produto 3" };
            List<string> produtoLoja4 = new List<string> { "Produto 1", "Produto 2", "Produto 3", "Produto 4", "Produto 5", "Produto 6", "Produto 7" };
            List<string> produtoLoja5 = new List<string> { "Produto 1" };

            Dictionary<string, List<string>> lojas = new Dictionary<string, List<string>>();
            lojas.Add("Loja 1", produtoLoja1);
            lojas.Add("Loja 2", produtoLoja2);
            lojas.Add("Loja 3", produtoLoja3);
            lojas.Add("Loja 4", produtoLoja4);
            lojas.Add("Loja 5", produtoLoja5);

            //int index = random.Next(lojas.Count);

            for (int i = 0; i < 10000; i++)
            {
                foreach (var lojaAtual in lojas)
                {
                    string loja = lojaAtual.Key;

                    foreach (var produtoAtual in lojaAtual.Value)
                    {
                        double preco = random.NextDouble() * (100 - 0.1) + 0.1;

                        Produto produto = new Produto();
                        produto.Nome = produtoAtual;
                        produto.Preco = (decimal)System.Math.Round(preco, 2);

                        PostProduto(loja, produto);
                    }
                }
            }
        }

        private static void PostProduto(string loja, Produto produto)
        {
            using (var client = new WebClient())
            {
                string data = string.Empty, json = String.Empty;
                try
                {
                    client.Headers.Clear();
                    client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                    client.Encoding = Encoding.UTF8;

                    data = Newtonsoft.Json.JsonConvert.SerializeObject(produto);

                    client.UploadString($"http://localhost:58793/api/{loja}", data);

                    Console.WriteLine("Produto Inserido.");
                }
                catch (WebException e)
                {
                    json = new System.IO.StreamReader(e.Response.GetResponseStream()).ReadToEnd();
                    Newtonsoft.Json.JsonConvert.DeserializeObject<string>(json);
                }
            }
        }
    }
}

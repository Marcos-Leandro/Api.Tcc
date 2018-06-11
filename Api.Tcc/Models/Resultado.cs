using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Tcc.Models
{
    public class Resultado
    {
        public Resultado()
        {

        }

        public Resultado(bool retorno, string mensagem)
        {
            Retorno = retorno;
            Mensagem = mensagem;
        }

        public bool Retorno { get; set; }
        public string Mensagem { get; set; }
    }
}
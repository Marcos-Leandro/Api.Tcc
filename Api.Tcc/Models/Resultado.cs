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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="retorno"></param>
        /// <param name="mensagem"></param>
        public Resultado(bool retorno, string mensagem)
        {
            Retorno = retorno;
            Mensagem = mensagem;
        }

        /// <summary>
        /// Resultado da operação
        /// </summary>
        public bool Retorno { get; set; }
        /// <summary>
        /// Mensagm da opreção
        /// </summary>
        public string Mensagem { get; set; }
    }
}
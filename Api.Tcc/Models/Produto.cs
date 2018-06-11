using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Api.Tcc.Models
{
    public class Produto
    {
        /// <summary>
        /// Nome do produto
        /// </summary>
        [Required]
        public string Nome { get; set; }
        /// <summary>
        /// Preço do produto
        /// </summary>
        [Required]
        public decimal Preco { get; set; }
    }
}
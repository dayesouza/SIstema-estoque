using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class ProdutoModel
    {
        [Display(Name = "sku")]
        public int sku { get; set; }

        [Required(ErrorMessage = "Descricao é obrigatoria.")]
        public string descricao { get; set; }

        [Required(ErrorMessage = "tamanho é obrigatorio.")]
        public string tamanho { get; set; }

//        [Required(ErrorMessage = "Address is required.")]
        public string cor { get; set; }
    

    }
}
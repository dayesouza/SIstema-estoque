using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.Models {
  public class MovimentacaoModel {
    [Display(Name = "id")]
    public int id { get; set; }

    public DateTime data { get; set; }

    [Required(ErrorMessage = "preço unitario é obrigatoria.")]
    public decimal preco_unitario { get; set; }

    [Required(ErrorMessage = "quantidade é obrigatorio.")]
    public int quantidade { get; set; }

    [Required(ErrorMessage = "sku_produto é obrigatorio.")]
    public int sku_produto { get; set; }

    [Required(ErrorMessage = "doc_num é obrigatorio.")]
    public int doc_num { get; set; }

    [Required(ErrorMessage = "tipo movimentacao é obrigatorio.")]
    public string tipo_movimentacao { get; set; }

    [Required(ErrorMessage = "cod deposito é obrigatorio.")]
    public int cod_deposito { get; set; }

  }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Web.Models {
  public class DepositoModel {
    [Display(Name = "cod_deposito")]
    public int cod_deposito { get; set; }

    public DateTime data_validade { get; set; }

    [Required(ErrorMessage = "quantidade é obrigatoria.")]
    public int quantidade { get; set; }

    [Required(ErrorMessage = "Id produto é obrigatorio.")]
    public int sku_produto { get; set; }
  }
}
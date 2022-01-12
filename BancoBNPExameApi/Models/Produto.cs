using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BancoBNPExameApi.Models
{
    public class Produto
    {
        [Key]
        public string  COD_PRODUTO { get; set; }
        [Display(Name = "Descrição do Produto")]
        public string DES_PRODUTO { get; set; }
        public string STA_PRODUTO { get; set; }
    }
}
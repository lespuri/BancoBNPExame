using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BancoBNPExameApi.Models
{
    public class ProdutoCosif
    {
        [Key]
        [Column(Order = 1)]
        public string  COD_PRODUTO { get; set; }
        [Key]
        [Column(Order = 2)]
        public string COD_COSIF { get; set; }        
        public string COD_CLASSIFICACAO { get; set; }
        public string STA_STATUS { get; set; }
        public virtual Produto Produto { get; set; }

    }
}
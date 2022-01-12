using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BancoBNPExameApi.Models
{
    public class MovimentoManual
    {                
        
        [Key]
        [Column(Order = 1)]
        [Display(Name = "Mês")]
        public int  DAT_MES { get; set; }
        [Key]
        [Column(Order = 2)]
        [Display(Name = "Ano")]
        public int DAT_ANO { get; set; }
        [Key]
        [Column(Order = 3)]
        [Display(Name = "NR Lançamento")]
        public int NUM_LANCAMENTO { get; set; }
        [Key]
        [Column(Order = 4)]
        [Display(Name = "Código do Produto")]
        public string COD_PRODUTO { get; set; }
        [Key]
        [Column(Order = 5)]
        [Display(Name = "Cosif")]
        public string COD_COSIF { get; set; }
        [Display(Name = "Descrição")]
        public string DES_DESCRICAO { get; set; }
        [Display(Name = "Data do movimento")]
        public DateTime DAT_MOVIMENTO { get; set; }
        [Display(Name = "Usuário")]
        public string COD_USUARIO { get; set; }
        [Display(Name = "Valor")]
        public decimal VAL_VALOR { get; set; }

        public virtual Produto Produtos { get; set; }
    }
}
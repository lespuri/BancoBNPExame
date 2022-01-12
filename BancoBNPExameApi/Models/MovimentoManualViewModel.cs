using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BancoBNPExameApi.Models
{
    public class MovimentoManualViewModel
    {                
        
        public  MovimentoManual MovimentoManualVM { get; set; }

        public IEnumerable<MovimentoManual> MovimentoManualVMs { get; set; }
    }
}
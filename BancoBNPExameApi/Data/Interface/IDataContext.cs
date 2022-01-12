using BancoBNPExameApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBNPExameApi.Data.Interface
{
    public interface IDataContext
    {
        DbSet<MovimentoManual> MovimentoManuals { get; set; }
        DbSet<Produto> Produtos { get; set; }
        DbSet<ProdutoCosif> ProdutoCosifs { get; set; }

        int SaveChanges();
    }
}

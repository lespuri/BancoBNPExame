using BancoBNPExameApi.Data.Interface;
using BancoBNPExameApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BancoBNPExameApi.Data
{
    public class DataContext : DbContext, IDataContext
    {
        private string _stringCon = "Integrated Security = False; Persist Security Info=False;Initial Catalog = bancoBNPd; Data Source = dev2\\sqlexpress";

        public DataContext(string prStringCon) : base (prStringCon)
        {            
        }

        public DataContext() 
        {
            new DataContext(_stringCon);
        }
        public DbSet<MovimentoManual> MovimentoManuals { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ProdutoCosif> ProdutoCosifs { get; set; }
        
    }
}
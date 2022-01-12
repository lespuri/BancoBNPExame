using BancoBNPExameApi.Data;
using BancoBNPExameApi.Data.Interface;
using BancoBNPExameApi.Models;
using BancoBNPExameApi.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BancoBNPExameApi.Repositories
{
    public class ProdutoCoSIFRepository : IProdutoCoSIFRepository
    {
        private  IDataContext _context;

        public ProdutoCoSIFRepository()
        {
            _context = new DataContext();
        }

        public IEnumerable<ProdutoCosif> ObterTodos()
        {
            return _context.ProdutoCosifs.ToList();            
        }
    }
}
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
    public class ProdutoRepository : IProdutoRepository
    {
        private  IDataContext _context;

        public ProdutoRepository()
        {
            _context = new DataContext();
        }

        public IEnumerable<Produto> ObterTodos()
        {
            return _context.Produtos.ToList();            
        }
    }
}
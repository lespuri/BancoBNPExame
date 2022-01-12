using BancoBNPExameApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBNPExameApi.Repositories.Interface
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> ObterTodos();
    }
}

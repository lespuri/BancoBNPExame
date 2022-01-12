using BancoBNPExameApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBNPExameApi.Repositories.Interface
{
    public interface IMovimentoManualRepository
    {
        void Create(MovimentoManual movimentoManual);

        void Update(MovimentoManual movimentoManual);

        void Delete(MovimentoManual movimentoManual);

        IEnumerable<MovimentoManual> ObterTodos();

        IEnumerable<MovimentoManual> ObterPorMesAno(int prMes, int prAno);
    }
}

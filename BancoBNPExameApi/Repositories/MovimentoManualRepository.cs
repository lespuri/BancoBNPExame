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
    public class MovimentoManualRepository : IMovimentoManualRepository
    {
        private  IDataContext _context;

        public MovimentoManualRepository()
        {
            _context = new DataContext();
        }

        public void Create(MovimentoManual movimentoManual)
        {
            var lMovimentoManual = _context.MovimentoManuals
                .Where(x => x.DAT_MES == movimentoManual.DAT_MES && x.DAT_ANO == movimentoManual.DAT_ANO)
                .OrderByDescending(x => x.NUM_LANCAMENTO).FirstOrDefault();


            movimentoManual.DAT_MOVIMENTO = DateTime.Now;
            movimentoManual.COD_USUARIO = "TESTE";
            movimentoManual.NUM_LANCAMENTO = lMovimentoManual != null ? lMovimentoManual.NUM_LANCAMENTO + 1 : 1;

            _context.MovimentoManuals.Add(movimentoManual);
            _context.SaveChanges();
        }

        public IEnumerable<MovimentoManual> ObterTodos()
        {
            return _context.MovimentoManuals.ToList();
        }

        public IEnumerable<MovimentoManual> ObterPorMesAno(int prMes, int prAno)
        {
            var llsMovimentoManual = _context.MovimentoManuals
                .Where(x => x.DAT_MES == prMes && x.DAT_ANO == prAno)
                .OrderByDescending(x => x.NUM_LANCAMENTO).ToList();
            
            return llsMovimentoManual;
        }

    }
}
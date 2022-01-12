using BancoBNPExameApi.Models;
using BancoBNPExameApi.Repositories;
using BancoBNPExameApi.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace BancoBNPExameApi.Controllers
{
    [RoutePrefix("api/v1/MovimentoManual")]
    public class MovimentoManualApiController : ApiController
    {
        private IMovimentoManualRepository _repositoryMovimentoManual;

        public MovimentoManualApiController()
        {
            _repositoryMovimentoManual = new MovimentoManualRepository();
        }

        // GET api/v1/MovimentoManual
        [Route("")]
        public IEnumerable<MovimentoManual>  Get()
        {
            return _repositoryMovimentoManual.ObterTodos();
        }


        // GET api/v1/MovimentoManual/{mes}/{ano}
        [Route("{mes:int}/{ano:int}")]
        public IEnumerable<MovimentoManual> Get(int mes, int ano)
        {
            return _repositoryMovimentoManual.ObterPorMesAno(mes, ano);
        }

        // POST api/values
        [Route("")]
        public void Post([FromBody] MovimentoManual movimentoManual)
        {
            _repositoryMovimentoManual.Create(movimentoManual);
        }

        // PUT api/values/5
        [Route("")]
        public void Put([FromBody] MovimentoManual movimentoManual)
        {
            _repositoryMovimentoManual.Update(movimentoManual);
        }

        // DELETE api/values/5
        [Route("")]
        public void Delete([FromBody] MovimentoManual movimentoManual)
        {
            _repositoryMovimentoManual.Delete(movimentoManual);
        }
    }
}

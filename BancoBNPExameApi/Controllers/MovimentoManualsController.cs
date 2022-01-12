using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BancoBNPExameApi.Data;
using BancoBNPExameApi.Models;
using BancoBNPExameApi.Repositories;
using BancoBNPExameApi.Repositories.Interface;


namespace BancoBNPExameApi.Controllers
{
    public class MovimentoManualsController : Controller
    {
        private IMovimentoManualRepository _repositoryMovimentoManual;
        private IProdutoRepository _repositoryProduto;
        private IProdutoCoSIFRepository _repositoryProdutoCoSIF;

        public MovimentoManualsController()
        {
            _repositoryMovimentoManual = new MovimentoManualRepository();
            _repositoryProduto = new ProdutoRepository();
            _repositoryProdutoCoSIF = new ProdutoCoSIFRepository();
        }

        // GET: MovimentoManuals
        public ActionResult Index()
        {
            MovimentoManualViewModel movimentoManualViewModel = new MovimentoManualViewModel();
            movimentoManualViewModel.MovimentoManualVMs = _repositoryMovimentoManual.ObterTodos();
            movimentoManualViewModel.MovimentoManualVM = new MovimentoManual();


            List<SelectListItem> itemsProdutos = new List<SelectListItem>();
            List<SelectListItem> itemsProdutoCosifs = new List<SelectListItem>();

            var llsProdutos = _repositoryProduto.ObterTodos();
            var llsiProdutoCosifs = _repositoryProdutoCoSIF.ObterTodos();
            foreach (var item in llsProdutos)
            {
                itemsProdutos.Add(new SelectListItem { Text = item.DES_PRODUTO, Value = item.COD_PRODUTO });
            }

            foreach (var item in llsiProdutoCosifs)
            {
                itemsProdutoCosifs.Add(new SelectListItem { Text = string.Format("{0}-{1}", item.COD_COSIF, item.COD_CLASSIFICACAO), Value = item.COD_COSIF });
            }


            ViewBag.itemsProdutos = itemsProdutos;
            ViewBag.itemsProdutoCosifs = itemsProdutoCosifs;



            return View(movimentoManualViewModel);
        }

        // GET: MovimentoManuals/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    MovimentoManual movimentoManual = db.MovimentoManuals.Find(id);
        //    if (movimentoManual == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(movimentoManual);
        //}

        // GET: MovimentoManuals/Create
        //public ActionResult Create()
        //{
        //    List<SelectListItem> itemsProdutos = new List<SelectListItem>();
        //    List<SelectListItem> itemsProdutoCosifs = new List<SelectListItem>();

        //    var llsProdutos = db.Produtos.ToList();
        //    var llsiProdutoCosifs = db.ProdutoCosifs.ToList();
        //    foreach (var item in llsProdutos)
        //    {
        //        itemsProdutos.Add(new SelectListItem { Text = item.DES_PRODUTO, Value = item.COD_PRODUTO });
        //    }

        //    foreach (var item in llsiProdutoCosifs)
        //    {
        //        itemsProdutoCosifs.Add(new SelectListItem { Text = string.Format("{0}-{1}", item.COD_COSIF , item.COD_CLASSIFICACAO)  , Value = item.COD_COSIF });
        //    }


        //    ViewBag.itemsProdutos = itemsProdutos;
        //    ViewBag.itemsProdutoCosifs = itemsProdutoCosifs;


        //    return View();
        //}

        // POST: MovimentoManuals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]        
        public ActionResult Create([Bind(Include = "MovimentoManualVM")] MovimentoManualViewModel movimentoManual)

        {
            if (ModelState.IsValid)
            {
                _repositoryMovimentoManual.Create(movimentoManual.MovimentoManualVM);

                return RedirectToAction("Index");
            }

            return View(movimentoManual);
        }

        // GET: MovimentoManuals/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    MovimentoManual movimentoManual = db.MovimentoManuals.Find(id);
        //    if (movimentoManual == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(movimentoManual);
        //}

        // POST: MovimentoManuals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "DAT_MES,DAT_ANO,NUM_LANCAMENTO,COD_PRODUTO,COD_COSIF,DES_DESCRICAO,DAT_MOVIMENTO,COD_USUARIO,VAL_VALOR")] MovimentoManual movimentoManual)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(movimentoManual).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(movimentoManual);
        //}

        // GET: MovimentoManuals/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    MovimentoManual movimentoManual = db.MovimentoManuals.Find(id);
        //    if (movimentoManual == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(movimentoManual);
        //}

        // POST: MovimentoManuals/Delete/5
       // [HttpPost, ActionName("Delete")]
       // [ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    MovimentoManual movimentoManual = db.MovimentoManuals.Find(id);
        //    db.MovimentoManuals.Remove(movimentoManual);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}

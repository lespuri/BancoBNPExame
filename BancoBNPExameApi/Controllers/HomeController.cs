using BancoBNPExameApi.Data;
using BancoBNPExameApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BancoBNPExameApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Para inserção nas tabelas de dominio
            ///DataContext dataContext = new DataContext("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=bancoBNP;Data Source=dev2\\sqlexpress");

            //dataContext.Produtos.Add(new Produto {
            //    COD_PRODUTO = "PROD1",
            //    DES_PRODUTO = "PRODUTO1",
            //    STA_PRODUTO = "ATIVO"
            //});

            //dataContext.ProdutoCosifs.Add(new ProdutoCosif { 
            //COD_CLASSIFICACAO = "O MELHOR",
            //COD_COSIF = "COSIF1",
            //COD_PRODUTO = "PROD1",
            //DES_PRODUTO = "PRODUTO1",
            //STA_STATUS = "ATIVO"
            //});

            //dataContext.SaveChanges();

            ViewBag.Title = "Movimento Manual";

            return View();
        }
    }
}

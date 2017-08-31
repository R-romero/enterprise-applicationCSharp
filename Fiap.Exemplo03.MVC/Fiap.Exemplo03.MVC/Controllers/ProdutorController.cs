using Fiap.Exemplo03.MVC.Models;
using Fiap.Exemplo03.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo03.MVC.Controllers
{
    public class ProdutorController : Controller
    {

        private SacolaoContext _context = new SacolaoContext();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Cadastrar(Produtor produtor)
        {
            produtor.DataCadastro = DateTime.Now;
            _context.Produtor.Add(produtor);
            _context.SaveChanges();
            TempData["msg"] = "Produtor Cadastrado!";
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_context.Produtor.ToList());
        }
    }
}
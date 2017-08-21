using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fiap.Exemplo02.MVC.Models;

namespace Fiap.Exemplo02.MVC.Controllers
{
    public class VagaController : Controller
    {

        private static List<Vaga> _banco = new List<Vaga>();
        
        // GET: Vaga
        [HttpGet]
        public ActionResult Cadastrar()
        {
            PopulaComboNiveis();
            return View();
        }

        private void PopulaComboNiveis()
        {
            List<string> niveis = new List<string>();
            niveis.Add("Junior");
            niveis.Add("Pleno");
            niveis.Add("Sênior");
            ViewBag.options = new SelectList(niveis);
        }

        [HttpPost]
        public ActionResult Cadastrar(Vaga vaga)
        {
            PopulaComboNiveis();
            _banco.Add(vaga);
            ViewBag.msg = "Cadastrado com Sucesso";
            return View();
        }

        public ActionResult Listar()
        {
            return View(_banco);
        }
    }
}
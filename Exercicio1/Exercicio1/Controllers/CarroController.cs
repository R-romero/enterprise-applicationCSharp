using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exercicio1.Models;

namespace Exercicio1.Controllers
{
    public class CarroController : Controller
    {
        //Simular o banco
        private static List<Carro> _lista = new List<Carro>();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Cadastrar(Carro carro)
        {
            _lista.Add(carro);
            TempData["msg"] = "Cadastrado!";
            return View(carro);
        }

        public ActionResult Listar()
        {
            //Passa a lista pra tela
            return View(_lista);
        }

    }
}
using FinalProject_MVC.Models;
using FinalProject_MVC.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProject_MVC.Controllers
{
    public class EmpresaController : Controller
    {
        //Declaração da UnitOfWork
        private UnitOfWork _unit = new UnitOfWork();

        //Método de Liberar a Conexão
        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }

        //Cadastrar
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Cadastrar(Empresa empresa)
        {
            if (ModelState.IsValid)
            {
                _unit.EmpresaRepository.Cadastrar(empresa);
                _unit.Save();
                TempData["msg"] = "Cadastrado!";
                return RedirectToAction("Cadastrar");
            }else
            {
                return View(empresa);
            }
        }

        //Listar
        [HttpGet]
        public ActionResult Listar()
        {
            return View(_unit.EmpresaRepository.Listar());
        }
    }
}
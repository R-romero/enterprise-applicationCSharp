using FinalProject_MVC.Models;
using FinalProject_MVC.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProject_MVC.Controllers
{
    public class FuncionarioController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            var lista = _unit.EmpresaRepository.Listar();
            ViewBag.empresa = new SelectList(lista, "EmpresaId", "RazaoSocial");
            return View();
        }
        [HttpPost]
        public ActionResult Cadastrar(Funcionario func)
        {
            if (ModelState.IsValid)
            {
                _unit.FuncionarioRepository.Cadastrar(func);
                _unit.Save();
                TempData["msg"] = "Omae wa mou Shindeiru";
                return RedirectToAction("Cadastrar");
            }else
            {
                var lista = _unit.EmpresaRepository.Listar();
                ViewBag.empresa = new SelectList(lista, "EmpresaId", "RazaoSocial");
                return View(func);
            }
        }

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_unit.FuncionarioRepository.Listar());
        }


        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}
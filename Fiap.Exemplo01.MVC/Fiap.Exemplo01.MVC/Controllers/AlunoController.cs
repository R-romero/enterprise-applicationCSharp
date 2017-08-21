using Fiap.Exemplo01.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo01.MVC.Controllers
{
    public class AlunoController : Controller
    {
        //Action para abrir a View do formulário
        [HttpGet]
        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Salvar(Aluno aluno)
        {
            ViewBag.nomeAluno = aluno.Nome;
            ViewBag.dataAluno = aluno.Data;
            ViewBag.salarioAluno = aluno.Salario;
            TempData["mensagem"] = "Aluno Registrado!";
            return View(aluno);

            //return Content("Gravou! " + aluno.Nome + "<br/> " +
            //    aluno.Data.ToString("dd/MM/yyyy") + "<br/> " + aluno.Salario);
        }

    }
}
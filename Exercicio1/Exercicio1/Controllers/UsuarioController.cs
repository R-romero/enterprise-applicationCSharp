using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exercicio1.Models;

namespace Exercicio1.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Abrir(Usuario usuario)
        {
            ViewBag.nome = usuario.Nome;
            ViewBag.email = usuario.Email;
            TempData["mensagem"] = "Aluno Registrado com Sucesso.";
            
            return View(usuario);
        }
    }
}
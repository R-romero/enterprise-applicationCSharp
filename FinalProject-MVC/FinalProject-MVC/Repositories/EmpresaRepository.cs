using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalProject_MVC.Models;
using FinalProject_MVC.Persistencia;

namespace FinalProject_MVC.Repositories
{
    public class EmpresaRepository : IEmpresaRepository
    {
        private EmpresarialContext _context;

        public EmpresaRepository(EmpresarialContext context)
        {
            _context = context;
        }
        public void Cadastrar(Empresa empresa)
        {
            _context.Empresa.Add(empresa);
        }

        public List<Empresa> Listar()
        {
            return _context.Empresa.ToList();
        }
    }
}
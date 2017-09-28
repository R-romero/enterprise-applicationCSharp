using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using FinalProject_MVC.Models;
using FinalProject_MVC.Persistencia;
using System.Data.Entity;

namespace FinalProject_MVC.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        //Importar o Context, funciona como Entity Manager
        private EmpresarialContext _context;

        public FuncionarioRepository(EmpresarialContext context)
        {
            _context = context;
        }

        public void Alterar(Funcionario funcionario)
        {
            _context.Entry(funcionario).State = EntityState.Modified;
        }

        public Funcionario Buscar(int id)
        {

            return _context.Funcionario.Find(id);
        }

        public List<Funcionario> BuscarPor(Expression<Func<Funcionario, bool>> filtro)
        {
            return _context.Funcionario.Include("Empresa").Where(filtro).ToList();
        }

        public void Cadastrar(Funcionario funcionario)
        {
            _context.Funcionario.Add(funcionario);
        }

        public List<Funcionario> Listar()
        {
            return _context.Funcionario.Include("Empresa").ToList();
        }

        public void Remover(int id)
        {
            _context.Funcionario.Remove(Buscar(id));
        }
    }
}
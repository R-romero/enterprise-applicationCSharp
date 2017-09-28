using FinalProject_MVC.Persistencia;
using FinalProject_MVC.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject_MVC.Units
{
    public class UnitOfWork : IDisposable
    {
        private EmpresarialContext _context = new EmpresarialContext();
        private IFuncionarioRepository _funcionarioRepository;
        private IEmpresaRepository _empresaRepository;


        public IFuncionarioRepository FuncionarioRepository
        {
            get
            {
                if(_funcionarioRepository == null)
                {
                    _funcionarioRepository = new FuncionarioRepository(_context);
                }
                return _funcionarioRepository;
            }
        }

        public IEmpresaRepository EmpresaRepository
        {
            get
            {
                if(_empresaRepository == null)
                {
                    _empresaRepository = new EmpresaRepository(_context);
                }
                return _empresaRepository;
            }
        }

        public void Dispose()
        {
            if(_context == null)
            {
                _context.Dispose();
            }
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
using FinalProject_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_MVC.Repositories
{
    //Adicionar Public na Interface
    public interface IEmpresaRepository
    {
        void Cadastrar(Empresa empresa);

        List<Empresa> Listar();
    }
}

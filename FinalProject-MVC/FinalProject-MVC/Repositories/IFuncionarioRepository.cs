using FinalProject_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_MVC.Repositories
{
    public interface IFuncionarioRepository
    {
        //Método começa com letra maiuscula, Repository leva apenas as assinaturas
        void Cadastrar(Funcionario funcionario);

        void Alterar(Funcionario funcionario);

        void Remover(int id);

        List<Funcionario> Listar();

        //Usar Expression Language
        List<Funcionario> BuscarPor(Expression<Func<Funcionario,bool>> filtro);

        Funcionario Buscar(int id);

    }
}

using FinalProject_MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FinalProject_MVC.Persistencia
{
    public class EmpresarialContext : DbContext
    {
        public DbSet<Empresa> Empresa { get; set; }

        public DbSet<Funcionario> Funcionario { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProject_MVC.Models
{
    public class Empresa
    {
        public int EmpresaId { get; set; }

        [Required]
        [StringLength(60,ErrorMessage ="60")]
        public string Cnpj { get; set; }

        [Required]
        [Display(Name ="Razão Social")]
        public string RazaoSocial { get; set; }

        //Referências
        public List<Funcionario> Funcionarios { get; set; }

    }
}
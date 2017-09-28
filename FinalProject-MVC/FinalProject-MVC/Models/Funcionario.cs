using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProject_MVC.Models
{
    public class Funcionario
    {

        public int FuncionarioId { get; set; }

        [Required]
        [StringLength(200,ErrorMessage ="Máximo de 200 Caracteres")]
        public string Nome { get; set; }

        [Required]
        public decimal Salario { get; set; }

        [Required]
        [Display(Name ="Data de Admissão")]
        public DateTime DataAdmissao { get; set; }

        //Referências
        public Empresa Empresa { get; set; }

        [Required]
        public int EmpresaId { get; set; }
    }
}
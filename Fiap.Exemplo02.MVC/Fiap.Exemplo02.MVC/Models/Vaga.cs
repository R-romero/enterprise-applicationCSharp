﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo02.MVC.Models
{
    public class Vaga
    {
        public string Cargo { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Display(Name = "Salário")]
        public decimal Salario { get; set; }
        [Display(Name = "Vale Refeição")]
        public bool Vr { get; set; }
        public string Nivel { get;set; }
    }
}
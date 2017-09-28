using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo04.MVC.Models
{
    public class Jogador
    {
        public int JogadorId { get; set; }
        
        [Required]
        [StringLength(150,ErrorMessage ="Máximo de 200 Caracteres")]
        public string Nome { get; set; }
        [Required]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date, ErrorMessage ="Data Inválida ")]
        public DateTime DataNascimento { get; set; }

        //Relacionamentos
        public Time Time { get; set; }
        public int TimeId { get; set; }
    }
}
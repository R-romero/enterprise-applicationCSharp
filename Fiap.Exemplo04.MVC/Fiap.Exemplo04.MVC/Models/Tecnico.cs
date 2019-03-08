using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo04.MVC.Models
{
    public class Tecnico
    {
        public int TecnicoId { get; set; }
        public string Nome { get; set; }

		[Display(Name = "Numero de Titulos")]
		public int NumeroTitulos { get; set; }
    }
}
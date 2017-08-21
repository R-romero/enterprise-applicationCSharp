using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    public abstract class Conta
    {
        //Properties
        public int Agencia {get; set;}
        public int Numero  {get; set;}
        public DateTime DataAbertura {get; set;}
        public Decimal Saldo {get; set;}

        //Methods
        public abstract void Depositar(decimal valor);
        public abstract void Retirar(decimal valor);

    }
}

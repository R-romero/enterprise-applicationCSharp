using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    public sealed class ContaCorrente : Conta
    {
        public Enum Tipo {get; set;}

        public override void Depositar(decimal valor)
        {
            Saldo += valor;
            Console.WriteLine("Novo Saldo: R$" + Saldo);
        }

        public override void Retirar(decimal valor)
        {

            if((Saldo -= valor) >= 0)
            {
                Saldo -= valor;
                Console.WriteLine("Novo Saldo: R$" + Saldo);
            }
            else
            {
                throw new ArgumentException("Saldo indisponível na CC");
            }
        }
    }
}

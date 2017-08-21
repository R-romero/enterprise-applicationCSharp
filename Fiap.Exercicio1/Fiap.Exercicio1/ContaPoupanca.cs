using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fiap.Exercicio1;

namespace Fiap.Banco.Model
{
    class ContaPoupanca : Conta, IContaInvestimento
    {
        //Fields
        readonly decimal _rendimento;
        //Properties

        //Constructor
        public ContaPoupanca(decimal rendimento)
        {
            this._rendimento = rendimento;
        }

        public decimal Taxa {get; set;}
        public void CalculaRetornoInvestimento()
        {
            Console.WriteLine("Rendimento Aplicado: R$" + Saldo * _rendimento);
        }

        public override void Depositar(decimal valor)
        {
            Saldo += valor;
            Console.WriteLine("Novo Saldo: R$" + Saldo);
        }

        public override void Retirar(decimal valor)
        {
            if ((Saldo -=valor) >= 0)
            {
                Saldo -= valor + Taxa;
                Console.WriteLine("Novo Saldo: R$" + Saldo);
            }
            else
            {
                throw new ArgumentException("Saldo indisponível na CP");
            }
        }
    }
}

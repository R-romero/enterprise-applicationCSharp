using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fiap.Banco.Model;

namespace Fiap.Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente();
                cc.Agencia = 2;
                cc.Numero = 123;
                cc.Tipo = TipoConta.Especial;
                cc.DataAbertura = DateTime.Now;
                cc.Saldo = 100;
            ContaPoupanca cp = new ContaPoupanca(2);
                cp.Agencia = 5;
                cp.Numero = 321;
                cp.DataAbertura = DateTime.Now;
                cp.Saldo = 1000;

            try
            {
                cc.Depositar(200);
                cc.Retirar(100);
                cp.CalculaRetornoInvestimento();
                cp.Retirar(1500);
                Console.ReadLine();
            }catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }

        }
    }
}

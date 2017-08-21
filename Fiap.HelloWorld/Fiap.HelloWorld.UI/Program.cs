using Fiap.HelloWorld.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar os Objetos
            Carro car = new Carro("abc321",2);
            Moto moto = new Moto("dfs123",true);
        
            //Exibir a placa
            Console.WriteLine("Placa do Carro: " + car.Placa);
            Console.WriteLine("Qtd Portas: " + car.NumeroPortas);
                Console.WriteLine();
            Console.WriteLine("Placa da Moto: " + moto.Placa);
            Console.WriteLine("Bau: " + moto.Bau);
            Console.ReadLine();
        }
    }
}

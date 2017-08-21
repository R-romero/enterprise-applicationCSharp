using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI.Model
{
    class Carro : Veiculo
    {
        public int NumeroPortas { get; set; }

        public Carro(string placa, int numeroportas) : base(placa)
        {
            NumeroPortas = numeroportas;
        }
    }
}

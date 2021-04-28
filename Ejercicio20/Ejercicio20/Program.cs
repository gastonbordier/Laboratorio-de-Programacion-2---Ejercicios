using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Ejercicio20
{
    class Program
    {


        static void Main(string[] args)
        {
            Pesos pesos = new Pesos(50);
            Pesos pesos2 = (Pesos)23;
            Pesos pesos3 = (Pesos)35 + (Pesos)40;
            Pesos pesos4 = (Pesos)(Dolares)4;

            Console.WriteLine(pesos.getCantidad());
            Console.WriteLine(pesos2.getCantidad());
            Console.WriteLine(pesos3.getCantidad());
            Console.WriteLine(pesos4.getCantidad());


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Pesos
    {
        double cantidad;
        double cotizacionRespectoDolar;

        public Pesos()
        {
            this.cantidad = 0;
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public static Pesos operator +(Pesos pesos, Dolares dolares)
        {

            pesos.cantidad = pesos.cantidad + dolares.cantidad;

            return pesos;

        }


        static void Main(string[] args)
        {
            Pesos pesos = new Pesos();


            pesos = new Pesos(45) +  new Dolares(50);

            Console.WriteLine(pesos.cantidad);

        }
    }
}

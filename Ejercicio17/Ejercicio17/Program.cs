using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Geometria;

namespace PruebaGeometria
{
    class Program
    {
        static void Main(String[] args)
        {
            Rectangulo rectangulo = new Rectangulo(new Punto(-7, 4), new Punto(9, -5));

            Rectangulo.ImprimirDatos(rectangulo);

            Console.WriteLine();

        }
    }
}

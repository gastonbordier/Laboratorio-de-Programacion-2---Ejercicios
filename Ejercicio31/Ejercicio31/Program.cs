using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
    class Program
    {
        static void Main(string[] args)
        {

            Negocio negocio = new Negocio("Negocio de Gaston");

            Cliente jose = new Cliente("Jose", 1);
            Cliente pablo = new Cliente("Pablo", 2);
            Cliente martin = new Cliente("Martin", 3);
            Cliente anibal = new Cliente("Anibal", 3);

         


            negocio.Cliente = jose;
            negocio.Cliente = pablo;
            negocio.Cliente = martin;
            negocio.Cliente = anibal;

            Console.WriteLine(negocio.Cliente.Nombre);
            bool atentiendo = -negocio;
            atentiendo = -negocio;
            atentiendo = -negocio;
            atentiendo = -negocio;
            




        }
    }
}

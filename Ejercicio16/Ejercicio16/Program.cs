using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio16
{


    class Program { 

    static void Main(string[] args)
        {

            string dibujo;




            Boligrafo boligrafoAzul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boligrafoRojo = new Boligrafo(50, ConsoleColor.Red);


            boligrafoAzul.Pintar(37, out dibujo);
        
            boligrafoRojo.Pintar(55, out dibujo);

            boligrafoRojo.Pintar(32, out dibujo);

            boligrafoAzul.Pintar(42, out dibujo);

            boligrafoAzul.Pintar(20, out dibujo);

            boligrafoAzul.Pintar(3, out dibujo);

            Console.WriteLine("El boligrafo rojo tiene " + boligrafoRojo.getTinta() + " de tinta\n");

            boligrafoRojo.Recargar();

            boligrafoRojo.Pintar(38, out dibujo);
           



        }
    }
}

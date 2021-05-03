using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio29
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();


            Equipo equipo1 = new Equipo(11, "Boca Juniors");
            bool agregar = false;

            for (int i = 0; i < 5; i++)
            {
            agregar = equipo1 + new Jugador(random.Next(30000000, 40000000), GeneradorNombres.CompoundedName(5, 7), random.Next(0, 20), random.Next(0, 20));

            }
            agregar = equipo1 + new Jugador(36764287, GeneradorNombres.CompoundedName(5, 7), random.Next(0, 20), random.Next(0, 20));
            agregar = equipo1 + new Jugador(36764287, GeneradorNombres.CompoundedName(5, 7), random.Next(0, 20), random.Next(0, 20));
            for (int i = 0; i < 10; i++)
            {
                agregar = equipo1 + new Jugador(random.Next(30000000, 40000000), GeneradorNombres.CompoundedName(5, 7), random.Next(0, 20), random.Next(0, 20));

            }

            Console.WriteLine(equipo1.MostrarDatos());


       






        }
    }
}

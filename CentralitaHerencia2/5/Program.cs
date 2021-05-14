using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralitaHerencia;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            PruebaCentralita();
        }

        public static void PruebaCentralita()
        {
            Centralita centralita = new Centralita("La centralita de Gaston");

            Local l1 = new Local(8, "Bernal", "Rosario", 2.65f);


            centralita.Llamadas.Add(l1);
            centralita.Llamadas.Add(new Provincial(21, "Moron", "Bernal", Provincial.Franja.Franja1));
            centralita.Llamadas.Add(new Local(30, "Lanus", "San Rafael", 1.99f));
            centralita.Llamadas.Add(new Provincial(new Llamada(15, "Berazategui", "La Quiaca"), Provincial.Franja.Franja3));

            centralita.OrdenarLlamadas();
            Console.WriteLine(centralita.Mostrar());

        }


        public static void PruebaOrdenamientoImpresionDeLlamadas()
        {
            Random random = new Random();

            List<Provincial> lista = new List<Provincial>();
            List<Local> lista2 = new List<Local>();

            lista2.Add(new Local((float)(random.NextDouble() * 15), random.Next(1500000000, 1599999999).ToString(), random.Next(1500000000, 1599999999).ToString(), 4f));
            lista2.Add(new Local((float)(random.NextDouble() * 15), random.Next(1500000000, 1599999999).ToString(), random.Next(1500000000, 1599999999).ToString(), 4f));
            lista2.Add(new Local((float)(random.NextDouble() * 15), random.Next(1500000000, 1599999999).ToString(), random.Next(1500000000, 1599999999).ToString(), 4f));
            lista2.Add(new Local((float)(random.NextDouble() * 15), random.Next(1500000000, 1599999999).ToString(), random.Next(1500000000, 1599999999).ToString(), 4f));
            lista.Add(new Provincial((float)(random.NextDouble() * 15), random.Next(1500000000, 1599999999).ToString(), random.Next(1500000000, 1599999999).ToString(), Provincial.Franja.Franja1));
            lista.Add(new Provincial((float)(random.NextDouble() * 15), random.Next(1500000000, 1599999999).ToString(), random.Next(1500000000, 1599999999).ToString(), Provincial.Franja.Franja2));
            lista.Add(new Provincial((float)(random.NextDouble() * 15), random.Next(1500000000, 1599999999).ToString(), random.Next(1500000000, 1599999999).ToString(), Provincial.Franja.Franja1));
            lista.Add(new Provincial((float)(random.NextDouble() * 15), random.Next(1500000000, 1599999999).ToString(), random.Next(1500000000, 1599999999).ToString(), Provincial.Franja.Franja3));





            lista.Sort((a, b) => a.OrdenarPorDuracion(a, b));

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i].Mostrar());
            }
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista2[i].Mostrar());
            }

        }
    }
}

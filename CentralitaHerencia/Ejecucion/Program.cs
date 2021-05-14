using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralitaHerencia;

namespace Ejecucion
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<Local> lista = new List<Local>();

            lista.Add(new Local((float)(random.NextDouble() * 15), random.Next(1500000000, 1599999999).ToString(), random.Next(1500000000, 1599999999).ToString(), 4f));
            lista.Add(new Local((float)(random.NextDouble() * 15), random.Next(1500000000, 1599999999).ToString(), random.Next(1500000000, 1599999999).ToString(), 4f));
            lista.Add(new Local((float)(random.NextDouble() * 15), random.Next(1500000000, 1599999999).ToString(), random.Next(1500000000, 1599999999).ToString(), 4f));
            lista.Add(new Local((float)(random.NextDouble() * 15), random.Next(1500000000, 1599999999).ToString(), random.Next(1500000000, 1599999999).ToString(), 4f));
            lista.Add(new Local((float)(random.NextDouble() * 15), random.Next(1500000000, 1599999999).ToString(), random.Next(1500000000, 1599999999).ToString(), 4f));




            lista.Sort((a, b) => a.OrdenarPorDuracion(a, b));

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i].Mostrar());
            }



        }
    }
}

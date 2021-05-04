using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio27
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<string> lista = new List<string>();
            for (int i = 0; i < 20; i++)
            {
                //lista.Add(((char)random.Next(65, 90)).ToString() + ((char)random.Next(65, 90)).ToString());
                lista.Add(((char)random.Next(65, 90)).ToString());

                lista[i] += ((char)random.Next(65, 90)).ToString();
                lista[i] += ((char)random.Next(65, 90)).ToString();


                //Console.WriteLine(lista[i]);
            }







            foreach (string result in lista)
            {
                Console.WriteLine(result);
            }



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class EjemploLINQ
    {

        public EjemploLINQ()
        {
            var dictionary = new Dictionary<string, int>(5);
            dictionary.Add("cat", 1);
            dictionary.Add("dog", 0);
            dictionary.Add("mouse", 5);
            dictionary.Add("eel", 3);
            dictionary.Add("programmer", 2);

            // Order by values.
            // ... Use LINQ to specify sorting by value.
            var items = from pair in dictionary

                        orderby pair.Key ascending
                        select pair;

            // Display results.
            foreach (KeyValuePair<string, int> pair in items)
            {
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
            }

            //Reverse sort.
            // ... Can be looped over in the same way as above.
            //items = from pair in dictionary
            //        orderby pair.Value descending
            //        select pair;
        }

        static void Main(string[] args)
        {
            string texto = Console.ReadLine();

            DiccionarioConContador Diccionario = new DiccionarioConContador(texto);
         
            Diccionario.OrdenarPorContador();
            Console.Write(Diccionario.Imprimir());



        }
    }
}

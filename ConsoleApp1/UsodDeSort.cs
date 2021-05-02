using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class UsodDeSort
    {
        public UsodDeSort()
        {
            List<string> lista = new List<string>();
            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                string temp = ((char)random.Next(97, 122)).ToString();
                temp += ((char)random.Next(97, 122)).ToString();
                temp += ((char)random.Next(97, 122)).ToString();
                temp += ((char)random.Next(97, 122)).ToString();
                temp += ((char)random.Next(97, 122)).ToString();

                lista.Add(temp);
            }

            lista.Sort();


            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);

            }
        }

      
    }
}

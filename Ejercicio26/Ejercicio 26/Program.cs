using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] array = new int[20];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-20, 20);

            }

            int[] arrayCreciente = new int[20];
            int[] arrayDecreciente = new int[20];



            for (int j = 0; j < arrayCreciente.Length; j++)
            {
                arrayCreciente[j] = array[j];
                arrayDecreciente[j] = array[j];

            }

            for (int j = 1; j < arrayCreciente.Length; j++)
            {
                for (int i = 0; i < (arrayCreciente.Length - j); i++)
                {
                    if (arrayCreciente[i + 1] < arrayCreciente[i])
                    {
                        int temp = arrayCreciente[i];
                        arrayCreciente[i] = arrayCreciente[i + 1];
                        arrayCreciente[i + 1] = temp;
                    }
                }
            }

            for (int j = 1; j < arrayDecreciente.Length; j++)
            {
                for (int i = 0; i < (arrayDecreciente.Length - j); i++)
                {
                    if (arrayDecreciente[i + 1] > arrayDecreciente[i])
                    {
                        int temp = arrayDecreciente[i];
                        arrayDecreciente[i] = arrayDecreciente[i + 1];
                        arrayDecreciente[i + 1] = temp;
                    }
                }
            }



            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + "\t" + arrayCreciente[i]+ "\t" + arrayDecreciente[i]);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio29
{
    class GeneradorNombres
    {

        public static string SingleName(int len)
        {
            Random random = new Random(DateTime.Now.Second);

            //Name += consonants[r.Next(consonants.Length)].ToUpper();
            //Name += vowels[r.Next(vowels.Length)];
            //int b = 2; //b tells how many times a new letter has been added. It's 2 right now because the first two letters are already in the name.
            //while (b < len)
            //{
            //    Name += consonants[r.Next(consonants.Length)];
            //    b++;
            //    Name += vowels[r.Next(vowels.Length)];
            //    b++;
            //}

            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };

            string name = "";

            for (int i = 0; i < len; i++)
            {
                if (i % 2 == 0)
                {
                    name += consonants[random.Next(consonants.Length)];
                }
                else
                {
                    name += vowels[random.Next(vowels.Length)];

                }


            }


            return name;
        }

        public static string CompoundedName( int len1, int len2)
        {
            return SingleName(len1) + " " + SingleName(len2);
        }

    }
}

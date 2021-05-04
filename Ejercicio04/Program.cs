using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int contadorPerfectos = 0;
            int numero = 1;
            do
            {
                if(program.esNumeroPerfecto(numero))
                {
                    Console.WriteLine(numero + "es numero perfecto");
                    ++contadorPerfectos;
                }
                ++numero;

            } while (contadorPerfectos < 4);
        
        
        
        }

        public bool esNumeroPerfecto(int numero)
        {
            int total = 0;
            for( int i = 1; i < numero; i++)
            {
                if(esDivisorPositivo(numero, i))
                {
                    total += i;
                }
            }
            if (total == numero)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool esDivisorPositivo(int cociente, int divisor)
        {
            if (cociente % divisor == 0)
            {
                return true;
            }
            else
            {
            }
            return false;
        }
    }
}

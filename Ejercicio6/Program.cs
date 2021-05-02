using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program();
        }
        public Program()
        {
            int inicio, final;
            Console.WriteLine("Ingrese el año de inicio del intervalo:\n");
            inicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el año de finalizacion del intervalo:\n");
            final = int.Parse(Console.ReadLine());
            imprimirBisiestosDeIntervalo(inicio, final);
        }

        public void imprimirBisiestosDeIntervalo( int inicio, int final)
        {
            for( int i = inicio; i <= final; i++)
            {
                if(esBisiesto(i))
                {
                    Console.WriteLine("El año {0} es bisiesto\n", i);
                }
            }
        }

        public bool esBisiesto(int anio)
        {
            if (anio % 4 == 0)
            {
                if ((anio % 100 == 0) && !(anio % 400 == 0))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}

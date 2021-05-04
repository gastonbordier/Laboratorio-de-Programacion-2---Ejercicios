using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {

            Program program = new Program();
            int numero = 0;

            Console.WriteLine("Ingrese un numero\n");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Los centros numericos desde el 0 al {0} son :\n", numero);
            for (int i = 0; i <= numero; i++)
            {
                if (program.esCentroNumerico(i))
                {
                    Console.WriteLine(i);
                }
            }

        }

        public bool esCentroNumerico(int numero)
        {
            if (obtenerUltimoNumero(numero) == -1)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public int obtenerUltimoNumero(int numero)
        {
            int sumaPosteriores = 0;
            int contador = numero;


            while (sumaPosteriores < obtenerSumaDeAnteriores(numero))
            {
                ++contador;
                sumaPosteriores += contador;
            }

            if (numero == 0 || numero == 1) 
            {
                return -1;
            }else if (sumaPosteriores == obtenerSumaDeAnteriores(numero))
            {
                return contador;
            }
            else
            {
                return -1;
            }
        }

        public int obtenerSumaDeAnteriores(int numero)
        {
            int total = 0;
            for (int i = 1; i < numero; i++)
            {
                total += i;
            }
            return total;
        }
    }
}

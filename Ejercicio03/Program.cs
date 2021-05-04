using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            program.mostrarNumerosPrimos(50);

        }
        public void mostrarNumerosPrimos(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if (esNumeroPrimo(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        public bool esNumeroPrimo(int numero)
        {
            bool flagDivisorPositivo = false;

            for (int i = 2; i < numero; i++)
            {
                flagDivisorPositivo = esDivisorPositivo(numero, i);
                if (flagDivisorPositivo == true)
                {
                    break;
                }
            }
            if (flagDivisorPositivo == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool esDivisorPositivo(int cociente, int divisor)
        {
            if (cociente%divisor == 0)
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

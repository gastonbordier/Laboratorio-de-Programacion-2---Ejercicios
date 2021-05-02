using System;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            bool continueAdding = true;
            int total = 0;
            int numTemp = 0;
            char userEntry;
            string userEntryString = "c";
            
            do
            {

                numTemp = program.setNumber();

                total = program.addNumbers(total, numTemp);

                Console.WriteLine("Desea continuar?(S/N");

                userEntry = Console.ReadLine()[0];

                if( program.validaS_N(userEntry) == true)
                {
                    Console.WriteLine("Se Ingresara otro numero");
                }
                else
                {
                    continueAdding = false;
                    Console.WriteLine("Ingreso de secuencia de numeros finalizado.");
                }

            } while (continueAdding == true);

            Console.WriteLine("El total es " + total);

        }

        public int addNumbers(int num1, int num2)
        {
            return num1 + num2;
        }
        public int setNumber()
        {

            int num;

            Console.WriteLine("Ingrese el numero y presione Entrar:");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("Numero ingresado = " + num);
            return num;
        }

        public bool validaS_N(char c)
        {
            if( c == 's')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

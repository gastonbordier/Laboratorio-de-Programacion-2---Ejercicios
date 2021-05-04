using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio8
{
    class Validations
    {
        public static bool setInteger(out int outputInteger, int min, int max, int attempts)
        {
            bool flag = false;
            outputInteger = 0;


            Console.WriteLine("(min = {0} / max = {1})", min, max);
            while (attempts > 0)
            {
                flag = int.TryParse(Console.ReadLine(), out outputInteger);
                if (flag == false)
                {
                    --attempts;
                    Console.WriteLine("Formato de ingreso erroneo. Intentelo nuevamente( Intentos: {0})\n", attempts);
                }
                else if (outputInteger < min || outputInteger > max)
                {
                    --attempts;
                    if (attempts > 0)
                        Console.WriteLine("Numero fuera del rango especificado. Intentelo nuevamente( Intentos: {0})\n", attempts);
                }
                else
                {
                    break;
                }
            }
            if (attempts == 0)
            {
                Console.WriteLine("Intentos agotados. Ingreso cancelado\n");
                return false;
            }
            else
            {
                Console.WriteLine("Ingreso exitoso\n");
                return true;
            }
        }
        public static bool setDouble(out double outputDouble, double min, double max, int attempts)
        {
            bool flag = false;
            outputDouble = 0;


            Console.WriteLine("(min = {0} / max = {1})", min, max);
            while (attempts > 0)
            {
                flag = double.TryParse(Console.ReadLine(), out outputDouble);
                if (flag == false)
                {
                    --attempts;
                    if (attempts > 0)
                        Console.WriteLine("Formato de ingreso erroneo. Intentelo nuevamente( Intentos: {0})\n", attempts);
                }
                else if (outputDouble < min || outputDouble > max)
                {
                    --attempts;
                    Console.WriteLine("Numero fuera del rango especificado. Intentelo nuevamente( Intentos: {0})\n", attempts);
                }
                else
                {
                    break;
                }
            }
            if (attempts == 0)
            {
                Console.WriteLine("Intentos agotados. Ingreso cancelado\n");
                return false;
            }
            else
            {
                Console.WriteLine("Ingreso exitoso\n");
                return true;
            }
        }
        public static bool setString(out string outputString, double min, double max, int attempts)
        {
            bool flag = false;
            outputString = "";


            Console.WriteLine("(min = {0} / max = {1})", min, max);
            while (attempts > 0)
            {
                outputString = Console.ReadLine();
                if (outputString.Length < min || outputString.Length > max)
                {
                    --attempts;
                    if (attempts > 0)
                        Console.WriteLine("Numero fuera del rango especificado. Intentelo nuevamente( Intentos: {0})\n", attempts);
                }
                else
                {
                    break;
                }
            }
            if (attempts == 0)
            {
                Console.WriteLine("Intentos agotados. Ingreso cancelado\n");
                return false;
            }
            else
            {
                Console.WriteLine("Ingreso exitoso\n");
                return true;
            }
        }

        public static bool confirmationSN()
        {
            string input;
            bool inputVerification = false;

            while (inputVerification == false)
            {
                input = Console.ReadLine().ToLower();

                if (input.Equals("s"))
                {
                    inputVerification = true;
                    break;
                }
                else if (input.Equals("n"))
                {
                    inputVerification = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Ingreso equivocado. Intentelo nuevamente:");

                }
            }
            return inputVerification;

        }
    }
}

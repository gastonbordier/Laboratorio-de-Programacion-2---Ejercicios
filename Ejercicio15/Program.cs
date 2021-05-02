using System;

namespace Ejercicio15
{
    class Calculadora
    {
        static void Main(string[] args)
        {

            double num1, num2;
            char operacion;
            bool validacionSalida = false;
            String salida;

            Console.Write("Bienvenido a Calculadora\n");


            do
            {
                Console.Write("Ingrese el primer numero\n");
                num1 = Calculadora.ingresarNumero();
                Console.Write("Ingrese el segundo numero\n");
                num2 = Calculadora.ingresarNumero();
                Console.Write("Ingrese la operacion a realizar\n");
                operacion = Calculadora.ingresarOperacion();

                if (validar(num2))
                {
                    Console.Write("El resultado es " + Calculadora.calcular(num1, num2, operacion) + "\n");
                }
                else
                {
                    Console.Write("La division por cero no tiene un resultado definido\n");
                }

                Console.Write("Desea realizar otra operacion(s/n)\n");

                do
                {
                    salida = Console.ReadLine();


                    switch (salida)
                    {
                        case "s":
                        case "S":
                            Console.WriteLine("Nueva operacion iniciada. ");
                            break;
                        case "n":
                        case "N":
                            Console.WriteLine("Adios!");
                            validacionSalida = true;
                            break;
                        default:
                            Console.WriteLine("Ingreso de opcion incorrecta. Intentelo nuevamente\n");
                            break;
                    }

                } while (salida != "s" && salida != "n" && salida != "S" && salida != "N");

            } while (validacionSalida == false);

            

        }
        public static double ingresarNumero()
        {
            string numS;
            double num;
            bool validReturn;

            do
            {
                numS = Console.ReadLine();

                validReturn = Double.TryParse(numS, out num);

                if (validReturn == false)
                {
                    Console.WriteLine("Ingreso erroneo. Intentelo nuevamente\n");
                }
                else
                {
                    Console.WriteLine("El numero ingresado fue " + num.ToString() + "\n");
                }

            } while (validReturn != true);




            return num;
        }
        public static char ingresarOperacion()
        {
            char operacion;
            bool validReturn = false;

            do
            {
                operacion = Console.ReadKey().KeyChar;
                Console.WriteLine("\n");

                switch (operacion)
                {
                    case '+':
                        Console.WriteLine("La operacion elegida fue +\n");
                        validReturn = true;
                        break;
                    case '-':
                        Console.WriteLine("La operacion elegida fue -\n");
                        validReturn = true;
                        break;
                    case '*':
                        Console.WriteLine("La operacion elegida fue *\n");
                        validReturn = true;
                        break;
                    case '/':
                        Console.WriteLine("La operacion elegida fue /\n");
                        validReturn = true;
                        break;
                    default:
                        Console.WriteLine("El caracter ingresado no corresponde a ninguna de\nlas cuatro operaciones aritmeticas posibles.\nIntentelo nuevamente");
                        break;


                }




            } while (validReturn != true);




            return operacion;
        }

        public static bool validar(double segundoNumero)
        {

            if (segundoNumero == 0)
                return false;
            else
                return true;
        }

        public static double calcular(double primerNumero, double segundoNumero, char operacion)
        {
            switch (operacion)
            {
                case '+':
                    return primerNumero + segundoNumero;
                    break;
                case '-':
                    return primerNumero - segundoNumero;
                    break;
                case '*':
                    return primerNumero * segundoNumero;
                    break;
                case '/':
                    return primerNumero / segundoNumero;
                    break;
                default:
                    return 0;
                    break;


            }
        }
    }
}

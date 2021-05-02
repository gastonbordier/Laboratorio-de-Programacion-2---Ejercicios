using System;

namespace Ejercicio2
{
    class Ejercicio2
    {

        public static void Main(string[] args)
        {

            Ejercicio2 ejercicio2 = new Ejercicio2();

            int number = ejercicio2.setNumber();
            Console.WriteLine("El numero al cuadrado es " + Math.Pow(number, 2));
            Console.WriteLine("El numero al cubo es " + Math.Pow(number, 3));





        }
        public int setNumber()
        {

            int num;

            Console.WriteLine("Ingrese el numero y presione Entrar:");
            num = int.Parse(Console.ReadLine());

            while (num <= 0)
            {
                Console.WriteLine("ERROR! Reingresar numero");
                num = int.Parse(Console.ReadLine());

            }


            Console.WriteLine("Numero ingresado = " + num);
            return num;
        }



    }
}

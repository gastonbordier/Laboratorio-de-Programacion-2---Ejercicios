using System;

namespace Ejercicio11
{
    class Validacion
    {
        static void Main(string[] args)
        {
            Validacion validacion = new Validacion();
            int num1 = validacion.setNumber();
            int num2 = validacion.setNumber();
            int num3 = validacion.setNumber();
            int num4 = validacion.setNumber();
            int num5 = validacion.setNumber();
            int num6 = validacion.setNumber();
            int num7 = validacion.setNumber();
            int num8 = validacion.setNumber();
            int num9 = validacion.setNumber();
            int num10 = validacion.setNumber();

            int max = validacion.getMaxim(num1, num2, num3, num4, num5, num6, num7, num8, num9, num10);
            int min = validacion.getMinim(num1, num2, num3, num4, num5, num6, num7, num8, num9, num10);
            double average = validacion.getAverage(num1, num2, num3, num4, num5, num6, num7, num8, num9, num10);

            Console.WriteLine("El maximo es " + max+ ".");
            Console.WriteLine("El minimo es " + min + ".");
            Console.WriteLine("El promedio es " + average+ ".");





        }




        public static bool validar( int valor, int min, int max)
        {
            if( valor < -100 || valor > 100)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public int setNumber()
        {

            int num;

            Console.WriteLine("Ingrese el numero y presione Entrar:");
            num = int.Parse(Console.ReadLine());

            while (!validar(num, -100, 100))
            {
                Console.WriteLine("Validacion incorrecta");

               num = int.Parse(Console.ReadLine());

            }


            Console.WriteLine("Numero ingresado = " + num);
            return num;
        }
        public int getMax(int numA, int numB)
        {
            if (numA >= numB)
            {
                return numA;
            }
            else
            {
                return numB;
            }

        }
        public int getMin(int numA, int numB)
        {
            if (numA <= numB)
            {
                return numA;
            }
            else
            {
                return numB;
            }

        }

        public int getMaxim(int numA, int numB, int numC, int numD, int numE, int numF, int numG, int numH, int numI, int numJ)
        {
            int maxim;

            maxim = getMax(numA, numB);
            maxim = getMax(maxim, numC);
            maxim = getMax(maxim, numD);
            maxim = getMax(maxim, numE);
            maxim = getMax(maxim, numF);
            maxim = getMax(maxim, numG);
            maxim = getMax(maxim, numH);
            maxim = getMax(maxim, numI);
            maxim = getMax(maxim, numJ);


            return maxim;

        }
        public int getMinim(int numA, int numB, int numC, int numD, int numE, int numF, int numG, int numH, int numI, int numJ)
        {
            int minim;

            minim = getMin(numA, numB);
            minim = getMin(minim, numC);
            minim = getMin(minim, numD);
            minim = getMin(minim, numE);
            minim = getMin(minim, numF);
            minim = getMin(minim, numG);
            minim = getMin(minim, numH);
            minim = getMin(minim, numI);
            minim = getMin(minim, numJ);


            return minim;

        }
        public double getAverage(int numA, int numB, int numC, int numD, int numE, int numF, int numG, int numH, int numI, int numJ)
        {
            int total;
            double average;

            total = numA + numB + numC + numD + numE + numF + numG + numH + numI + numJ;
            average = (double)total / (double)10;

            return average;

        }
    }
}

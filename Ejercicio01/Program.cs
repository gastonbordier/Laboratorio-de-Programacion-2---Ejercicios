using System;

namespace HolaMundo
{
    class Ejercicio1
    {
        static void Main2(string[] args)
        {
            Ejercicio1 program = new Ejercicio1();
            int num1, num2, num3, num4, num5;
            int numMax, numMin;
            float average;


            num1 = program.setNumber();
            num2 = program.setNumber();
            num3 = program.setNumber();
            num4 = program.setNumber();
            num5 = program.setNumber();

            Console.WriteLine("El maximo es " + (int)program.getMaxim(num1, num2, num3, num4, num5));
            Console.WriteLine("El minimo es " + (int)program.getMinim(num1, num2, num3, num4, num5));
            Console.WriteLine("El promedio es " +
                program.getAverage(num1, num2, num3, num4, num5));




        }

        public int setNumber()
        {

            int num;

            Console.WriteLine("Ingrese el numero y presione Entrar:");
            num = int.Parse(Console.ReadLine());


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

        public int getMaxim(int numA, int numB, int numC, int numD, int numE)
        {
            int maxim;

            maxim = getMax(numA, numB);
            maxim = getMax(maxim, numC);
            maxim = getMax(maxim, numD);
            maxim = getMax(maxim, numE);

            return maxim;

        }
        public int getMinim(int numA, int numB, int numC, int numD, int numE)
        {
            int minim;

            minim = getMin(numA, numB);
            minim = getMin(minim, numC);
            minim = getMin(minim, numD);
            minim = getMin(minim, numE);

            return minim;

        }
        public double getAverage(int numA, int numB, int numC, int numD, int numE)
        {
            int total;
            double average;

            total = numA + numB + numC + numD + numE;
            average = (double)total / (double)5;

            return average;

        }

    }
   


   
}

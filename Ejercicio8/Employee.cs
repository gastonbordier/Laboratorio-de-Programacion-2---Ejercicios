using System;

namespace Ejercicio8
{
    class Employee
    {
        private double hourlyValue;
        private string name;
        private int seniority;
        private int workedHours;

        bool flagExit = false;

        public Employee()
        {

           

            do
            {

                if (enterData())
                {
                    Console.WriteLine("Ingreso de datos exitoso.");
                }
                else
                {
                    Console.WriteLine("Ingreso de datos de empleado cancelado. Desea intentar de nuevo?(S/N)");
                    flagExit = Validations.confirmationSN();
                }


            } while (flagExit == true);
            Console.WriteLine("Aplicacion terminada.");
        }
        public bool enterData()
        {
            bool flag;
            Console.WriteLine("Ingrese el valor por hora:\n");
            flag = Validations.setDouble(out hourlyValue, 10, 500, 3);
            if (flag != false)
            {
                Console.WriteLine("Ingrese el name del empleado:\n");
                Validations.setString(out name, 3, 50, 3);
            }
            if (flag != false)
            {
                Console.WriteLine("Ingrese la seniority en años:\n");
                flag = Validations.setInteger(out seniority, 0, 50, 3);
            }
            if (flag != false)
            {
                Console.WriteLine("Ingrese la cantidad de horas trabajadas en el mes:\n");
                flag = Validations.setInteger(out seniority, 1, 300, 3);
                flag = Validations.setInteger(out seniority, 1, 300, 3);
            }
            if (flag != false)
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        public double getHourlyValue()
        {
            return hourlyValue;
        }
        public int getSeniority()
        {
            return seniority;
        }
        public int getWorkedHours()
        {
            return workedHours;
        }
        public string getName()
        {
            return name;
        }


        public static void Main(String[] args)
        {
            new Employee();
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio16
{
    public class Alumno
    {

        private byte nota1;
        private byte nota2;
        private float notaFinal;
        private string apellido;
        private string nombre;
        private int legajo;



        public void estudiar(byte notaA, byte notaB)
        {
            this.nota1 = notaA;
            this.nota2 = notaB;
        }
        public void establecerDatos(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;

        }
        public void calcularFinal()
        {
            if (nota1 >= 4 && nota2 >= 4)
            {
                notaFinal = ((float)nota1 + (float)nota2) / (float)2;
            }
            else
            {
                notaFinal = -1;
            }

        }
        public void mostrar()
        {
            Console.WriteLine("Nombre y apellido : " + this.nombre + " " + this.apellido);
            Console.WriteLine("Legajo n° " + this.legajo);
            Console.WriteLine("Nota primer parcial: " + this.nota1);
            Console.WriteLine("Nota segundo parcial: " + this.nota2);
            if (this.notaFinal != -1)
            {
                Console.WriteLine("Nota final: " + this.notaFinal);

            }
            else
            {
                Console.WriteLine("Alumno desaprobado");
            }


        }
    }
}

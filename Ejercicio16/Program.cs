using System;

namespace Ejercicio16
{

    class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();

            Alumno alumno1 = new Alumno();
            alumno1.establecerDatos("Gaston", "Bordier", 103116);
            alumno1.estudiar((byte)random.Next(0, 10), (byte)random.Next(0, 10));
            alumno1.calcularFinal();
            alumno1.mostrar();
            Alumno alumno2 = new Alumno();
            alumno2.establecerDatos("Jose", "Fatugas", 103117);
            alumno2.estudiar((byte)random.Next(0, 10), (byte)random.Next(0, 10));
            alumno2.calcularFinal();
            alumno2.mostrar();
            Alumno alumno3 = new Alumno();
            alumno3.establecerDatos("Alan", "Meloin", 103118);
            alumno3.estudiar((byte)random.Next(0, 10), (byte)random.Next(0, 10));
            alumno3.calcularFinal();
            alumno3.mostrar();



        }
    }


}
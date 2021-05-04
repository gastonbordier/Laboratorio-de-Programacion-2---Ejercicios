using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ejercicio31
{
    class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        private PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto) : this()
        {
            this.puesto = puesto;
        }

        public bool Atender( Cliente cliente)
        {
            Console.WriteLine("Atendiendo al cliente {0}...\n", cliente.Nombre);
            Thread.Sleep(2500);
            Console.WriteLine("Final de Atencion\n");
            return true;
        }

        public int NumeroActual
        {
            get
            {
                ++numeroActual;
                return numeroActual;
            }
        }

        public enum Puesto
        {
            Caja1,
            Caja2,
        }
    }
}

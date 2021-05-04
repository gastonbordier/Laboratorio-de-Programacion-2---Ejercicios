using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
    class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        private Negocio()
        {
            clientes = new Queue<Cliente>();
            caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static bool operator +(Negocio negocio, Cliente clienteIngresante)
        {
            if (negocio.ClienteYaIncluido(clienteIngresante))
            {
                Console.WriteLine("{0} no fue agregado.\n", clienteIngresante.Nombre);
                return false;
            }
            else
            {
                negocio.clientes.Enqueue(clienteIngresante);
                Console.WriteLine("{0} fue agregado a la cola.\n", clienteIngresante.Nombre);
                return true;
            }


        }

        public static bool operator -(Negocio negocio)
        {

            if (negocio.clientes.Count > 0)
            {

                negocio.caja.Atender(negocio.clientes.Peek());
                Console.WriteLine("El cliente {0} acaba de ser atentido\n", negocio.clientes.Dequeue());
                return true;
            }
            else
            {
                Console.WriteLine("Ya no quedan clientes que atender\n");
                return false;
            }
        }

        public Cliente Cliente
        {
            get
            {

                Console.WriteLine("El proximo cliente en la cola es:");
                return clientes.Peek();
            }
            set
            {
                bool ClienteFueAgregado = false;

                ClienteFueAgregado = this + value;

            }
        }

        private bool ClienteYaIncluido(Cliente cliente)
        {
            bool clienteYaIncluido = false;

            for (int i = 0; i < clientes.Count; i++)
            {
                if (clientes.ElementAt(i) == cliente)
                {
                    clienteYaIncluido = true;
                    break;
                }
            }

            if (clienteYaIncluido)
            {
                Console.WriteLine("El cliente {0} ya esta en la cola\n", cliente.Nombre);
                return true;
            }
            else
            {
                Console.WriteLine("El cliente {0} no está en la cola\n", cliente.Nombre);
                return false;
            }
        }

    }
}

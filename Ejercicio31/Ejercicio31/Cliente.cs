using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
    class Cliente
    {
        private string nombre;
        private int numero;

        public Cliente( int numero)
        {
            Numero = numero;
        }

        public Cliente( string nombre, int numero) : this(numero)
        {
            Nombre = nombre;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }

        }

        public int Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }

        }

        public static bool operator ==(Cliente cliente1, Cliente cliente2)
        {
            if (cliente1.Numero == cliente2.Numero)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        
        public static bool operator !=(Cliente cliente1, Cliente cliente2)
        {
            if (cliente1.Numero == cliente2.Numero)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Persona
    {
        int edad;
        string nombre;

        public Persona(int edad, string nombre)
        {
            this.Edad = edad;
            this.nombre = nombre;
        }

        public abstract void ObtenerPersonalidad();

        public virtual 

        public int Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                this.edad = value;
            }
        }
    }
}

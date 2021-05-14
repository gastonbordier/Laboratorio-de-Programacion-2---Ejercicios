using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public string Mostrar()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.AppendFormat("{0,-10:0.00}{1,-15}{2,-15}\n", this.Duracion, this.NroDestino, this.NroOrigen);

            return mostrar.ToString();
        }

        public int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1.Duracion >= llamada2.Duracion)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }

        public float Duracion
        {
            get
            {
                return this.duracion;
            }

        }
        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }

        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }

        }


    }
    public enum TipoLlamada
    {
        Local,
        Provincial,
        Todas
    }
}
